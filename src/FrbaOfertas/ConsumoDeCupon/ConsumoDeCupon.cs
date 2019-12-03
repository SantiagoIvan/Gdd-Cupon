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
using FrbaOfertas.Entidades;
using System.Data.SqlClient;
using FrbaOfertas.GestorDeErrores;
using FrbaOfertas.Utilidades;
namespace FrbaOfertas.ConsumoDeCupon
{
    public partial class ConsumoDeCupon : Form
    {
        private Usuario usuario;
        private Form menuPrincipal;
        private List<TextBox> camposObligatorios = new List<TextBox>();
        public ConsumoDeCupon()
        {
            InitializeComponent();
        }
        public ConsumoDeCupon(Form menu)//vengo del admin
        {
            InitializeComponent();
            menuPrincipal = menu;
            cargarCamposObligatorios();
        }
        public ConsumoDeCupon(Form menu,Usuario us)//vengo de otro usuario
        {
            InitializeComponent();
            usuario = us;
            menuPrincipal = menu;
            cargartxtCuit();
            cargarCamposObligatorios();

            btnBuscadorCupones.Enabled = false;
            btnBuscadorProveedores.Enabled = false;
            btnBuscadorProveedores.BackColor = SystemColors.ControlDarkDark;
            btnBuscadorCupones.BackColor = SystemColors.ControlDarkDark;
        }
        private void cargarCamposObligatorios()
        {
            camposObligatorios.Add(txtCuit);
            camposObligatorios.Add(txtCuponId);
            camposObligatorios.Add(txtDni);
            dateFechaConsumo.Enabled = false;
            dateFechaConsumo.Value = Utilidades.Utilidades.fechaConfig;
        }
        private void cargartxtCuit()
        {
            if(usuario.getRol().Nombre.ToLower()=="proveedor")
            {
                String query = String.Format("select cuit from [RE_GDDIENTOS].proveedores where nombre_usuario='{0}'", usuario.getNombreUsuario());
                DataSet ds = Conexion.Conexion.ejecutarConsulta(query);
                txtCuit.Text = ds.Tables[0].Rows[0]["cuit"].ToString();
                txtCuit.Enabled = false;
                txtCuit.ReadOnly = true;
            }
            
        }
        private void btnBuscar_Click(object sender, EventArgs e)
        {
            Form v = new ListadoDeProveedores(txtCuit);
            v.Show();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Hide();
            menuPrincipal.Show();
        }

        private void verificarCampos()
        {
            GestorDeErrores.GestorDeErrores.verificarCampoNumerico(txtDni);
        }

        private void btnConfirmar_Click(object sender, EventArgs e)
        {
            try
            {
                GestorDeErrores.GestorDeErrores.verificarCamposObligatoriosCompletos(camposObligatorios);
                verificarCampos();

                SqlCommand cmd = new SqlCommand("[RE_GDDIENTOS].cargar_consumo_de_cupon");
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add("@cupon_id", SqlDbType.Int).Value = Convert.ToInt32(txtCuponId.Text);
                cmd.Parameters.Add("@dni", SqlDbType.NVarChar, 18).Value = txtDni.Text;
                cmd.Parameters.Add("@fecha_consumo", SqlDbType.DateTime).Value = dateFechaConsumo.Value;
                cmd.Parameters.Add("@cuit", SqlDbType.NVarChar, 20).Value = txtCuit.Text;

                Conexion.Conexion.ejecutar(cmd);
                MessageBox.Show("Cupon consumido con exito!", "Ok", MessageBoxButtons.OK, MessageBoxIcon.Information);

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
            finally
            {
                Conexion.Conexion.getCon().Close();
            }
        }

        private void txtDni_TextChanged(object sender, EventArgs e)
        {
            Control ctrl = (Control)sender;
            ctrl.BackColor = Color.White;
        }

        private void btnBuscadorCupones_Click(object sender, EventArgs e)
        {
            Form v = new ListadoDeCupones(txtCuponId);
            v.Show();
        }

        private void ConsumoDeCupon_FormClosed(object sender, FormClosedEventArgs e)
        {
            menuPrincipal.Show();
        }
    }
}
