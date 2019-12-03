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
using FrbaOfertas.Conexion;
using System.Configuration;

namespace FrbaOfertas
{
    public partial class VentanaPrincipal : Form
    {
        public string fechaConfig = System.Configuration.ConfigurationSettings.AppSettings["fechaConfig"];
        
        public VentanaPrincipal()
        {
            InitializeComponent();
        }

        private void btnSesionUsuario_Click(object sender, EventArgs e)
        {
            try
            {
                ClaseConexion bd = new ClaseConexion();
                SqlCommand procedure = Conexion.ClaseConexion.crearConsulta("[LEISTE_EL_CODIGO?].sp_login");
                procedure.CommandType = CommandType.StoredProcedure;
                procedure.Parameters.AddWithValue("@id_ingresado", SqlDbType.NVarChar).Value = txtUsuario.Text;
                procedure.Parameters.Add("@contraseña_ingresada", SqlDbType.NVarChar).Value = txtContraseña.Text;
                procedure.Parameters.Add("@retorno", SqlDbType.Int).Direction = System.Data.ParameterDirection.ReturnValue;
                bd.ejecutarConsultaDevuelveInt(procedure);
                int retorno = (int)procedure.Parameters["@retorno"].Value;
                //inicia sesion
                if (retorno == 1)
                {
                    //TODO
                }
                else
                {
                    //no existe el usuario
                    MessageBox.Show("NO existe el usuario", "FrbaOfertas", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtContraseña.Clear();
                    txtUsuario.Clear();
                }

            }
            catch (Exception error)
            {
                MessageBox.Show(error.Message);
            }
        }

        private void btnSesionCliente_Click(object sender, EventArgs e)
        {
            this.Hide();
            ClaseConexion bd = new ClaseConexion();
            SqlCommand reservasVencidas = Conexion.ClaseConexion.crearConsulta("[LEISTE_EL_CODIGO?].eliminarReservasVencidas");
            reservasVencidas.CommandType = CommandType.StoredProcedure;
            DateTime enteredDate = DateTime.Parse(fechaConfig);
            reservasVencidas.Parameters.AddWithValue("@fechaConfig", SqlDbType.DateTime).Value = enteredDate;
            bd.ejecutarConsultaSinResultado(reservasVencidas);
            VentanaMenu menu = new VentanaMenu();
            menu.Show();
            menu.ocultarBotones("cliente");
        }

        public static void ventanaErrorBD(Exception excepcion)
        {
            MessageBox.Show("ERROR EN LA BASE DE DATOS:\n" + excepcion.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        public static void ventanaIntentoExitoso(string mensaje)
        {
            MessageBox.Show("AVISO: " + mensaje, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        public static void ventanaError(string mensaje)
        {
            MessageBox.Show("ERROR: " + mensaje, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }


    }
}
