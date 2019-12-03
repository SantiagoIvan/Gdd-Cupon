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
using FrbaOfertas.Conexion;
using FrbaOfertas.Utilidades;
using FrbaOfertas.GestorDeErrores;
using System.Data.SqlClient;
using FrbaOfertas.Entidades;
namespace FrbaOfertas.CrearOferta
{
    public partial class AltaOferta : AltaForm
    {
        private Usuario usuario;
        public AltaOferta(Form vent)//si vengo del Admin
        {
            InitializeComponent();
            ventanaAnterior = vent;
            inicializarCamposObligatorios();
            calendarioPublicacion.MinDate = Utilidades.Utilidades.fechaConfig;
            calendarioVencimiento.MinDate = Utilidades.Utilidades.fechaConfig;
        }
        public AltaOferta(Form vent,Usuario us)//si vengo del Proveedor
        {
            InitializeComponent();
            ventanaAnterior = vent;
            usuario = us;
            cargarCuit();
            inicializarCamposObligatorios();
            btnBuscar.BackColor = Color.DarkGray;
            btnBuscar.Enabled = false;
            calendarioPublicacion.MinDate = Utilidades.Utilidades.fechaConfig;
            calendarioVencimiento.MinDate = Utilidades.Utilidades.fechaConfig;
        }
        private void cargarCuit()
        {
            if (usuario.getRol().Nombre.ToLower() == "proveedor")
            {
                String query = String.Format("select cuit from [RE_GDDIENTOS].proveedores where nombre_usuario='{0}'", usuario.getNombreUsuario());
                SqlCommand cmd = new SqlCommand(query);
                DataSet ds = Conexion.Conexion.ejecutarConsulta(cmd);
                txtCuit.Text = ds.Tables[0].Rows[0]["cuit"].ToString();
            }
            else
            {
                btnBuscar.BackColor = SystemColors.Control;
                btnBuscar.Enabled = true;
            }
        }
        private void inicializarCamposObligatorios()
        {
            camposObligatorios.Add(txtCuit);
            camposObligatorios.Add(txtDescripcion);
            camposObligatorios.Add(txtLimiteCompra);
            camposObligatorios.Add(txtPrecioAntiguo);
            camposObligatorios.Add(txtPrecioNuevo);
            camposObligatorios.Add(txtStock);
        }
        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void verificarCampos()
        {
            GestorDeErrores.GestorDeErrores.verificarCampoNumerico(txtStock);
            GestorDeErrores.GestorDeErrores.verificarCampoNumerico(txtPrecioNuevo);
            GestorDeErrores.GestorDeErrores.verificarCampoNumerico(txtPrecioAntiguo);
            GestorDeErrores.GestorDeErrores.verificarCampoNumerico(txtLimiteCompra);
        }
        private void btnPublicar_Click(object sender, EventArgs e)
        {
            try
            {
                GestorDeErrores.GestorDeErrores.verificarCamposObligatoriosCompletos(camposObligatorios);
                verificarCampos();

                SqlCommand cmd = new SqlCommand("[RE_GDDIENTOS].publicar_oferta");
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add("@stock", SqlDbType.SmallInt).Value = txtStock.Text;
                cmd.Parameters.Add("@limite_de_compra", SqlDbType.SmallInt).Value = txtLimiteCompra.Text;
                cmd.Parameters.Add("@precio_viejo", SqlDbType.Decimal).Value = Convert.ToDecimal(txtPrecioAntiguo.Text);
                cmd.Parameters.Add("@precio_nuevo", SqlDbType.Decimal).Value = Convert.ToDecimal(txtPrecioNuevo.Text);
                cmd.Parameters.Add("@cuit", SqlDbType.NVarChar, 20).Value = txtCuit.Text;
                cmd.Parameters.Add("@descr", SqlDbType.NVarChar, 255).Value = txtDescripcion.Text;
                cmd.Parameters.Add("@fecha_pub", SqlDbType.DateTime).Value = calendarioPublicacion.Value;
                cmd.Parameters.Add("@fecha_venc", SqlDbType.DateTime).Value = calendarioVencimiento.Value;

                Conexion.Conexion.ejecutar(cmd);
                MessageBox.Show("Oferta creada exitósamente!", "Ok", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }
            catch (SqlException error)
            {
                MessageBox.Show(error.Number + " :" + error.Message, "Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (CamposObligatoriosIncompletosException error)
            { error.mensaje(); }
            catch (FormatException error)
            { MessageBox.Show("Se ingresaron mal los datos de los campos." + error.Message, "Failed", MessageBoxButtons.OK, MessageBoxIcon.Error); }
            finally { Conexion.Conexion.getCon().Close(); }


        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            Form ventana = new ListadoDeProveedores(txtCuit);
            ventana.Show();
        }

        private void AltaOferta_FormClosed(object sender, FormClosedEventArgs e)
        {
            ventanaAnterior.Show();
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            txtCuit.Clear();
            txtDescripcion.Clear();
            txtLimiteCompra.Clear();
            txtPrecioAntiguo.Clear();
            txtPrecioNuevo.Clear();
            txtStock.Clear();
        }

        private void ControlChanged(object sender, EventArgs e)
        {
            Control ctrl = (Control)sender;
            ctrl.BackColor = Color.White;
        }
    }
}
