using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FrbaOfertas.LoginYSeguridad;
using FrbaOfertas.Conexion;
using FrbaOfertas.Utilidades;
using FrbaOfertas.GestorDeErrores;
using FrbaOfertas.Entidades;
using FrbaOfertas.MenuPrincipal;
namespace FrbaOfertas.LoginYSeguridad
{
    public partial class IngresarComo : Form
    {
        private Usuario usuario;
        
        public IngresarComo(Usuario us)
        {
            InitializeComponent();
            usuario=us;
            inicializarComboBox();

        }

        private void inicializarComboBox()
        {
            String query = String.Format("Select rol_nombre,t1.rol_id from [RE_GDDIENTOS].UsuarioPorRol t1 join [RE_GDDIENTOS].Roles t2 on (t1.rol_id=t2.rol_id) where nombre_usuario='{0}' and habilitado = 1", usuario.getNombreUsuario());
            DataSet ds = Conexion.Conexion.ejecutarConsulta(query);
            List<Rol> roles = new List<Rol>();
            foreach (DataRow fila in ds.Tables[0].Rows)
            {
                Rol r = new Rol(fila["rol_nombre"].ToString(),Convert.ToInt16(fila["rol_id"]));
                roles.Add(r);
            }
            cmbRoles.DataSource = roles;
            cmbRoles.DisplayMember = "Nombre";
        }

        private void btnIngresar_Click(object sender, EventArgs e)
        {
            if (cmbRoles.SelectedItem != null)
            {
                Rol r = cmbRoles.SelectedItem as Rol;
                usuario.setRol(r);
                MenuPrincipal.MenuPrincipal menu = new MenuPrincipal.MenuPrincipal(usuario);
                menu.Show();
                this.Close();
            }
        }

        private void btnAtras_Click(object sender, EventArgs e)
        {
            this.Close();
            Login v = new Login();
            v.Show();
        }

            
    }
}
