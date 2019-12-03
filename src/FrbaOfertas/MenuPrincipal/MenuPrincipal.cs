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
using FrbaOfertas.CambiarPassword;
using FrbaOfertas.LoginYSeguridad;
using FrbaOfertas.Conexion;
using FrbaOfertas.Utilidades;
using FrbaOfertas.GestorDeErrores;
using System.Data.SqlClient;
namespace FrbaOfertas.MenuPrincipal
{
    public partial class MenuPrincipal : Form
    {
        Usuario usuario;
        public MenuPrincipal(Usuario us)
        {
            InitializeComponent();
            usuario = us;
            inicializarFuncionalidades();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void MenuPrincipal_Load(object sender, EventArgs e)
        {
            lblUsuario.Text = usuario.getNombreUsuario();
            lblR.Text = usuario.getRol().Nombre.ToString();
            if (!usuarioConRolHabilitado())
            {
                btnSeleccionar.BackColor = SystemColors.ControlDarkDark;
                btnSeleccionar.Enabled = false;
                MessageBox.Show("Usted se encuentra bloqueado y no puede ejecutar ninguna funcionalidad. Contactese con un administrador","Failed",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
        }
        private void inicializarFuncionalidades()
        {
            String query = String.Format("exec [RE_GDDIENTOS].obtener_funcionalidades_del_rol {0};", usuario.getRol().Id);
            DataSet ds = Conexion.Conexion.ejecutarConsulta(query);
            List<Funcionalidad> funcionalidades = new List<Funcionalidad>();

            foreach (DataRow fila in ds.Tables[0].Rows)
            {
                funcionalidades.Add(new Funcionalidad(Convert.ToInt16(fila["funcionalidad_id"]), fila["funcionalidad_nombre"].ToString()));
            }
            cmbFuncionalidades.DataSource = funcionalidades;
            cmbFuncionalidades.DisplayMember = "Nombre";
        }

        private void btnCambiarContraseña_Click(object sender, EventArgs e)
        {
            CambiarPassword.CambiarPassword ventana=new CambiarPassword.CambiarPassword(usuario);
            ventana.Show();
        }

        private void btnSeleccionar_Click(object sender, EventArgs e)
        {
            Funcionalidad funcionalidadSeleccionada = cmbFuncionalidades.SelectedItem as Funcionalidad;
            Form form = funcionalidadSeleccionada.getForm(this,usuario);
            form.Show();
            this.Hide();
        }

        private void MenuPrincipal_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private Boolean usuarioConRolHabilitado()
        {
            Boolean flag = false;
            switch (lblR.Text)
            {
                case "cliente":
                    String query = String.Format("select habilitado from [RE_GDDIENTOS].Clientes where nombre_usuario='{0}'", usuario.getNombreUsuario());
                    flag = Convert.ToBoolean(Conexion.Conexion.ejecutarConsulta(query).Tables[0].Rows[0]["habilitado"]);
                    break;
                case "proveedor":
                    String query2 = String.Format("select habilitado from [RE_GDDIENTOS].Proveedores where nombre_usuario='{0}'", usuario.getNombreUsuario());
                    flag = Convert.ToBoolean(Conexion.Conexion.ejecutarConsulta(query2).Tables[0].Rows[0]["habilitado"]);
                    break;
                case "administrador general":
                    flag=true;
                    break;
            }
            return flag;
        }

    }

}
