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
using FrbaOfertas.Entidades;
using System.Data.SqlClient;

namespace FrbaOfertas.AbmRol
{
    public partial class AltaRol : AltaForm
    {
        private Form origen;
        List<Funcionalidad> funcionalidadesDisponibles = new List<Funcionalidad>();

        public AltaRol()
        {
            InitializeComponent();
            inicializarCamposObligatorios();
            inicializarDataGridView();

        }
        public AltaRol(Form menu)
        {
            InitializeComponent();
            inicializarCamposObligatorios();
            inicializarDataGridView();
            origen = menu;
        }

        private void inicializarCamposObligatorios()
        {
            camposObligatorios.Add(txtRolNombre);
        }
        private void inicializarDataGridView()
        {
            funcionalidadesDisponibles = Funcionalidad.getFuncionalidades();
            dgFuncionalidadesDisponibles.DataSource = funcionalidadesDisponibles;
            dgFuncionalidadesDisponibles.AutoGenerateColumns = true;
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Hide();
            origen.Show();
        }

        private void btnCrear_Click(object sender, EventArgs e)
        {


            try
            {
                GestorDeErrores.GestorDeErrores.verificarCamposObligatoriosCompletos(camposObligatorios);
                GestorDeErrores.GestorDeErrores.verificarRolExistente(txtRolNombre.Text.ToLower());

                SqlCommand cmd = new SqlCommand();

                String query = String.Format("insert into [RE_GDDIENTOS].roles (rol_nombre) values ('{0}');", txtRolNombre.Text.ToLower());
                cmd.CommandText = query;
                Conexion.Conexion.ejecutar(cmd);

                query = String.Format("select rol_id from [RE_GDDIENTOS].roles where rol_nombre = '{0}'", txtRolNombre.Text.ToLower());
                cmd.CommandText = query;
                DataSet ds = Conexion.Conexion.ejecutarConsulta(cmd);
                Int16 rol_id = Convert.ToInt16(ds.Tables[0].Rows[0]["rol_id"]);

                foreach (DataGridViewRow fila in dgFuncionalidadesDisponibles.SelectedRows)
                {
                    Int16 f_id = Convert.ToInt16(fila.Cells[0].Value);
                    query = String.Format("insert into [RE_GDDIENTOS].FuncionalidadPorRol (rol_id,funcionalidad_id) values ({0},{1});", rol_id, f_id);
                    cmd.CommandText = query;
                    Conexion.Conexion.ejecutar(cmd);
                }

                MessageBox.Show("Rol creado con éxito!", "Ok", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (CamposObligatoriosIncompletosException error)
            {
                error.mensaje();
            }
            catch (RolExistenteException error)
            {
                error.mensaje();
            }
            catch (FormatException error)
            {
                MessageBox.Show(error.Message, "Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (Exception error)
            {
                MessageBox.Show("Error inesperado, ups!" + error.Message.ToString(), "Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                Conexion.Conexion.getCon().Close();
            }

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
    }
}
