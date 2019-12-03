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
using FrbaOfertas.GestorDeErrores;
using FrbaOfertas.Utilidades;
namespace FrbaOfertas.AbmRol
{
    public partial class BajaRol : Form
    {
        private Form menu;
        public BajaRol()
        {
            InitializeComponent();
        }
        public BajaRol(Form vent)
        {
            InitializeComponent();
            menu = vent;
        }
        
        private void BajaRol_Load(object sender, EventArgs e)
        {
            List<Rol> roles = RepoRol.getInstance().getRolesHabilitados();
            cmbRoles.DataSource = roles;
            cmbRoles.DisplayMember = "Nombre";
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            menu.Show();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            Rol r = cmbRoles.SelectedItem as Rol;
            try{
                GestorDeErrores.GestorDeErrores.verificarRolHabilitado(r.Id);
                SqlCommand cmd = new SqlCommand("update [RE_GDDIENTOS].Roles set habilitado = 0 where rol_id=@r");
                cmd.Parameters.Add("@r", SqlDbType.SmallInt).Value = r.Id;
                Conexion.Conexion.ejecutar(cmd);
                MessageBox.Show("Rol dado de baja con éxito!", "Ok", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Hide();
                menu.Show();
            }catch(RolInhabilitadoException error)
            { error.mensaje();}
        }
    }
}
