using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FrbaOfertas.Entidades;
using System.Data.SqlClient;
using FrbaOfertas.Conexion;
using FrbaOfertas.Utilidades;
using FrbaOfertas.GestorDeErrores;

namespace FrbaOfertas.AbmRol
{
    public partial class ModificacionRol : Form
    {
        private Form menu;
        private List<Funcionalidad> funcionalidadesTotales;
        private List<Funcionalidad> funcionalidadesDelRol;
        public ModificacionRol(Form vent)
        {
            menu = vent;
            InitializeComponent();

            iniciarComboBox();
        }
        public ModificacionRol()
        {
            InitializeComponent();
            iniciarComboBox();
        }
        private void iniciarComboBox()
        {
            List<Rol> roles = new List<Rol>();
            roles = RepoRol.getInstance().getRoles();
            cmbRoles.DataSource = roles;
            cmbRoles.DisplayMember = "Nombre";
        }
        
        private void ModificacionRol_Load(object sender, EventArgs e)
        {
            iniciarComboBox();
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
        private void anularCamposChequeados()
        {
            for (int i = 0; i < clbFuncionalidades.Items.Count; i++)
            {
                clbFuncionalidades.SetItemChecked(i, false);
            }
        }
        private void cargarCheckedListBox(int id)
        {
            anularCamposChequeados();
            funcionalidadesTotales = Funcionalidad.getFuncionalidades();

            clbFuncionalidades.DataSource = funcionalidadesTotales;
            clbFuncionalidades.DisplayMember = "Nombre";

            Rol r = cmbRoles.SelectedItem as Rol;
            funcionalidadesDelRol = RepoRol.obtenerFuncionalidadesDelRol(r.Nombre);

            for (int i = 0; i < clbFuncionalidades.Items.Count; i++)
            {
                Funcionalidad f = clbFuncionalidades.Items[i] as Funcionalidad;
                if (funcionalidadesDelRol.Any(f_rol => f_rol.Id == f.Id))
                {
                    clbFuncionalidades.SetItemChecked(i, true);
                }
            }
        }
        private void btnSeleccionar_Click(object sender, EventArgs e)
        {
            bloquearBoton(btnHabilitar);
            bloquearBoton(btnDeshabilitar);
            
            Rol r = cmbRoles.SelectedItem as Rol;
            cargarCheckedListBox(r.Id);

            SqlCommand cmd = new SqlCommand("[RE_GDDIENTOS].rol_habilitado");
            cmd.Parameters.Add("@id", SqlDbType.SmallInt).Value = r.Id;
            int i = Conexion.Conexion.ejecutarProcedure(cmd);

            if (i>0) { desbloquearBoton(btnDeshabilitar); }
            else { desbloquearBoton(btnHabilitar); }
        }

        private void btnHabilitar_Click(object sender, EventArgs e)
        {
            cambiarEstadoRol(true);
            MessageBox.Show("Rol habilitado con éxito!","Ok",MessageBoxButtons.OK,MessageBoxIcon.Information);
            bloquearBoton(btnHabilitar);
            desbloquearBoton(btnDeshabilitar);
        }

        private void btnDeshabilitar_Click(object sender, EventArgs e)
        {
            cambiarEstadoRol(false);
            MessageBox.Show("Rol deshabilitado con éxito!", "Ok", MessageBoxButtons.OK, MessageBoxIcon.Information);
            bloquearBoton(btnDeshabilitar);
            desbloquearBoton(btnHabilitar);
        }
        private void cambiarEstadoRol(Boolean bit)
        {
            SqlCommand cmd = new SqlCommand("update [RE_GDDIENTOS].Roles set habilitado = @bit where rol_id=@id");
            Rol r = cmbRoles.SelectedItem as Rol;
            cmd.Parameters.Add("@id", SqlDbType.SmallInt).Value = r.Id;
            cmd.Parameters.Add("@bit", SqlDbType.Bit).Value = bit;

            Conexion.Conexion.ejecutar(cmd);
        }

        private void btnModificarRol_Click(object sender, EventArgs e)
        {
            Rol r = cmbRoles.SelectedItem as Rol;
            foreach (Funcionalidad f in funcionalidadesDelRol)
            {
                String query = String.Format("delete from [RE_GDDIENTOS].FuncionalidadPorRol where rol_id = {0} and funcionalidad_id={1}", Convert.ToInt16(r.Id), Convert.ToInt16(f.Id));
                Conexion.Conexion.ejecutar(query);
            }
            for(int i = 0;i<clbFuncionalidades.CheckedItems.Count;i++)
            {
                Funcionalidad f = clbFuncionalidades.CheckedItems[i] as Funcionalidad;
                String query = String.Format("insert into [RE_GDDIENTOS].FuncionalidadPorRol (rol_id,funcionalidad_id) values({0},{1})", Convert.ToInt16(r.Id), Convert.ToInt16(f.Id));
                Conexion.Conexion.ejecutar(query);
            }
            MessageBox.Show("Rol modificado exitósamente", "Ok", MessageBoxButtons.OK, MessageBoxIcon.Information);
            this.Hide();
            menu.Show();
        }

        private void ModificacionRol_FormClosed(object sender, FormClosedEventArgs e)
        {
            menu.Show();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Hide();
            menu.Show();
        }

    }
}
