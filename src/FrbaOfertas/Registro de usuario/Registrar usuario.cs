using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using FrbaOfertas.AbmCliente;
using FrbaOfertas.AbmProveedor;
using FrbaOfertas.Entidades;
using FrbaOfertas.Conexion;
using FrbaOfertas.Utilidades;
using FrbaOfertas.GestorDeErrores;
namespace FrbaOfertas.Registro_de_usuario
{
    public partial class RegistrarUsuario : AltaForm
    {
        public RegistrarUsuario(Form ventana)
        {
            InitializeComponent();
            inicializarComboBox();
            inicializarCamposObligatorios();
            this.ventanaAnterior = ventana;
        }
        private void inicializarCamposObligatorios()
        {
            camposObligatorios.Add(txtUsuario);
            camposObligatorios.Add(txtPassword);
        }
        private void inicializarComboBox()
        {
            List<Rol> roles = RepoRol.getInstance().getRoles().Where(rol=>rol.Nombre!="administrador general").ToList<Rol>();
            cmbRol.DisplayMember = "Nombre";
            cmbRol.DataSource = roles;

        }

        private void btnSeleccionar_Click(object sender, EventArgs e)
        {
            try
            {
                if (cmbRol.SelectedItem != null)
                {
                    Usuario user = new Usuario(txtUsuario.Text, txtPassword.Text);
                    GestorDeErrores.GestorDeErrores.verificarCamposObligatoriosCompletos(camposObligatorios);

                    Rol seleccionado = cmbRol.SelectedItem as Rol;
                    GestorDeErrores.GestorDeErrores.verificarUsuarioDuplicado(user.getNombreUsuario());

                    switch (seleccionado.Nombre)
                    {
                        case "cliente":
                            this.Hide();
                            AltaCliente ventanaCliente = new AltaCliente(user, this);
                            ventanaCliente.Show();
                            break;
                        case "proveedor":
                            this.Hide();
                            AltaProveedor ventanaProveedor = new AltaProveedor(user, this);
                            ventanaProveedor.Show();
                            break;
                    }
                }
            }
            catch (CamposObligatoriosIncompletosException error)
            {
                error.mensaje();
            }
            catch (UsuarioDuplicadoException error)
            { error.mensaje(); }
            finally
            {
                Conexion.Conexion.getCon().Close();
            }
            
            

        }
        
        private void RegistrarUsuario_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.ventanaAnterior.Show();
        }
        
        
    }
}
