using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FrbaOfertas.Conexion;
using FrbaOfertas.Utilidades;
using FrbaOfertas.GestorDeErrores;
using System.Data.SqlClient;
using System.Security.Cryptography;
using FrbaOfertas.Entidades;
using FrbaOfertas.MenuPrincipal;
using FrbaOfertas.Registro_de_usuario;

namespace FrbaOfertas.LoginYSeguridad
{
    public partial class Login : Form
    {

        public Login()
        {
            InitializeComponent();
        }

        private void btnIngresar_Click(object sender, EventArgs e)
        {
            try
            {

                if (txtUsserName.Text != "" && txtPassword.Text != "")
                {
                    GestorDeErrores.GestorDeErrores.verificarExistenciaDeUsuario(txtUsserName.Text.Trim());

                    String query = String.Format("Select * from [RE_GDDIENTOS].Usuarios where nombre_usuario='{0}'", txtUsserName.Text.Trim());
                    DataSet ds = Conexion.Conexion.ejecutarConsulta(query);
                    Usuario usuario = new Usuario();
                    usuario.setNombreUsuario(ds.Tables[0].Rows[0]["nombre_usuario"].ToString().Trim());
                    usuario.setPass(ds.Tables[0].Rows[0]["password"].ToString().Trim());


                    String hash = Utilidades.Utilidades.obtenerHash(txtPassword.Text.Trim());

                    int intentos = Convert.ToInt32(ds.Tables[0].Rows[0]["intentos"].ToString());
                    Boolean habilitado = Convert.ToBoolean(ds.Tables[0].Rows[0]["habilitado"]);
                    SqlCommand cmd = new SqlCommand();

                    if (habilitado == true)
                    {
                        if (usuario.getPass() == hash)
                        {
                            intentos = 0;
                            String query2 = String.Format("update [RE_GDDIENTOS].Usuarios set intentos = {0} where nombre_usuario='{1}'", intentos, usuario.getNombreUsuario());
                            cmd.CommandText = query2;
                            Conexion.Conexion.ejecutar(cmd);

                            IngresarComo ingresarComo = new IngresarComo(usuario);
                            this.Hide();
                            ingresarComo.Show();
                        }
                        else
                        {
                            intentos += 1;
                            if (intentos == Conexion.Conexion.getCantidadDeIntentos())
                            {
                                MessageBox.Show("Intentos agotados. Usuario bloqueado. Contactese con un administrador", "Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                Conexion.Conexion.ejecutar(String.Format("update [RE_GDDIENTOS].Usuarios set habilitado = 0 where nombre_usuario ='{0}'", usuario.getNombreUsuario()));
                            }
                            else
                            {
                                MessageBox.Show("Contraseña incorrecta. Intente nuevamente", "Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                                String query2 = String.Format("update [RE_GDDIENTOS].Usuarios set intentos = {0} where nombre_usuario='{1}'", intentos, usuario.getNombreUsuario());
                                cmd.CommandText = query2;
                                Conexion.Conexion.ejecutar(cmd);
                            }
                        }

                    }
                    else
                    {
                        MessageBox.Show("El usuario se encuentra bloqueado. Contactese con un administrador", "Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else { MessageBox.Show("Complete los campos por favor", "Failed", MessageBoxButtons.OK, MessageBoxIcon.Error); }

            }
            catch (UsuarioInexistenteException error)
            {
                error.mensaje();
            }
            catch (Exception error)
            {
                MessageBox.Show("Error: " + error, "Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }
        

        private void btnRegistrarse_Click(object sender, EventArgs e)
        {
            this.Hide();
            RegistrarUsuario ventana = new RegistrarUsuario(this);
            ventana.Show();
        }


    }
}
