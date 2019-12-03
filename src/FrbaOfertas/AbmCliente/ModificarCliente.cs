using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FrbaOfertas.Listado;
using FrbaOfertas.Entidades;
using FrbaOfertas.Conexion;
using FrbaOfertas.Utilidades;
using FrbaOfertas.GestorDeErrores;


namespace FrbaOfertas.AbmCliente
{
    public partial class ModificarCliente : Form
    {
        private Form menuPrincipal;
        public ModificarCliente(Form vent)
        {
            InitializeComponent();
            menuPrincipal = vent;
        }
        public ModificarCliente()
        {
            InitializeComponent();
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            Form vent = new ListadoCliente(txtDni);
            vent.Show();
            bloquearBoton(btnDeshabilitar);
            bloquearBoton(btnHabilitar);
        }

        private void txtDni_TextChanged(object sender, EventArgs e)
        {
            btnModificar.Enabled = true;
            btnModificar.BackColor = SystemColors.Control;
            txtDni.BackColor = Color.White;
            if (!clienteHabilitado(txtDni.Text))
            {
                btnHabilitar.Enabled = true;
                btnHabilitar.BackColor = SystemColors.Control;
            }
            else
            {
                btnDeshabilitar.Enabled = true;
                btnDeshabilitar.BackColor = SystemColors.Control;
            }
        }
        private void btnModificar_Click(object sender, EventArgs e)
        {
            
                String query = String.Format("Select * from [RE_GDDIENTOS].Clientes where dni='{0}'", txtDni.Text);
                DataSet ds = Conexion.Conexion.ejecutarConsulta(query);
                Int16 piso = new Int16();
                Char dpto = new Char();
                if (DBNull.Value != ds.Tables[0].Rows[0]["piso"]) { piso = Convert.ToInt16(ds.Tables[0].Rows[0]["piso"]); }
                if (DBNull.Value != ds.Tables[0].Rows[0]["dpto"]) { dpto = Convert.ToChar(ds.Tables[0].Rows[0]["dpto"]); }

                Cliente cliente = new Cliente(
                    ds.Tables[0].Rows[0]["dni"].ToString(),
                    ds.Tables[0].Rows[0]["cliente_nombre"].ToString(),
                    ds.Tables[0].Rows[0]["cliente_apellido"].ToString(),
                    Convert.ToDateTime(ds.Tables[0].Rows[0]["fecha_nacimiento"]),
                    ds.Tables[0].Rows[0]["ciudad"].ToString(),
                    ds.Tables[0].Rows[0]["codigo_postal"].ToString(),
                    ds.Tables[0].Rows[0]["telefono"].ToString(),
                    ds.Tables[0].Rows[0]["email"].ToString(),
                    ds.Tables[0].Rows[0]["direccion"].ToString(),
                    piso,
                    dpto,
                    Convert.ToBoolean(ds.Tables[0].Rows[0]["habilitado"]),
                    ds.Tables[0].Rows[0]["nombre_usuario"].ToString()
                    );
                this.Hide();
                Form v = new ModificarPerfilCliente(cliente, menuPrincipal);

                v.Show();
        }
        private Boolean clienteHabilitado(String dni)
        {
            String query = String.Format("Select habilitado from [RE_GDDIENTOS].Clientes where dni = '{0}'", dni);
            return Convert.ToBoolean(Conexion.Conexion.ejecutarConsulta(query).Tables[0].Rows[0]["habilitado"]);
        }

        private void btnHabilitar_Click(object sender, EventArgs e)
        {
            String query = String.Format("update [RE_GDDIENTOS].Clientes set habilitado = 1 where dni='{0}'", txtDni.Text);
            Conexion.Conexion.ejecutar(query);
            MessageBox.Show("Cliente habilitado con éxito!", "Ok", MessageBoxButtons.OK, MessageBoxIcon.Information);
            bloquearBoton(btnHabilitar);
            desbloquearBoton(btnDeshabilitar);
        }

        private void btnDeshabilitar_Click(object sender, EventArgs e)
        {
            String query = String.Format("update [RE_GDDIENTOS].Clientes set habilitado = 0 where dni='{0}'", txtDni.Text);
            Conexion.Conexion.ejecutar(query);
            MessageBox.Show("Cliente deshabilitado con éxito!", "Ok", MessageBoxButtons.OK, MessageBoxIcon.Information);
            bloquearBoton(btnDeshabilitar);
            desbloquearBoton(btnHabilitar);
        }
        private void bloquearBoton(Button btn)
        {
            btn.Enabled = false;
            btn.BackColor = SystemColors.ControlDarkDark;
        }
        private void desbloquearBoton(Button btn)
        {
            btn.Enabled = true;
            btn.BackColor = SystemColors.Control;
        }
        
    }
}
