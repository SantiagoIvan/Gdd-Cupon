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
using FrbaOfertas.Listado;
using FrbaOfertas.Utilidades;
using FrbaOfertas.GestorDeErrores;
using System.Data.SqlClient;

namespace FrbaOfertas.Facturar
{
    public partial class ReporteDeFacturacion : Form
    {
        private Form menuPrincipal;
        private List<TextBox> camposObligatorios = new List<TextBox>();
        public ReporteDeFacturacion()
        {
            InitializeComponent();
        }
        public ReporteDeFacturacion(Form v)
        {
            InitializeComponent();
            camposObligatorios.Add(txtCuit);
            menuPrincipal = v;
        }
        
        private void ReporteDeFacturacion_FormClosed(object sender, FormClosedEventArgs e)
        {
            menuPrincipal.Show();
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            Form listado = new ListadoDeProveedores(txtCuit);
            listado.Show();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            this.Hide();
            menuPrincipal.Show();
        }
        
        private void btnFacturar_Click(object sender, EventArgs e)
        {
            try
            {
                GestorDeErrores.GestorDeErrores.verificarCamposObligatoriosCompletos(camposObligatorios);
                if (dateFechaMinima.Value > dateFechaMaxima.Value)
                {
                    MessageBox.Show("Fechas mal ingresadas", "Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    SqlCommand cmd = new SqlCommand("[RE_GDDIENTOS].ofertas_vendidas_en_intervalo");
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.Add("@cuit", SqlDbType.NVarChar, 20).Value = txtCuit.Text;
                    cmd.Parameters.Add("@fecha_minima", SqlDbType.DateTime).Value = dateFechaMinima.Value;
                    cmd.Parameters.Add("@fecha_maxima", SqlDbType.DateTime).Value = dateFechaMaxima.Value;

                    DataSet ds = Conexion.Conexion.ejecutarConsulta(cmd);
                    dgOfertasAFacturar.DataSource = ds.Tables[0];
                    Decimal importeTotal = new Decimal();
                    foreach (DataRow fila in ds.Tables[0].Rows)
                    {
                        importeTotal += Convert.ToDecimal(fila["precio_oferta"]);
                    }

                    SqlCommand cmd2 = new SqlCommand("[RE_GDDIENTOS].realizar_facturacion");
                    cmd2.CommandType = CommandType.StoredProcedure;
                    cmd2.Parameters.Add("@cuit", SqlDbType.NVarChar, 20).Value = txtCuit.Text;
                    cmd2.Parameters.Add("@fecha_minima", SqlDbType.DateTime).Value = dateFechaMinima.Value;
                    cmd2.Parameters.Add("@fecha_maxima", SqlDbType.DateTime).Value = dateFechaMaxima.Value;

                    Conexion.Conexion.ejecutar(cmd2);
                    txtImporte.Text = importeTotal.ToString();
                    MessageBox.Show("Facturacion realizada con éxito!", "Ok", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    btnFacturar.Enabled = false;
                    btnFacturar.BackColor = Color.Red;
                }
            }
            catch (CamposObligatoriosIncompletosException error)
            {
                error.mensaje();
            }
            catch (SqlException error)
            {
                MessageBox.Show(error.Number.ToString()+" :"+error.Message, "Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (FormatException error)
            {
                MessageBox.Show(error.Message, "Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                Conexion.Conexion.getCon().Close();
            }
        }
    }
}
