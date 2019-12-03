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

namespace FrbaOfertas.ListadoEstadistico
{
    public partial class Listado_Estadistico : Form
    {
        private Form menuPrincipal;
        public Listado_Estadistico()
        {
            InitializeComponent();
            inicializarCmb();
        }
        public Listado_Estadistico(Form v)
        {
            InitializeComponent();
            inicializarCmb();
            menuPrincipal = v;
        }
        private void inicializarCmb()
        {
            cmbSemestre.Items.Add("Primer semestre");
            cmbSemestre.Items.Add("Segundo semestre");
            cmbTipoListado.Items.Add("proveedores_con_mayor_facturacion");
            cmbTipoListado.Items.Add("proveedores_con_mayor_descuento_ofrecido");
        }
        
        private void Listado_Estadistico_Load(object sender, EventArgs e)
        {
            inicializarCmb();
        }

        private void btnConsultar_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtYear.Text == null)
                {
                    MessageBox.Show("Falta ingresar el año" , "Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                else
                {
                    String proc = "[RE_GDDIENTOS]."+cmbTipoListado.SelectedItem.ToString();
                    SqlCommand cmd = new SqlCommand(proc);
                    cmd.CommandType = CommandType.StoredProcedure;
                    cmd.Parameters.Add("@year", SqlDbType.Int).Value = Convert.ToInt32(txtYear.Text);
                    cmd.Parameters.Add("@semestre", SqlDbType.NVarChar, 20).Value = cmbSemestre.Text;

                    DataSet ds = Conexion.Conexion.ejecutarConsulta(cmd);

                    dgListado.DataSource = ds.Tables[0];
                }
                
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

        private void Listado_Estadistico_FormClosed(object sender, FormClosedEventArgs e)
        {
            menuPrincipal.Show();
        }
    }
}
