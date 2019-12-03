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
using FrbaOfertas.Conexion;
using FrbaOfertas.Utilidades;
using FrbaOfertas.GestorDeErrores;
using FrbaOfertas.Entidades;


namespace FrbaOfertas.AbmProveedor
{
    public partial class ModificarProveedor : Form
    {
        private Form menu;
        public ModificarProveedor()
        {
            InitializeComponent();
        }
        public  ModificarProveedor(Form v)
        {
            InitializeComponent();
            menu = v;
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            Form vent = new ListadoDeProveedores(txtCuit);
            vent.Show();
            bloquearBoton(btnDeshabilitar);
            bloquearBoton(btnHabilitar);
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

        private void txtCuit_TextChanged(object sender, EventArgs e)
        {
            btnModificar.Enabled = true;
            btnModificar.BackColor = SystemColors.Control;
            if (!proveedorHabilitado(txtCuit.Text))
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
        private Boolean proveedorHabilitado(String cuit)
        {
            String query = String.Format("Select habilitado from [RE_GDDIENTOS].Proveedores where cuit = '{0}'", cuit);
            return Convert.ToBoolean(Conexion.Conexion.ejecutarConsulta(query).Tables[0].Rows[0]["habilitado"]);
        }

        private void btnHabilitar_Click(object sender, EventArgs e)
        {
            String query = String.Format("update [RE_GDDIENTOS].Proveedores set habilitado = 1 where cuit='{0}'", txtCuit.Text);
            Conexion.Conexion.ejecutar(query);
            MessageBox.Show("Proveedor habilitado con éxito!", "Ok", MessageBoxButtons.OK, MessageBoxIcon.Information);
            bloquearBoton(btnHabilitar);
            desbloquearBoton(btnDeshabilitar);
        }

        private void btnDeshabilitar_Click(object sender, EventArgs e)
        {
            String query = String.Format("update [RE_GDDIENTOS].Proveedores set habilitado = 0 where cuit='{0}'", txtCuit.Text);
            Conexion.Conexion.ejecutar(query);
            MessageBox.Show("Proveedor deshabilitado con éxito!", "Ok", MessageBoxButtons.OK, MessageBoxIcon.Information);
            bloquearBoton(btnDeshabilitar);
            desbloquearBoton(btnHabilitar);
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            
                String query = String.Format("Select * from [RE_GDDIENTOS].Proveedores where cuit='{0}'", txtCuit.Text);
                DataSet ds = Conexion.Conexion.ejecutarConsulta(query);
                Int16 piso = new Int16();
                Char dpto = new Char();
                if (DBNull.Value != ds.Tables[0].Rows[0]["piso"]) { piso = Convert.ToInt16(ds.Tables[0].Rows[0]["piso"]); }
                if (DBNull.Value != ds.Tables[0].Rows[0]["dpto"]) { dpto = Convert.ToChar(ds.Tables[0].Rows[0]["dpto"]); }

                Proveedor proveedor = new Proveedor(
                    ds.Tables[0].Rows[0]["rs"].ToString(),
                    ds.Tables[0].Rows[0]["cuit"].ToString(),
                    ds.Tables[0].Rows[0]["nombre_contacto"].ToString(),
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
                Form v = new ModificarPerfilProveedor(proveedor, menu);

                v.Show();
        }

        private void ModificarProveedor_FormClosed(object sender, FormClosedEventArgs e)
        {
            menu.Show();
        }
    }
}
