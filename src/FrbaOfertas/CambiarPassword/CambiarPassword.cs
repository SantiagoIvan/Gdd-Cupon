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
using FrbaOfertas.Conexion;
using FrbaOfertas.Utilidades;
using FrbaOfertas.GestorDeErrores;
namespace FrbaOfertas.CambiarPassword
{
    public partial class CambiarPassword : AltaForm
    {
        private Usuario usuario;
        public CambiarPassword(Usuario us)
        {
            InitializeComponent();
            usuario = us;
            inicializarCamposObligatorios();
        }
        private void inicializarCamposObligatorios()
        {
            camposObligatorios.Add(txtConfirmNuevaContraseña);
            camposObligatorios.Add(txtNuevaContraseña);
        }
        private void btnConfirmar_Click(object sender, EventArgs e)
        {
            
                try
                {
                    GestorDeErrores.GestorDeErrores.verificarCamposObligatoriosCompletos(camposObligatorios);

                    if (txtNuevaContraseña.Text == txtConfirmNuevaContraseña.Text)
                    {
                        String hash = Utilidades.Utilidades.obtenerHash(txtNuevaContraseña.Text);
                        String query = String.Format("Update [RE_GDDIENTOS].Usuarios set password = '{0}' where nombre_usuario ='{1}'", hash, usuario.getNombreUsuario());
                        Conexion.Conexion.ejecutar(query);
                        MessageBox.Show("Clave cambiada exitósamente!", "Ok", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        this.Close();
                    }
                    else
                    {
                        MessageBox.Show("Password ingresado inválido", "Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                catch (CamposObligatoriosIncompletosException error)
                {
                    error.mensaje();
                }
                
            }
        

    }
}
