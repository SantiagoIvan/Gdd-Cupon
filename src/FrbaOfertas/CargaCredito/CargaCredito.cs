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
using FrbaOfertas.Listado;
using System.Data.SqlClient;
using FrbaOfertas.Conexion;
using FrbaOfertas.Utilidades;
using FrbaOfertas.GestorDeErrores;
namespace FrbaOfertas.CragaCredito
{
    public partial class CargaCredito : Form
    {
        private List<TextBox> camposObligatorios = new List<TextBox>();
        private Form menu;
        private Usuario us;
        public CargaCredito()
        {
            InitializeComponent();
        }
        public CargaCredito(Form ventana, Usuario user)//Si vengo del usuario
        {
            menu = ventana;
            InitializeComponent();
            us = user;
            iniciarTextBoxCliente();
            bloquearBoton(btnBuscar);
            inicializarCamposObligatorios();
        }

        public CargaCredito(Form ventana)//Si vengo del admin
        {
            menu = ventana;
            InitializeComponent();
            inicializarCamposObligatorios();
        }
        private void iniciarTextBoxCliente()
        {
            SqlCommand cmd = new SqlCommand("[RE_GDDIENTOS].buscar_cliente_segun_usuario");
            cmd.Parameters.Add("@user", SqlDbType.NVarChar, 255).Value = us.getNombreUsuario();
            cmd.Parameters.Add("@returned", SqlDbType.NVarChar, 18).Direction = ParameterDirection.ReturnValue;
            cmd.CommandType = CommandType.StoredProcedure;

            Conexion.Conexion.ejecutar(cmd);
            String dni = Convert.ToString(cmd.Parameters["@returned"].Value);
            txtCliente.Text = dni;
        }
        private void inicializarCamposObligatorios()
        {
            camposObligatorios.Add(txtCliente);
            camposObligatorios.Add(txtTarjetaTitular);
            camposObligatorios.Add(txtTarjeta_id);
            camposObligatorios.Add(txtMonto);
            fecha_vto.MinDate = Utilidades.Utilidades.fechaConfig;
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

        private void CargaCredito_Load(object sender, EventArgs e)
        {
            cmbTipoTarjeta.Items.Add("Debito");
            cmbTipoTarjeta.Items.Add("Credito");
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void CargaCredito_FormClosed(object sender, FormClosedEventArgs e)
        {
            menu.Show();
        }

        private void btnCargar_Click(object sender, EventArgs e)
        {
            try
            {
                if (cmbTipoTarjeta.SelectedItem != null)
                {
                    GestorDeErrores.GestorDeErrores.verificarCamposObligatoriosCompletos(camposObligatorios);
                    verificarCampos();

                    SqlCommand cmd = new SqlCommand("[RE_GDDIENTOS].cargar_credito");
                    cmd.CommandType = CommandType.StoredProcedure;
                    cargarCmd(cmd);
                    Conexion.Conexion.ejecutar(cmd);
                    MessageBox.Show("Carga realizada con éxito!", "Ok", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Hide();
                    menu.Show();
                }
                
            }
            catch (CamposObligatoriosIncompletosException error)
            {
                error.mensaje();
            }
            catch (FormatException error)
            {
                MessageBox.Show("Hay campos con el formato incorrecto: " + error.Message, "Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (SqlException error)
            {
                MessageBox.Show(error.Number + " :" + error.Message, "Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception error)
            { MessageBox.Show(" Error inesperado :" + error.Message, "Failed", MessageBoxButtons.OK, MessageBoxIcon.Error); }
            finally
            {
                Conexion.Conexion.getCon().Close();
            }
            

        }

        private void cargarCmd(SqlCommand cmd)
        {
            cmd.Parameters.Add("@dni", SqlDbType.NVarChar, 18).Value = txtCliente.Text;
            cmd.Parameters.Add("@monto", SqlDbType.Decimal).Value = Convert.ToDecimal(txtMonto.Text);
            cmd.Parameters.Add("@fecha_de_carga", SqlDbType.DateTime).Value = Utilidades.Utilidades.fechaConfig;
            cmd.Parameters.Add("@forma_pago", SqlDbType.NVarChar, 100).Value = cmbTipoTarjeta.SelectedItem.ToString();
            cmd.Parameters.Add("@tarj_num", SqlDbType.NVarChar, 18).Value = txtTarjeta_id.Text;
            cmd.Parameters.Add("@fecha_venc", SqlDbType.DateTime).Value = fecha_vto.Value;
            cmd.Parameters.Add("@titular", SqlDbType.NVarChar, 255).Value = txtTarjetaTitular.Text;
        }
        private void btnBuscar_Click(object sender, EventArgs e)
        {
            Form v = new ListadoCliente(txtCliente);
            v.Show();
        }
        private void verificarCampos()
        {
            GestorDeErrores.GestorDeErrores.verificarCampoNumerico(txtMonto);
            GestorDeErrores.GestorDeErrores.verificarCampoNumerico(txtTarjeta_id);
        }
        private void ControlChanged(object sender, EventArgs e)
        {
            Control ctrl = (Control)sender;
            ctrl.BackColor = Color.White;
        }

        private void txtCliente_TextChanged(object sender, EventArgs e)
        {

        }
        
    }
}
