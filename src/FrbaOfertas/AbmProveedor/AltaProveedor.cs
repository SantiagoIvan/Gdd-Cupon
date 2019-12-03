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
using FrbaOfertas.Utilidades;
using FrbaOfertas.GestorDeErrores;
using FrbaOfertas.Entidades;

namespace FrbaOfertas.AbmProveedor
{
    public partial class AltaProveedor : AltaForm
    {
        private Usuario us;
        private int rol_id = RepoRol.getInstance().buscarRol("proveedor").Id;

        public  AltaProveedor(Usuario user,Form v)
        {
            InitializeComponent();
            inicializarCamposObligatorios();
            ventanaAnterior = v;
            us = user;
        }
        public AltaProveedor()
        {
            InitializeComponent();
        }
        public AltaProveedor(Form v)
        {
            InitializeComponent();
            inicializarCamposObligatorios();
            ventanaAnterior = v;
        }
        public AltaProveedor(Form v,Proveedor p)
        {
            InitializeComponent();
            inicializarCamposObligatorios();
            ventanaAnterior = v;
            us.setNombreUsuario(p.Nombre_usuario);
        }
        
        private  void inicializarCamposObligatorios()
        {
            camposObligatorios.Add(txtRs);
            camposObligatorios.Add(txtCuit);
            camposObligatorios.Add(txtEmail);
            camposObligatorios.Add(txtTelefono);
            camposObligatorios.Add(txtCiudad);
            camposObligatorios.Add(txtDireccion);
            camposObligatorios.Add(txtCp);
            camposObligatorios.Add(txtContacto);

            SqlCommand cmd = new SqlCommand("select * from [RE_GDDIENTOS].rubros");
            DataSet ds = Conexion.Conexion.ejecutarConsulta(cmd);
            List<Rubro> rubros = new List<Rubro>();
            foreach (DataRow fila in ds.Tables[0].Rows)
            {
                Rubro r = new Rubro(fila["rubro_nombre"].ToString(), Convert.ToInt32(fila["rubro_id"]));
                rubros.Add(r);
            }
            cmbRubros.DataSource = rubros;
            cmbRubros.DisplayMember = "Nombre";
            
        }

        protected void btnCrear_Click(object sender, EventArgs e)
        {
            try
            {
                if (cmbRubros.SelectedItem != null)
                {
                    GestorDeErrores.GestorDeErrores.verificarCamposObligatoriosCompletos(camposObligatorios);
                    verificarCampos();
                    GestorDeErrores.GestorDeErrores.verificarProveedoresDuplicados(txtCuit.Text);

                    SqlCommand cmd = new SqlCommand("[RE_GDDIENTOS].alta_proveedor");
                    cmd.CommandType = CommandType.StoredProcedure;
                    cargarCmd(cmd);
                    Conexion.Conexion.ejecutar(cmd);

                    MessageBox.Show("Proveedor guardado exitosamente!", "Saved", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.Hide();
                    ventanaAnterior.Show();
                }
                
            }
            catch (CamposObligatoriosIncompletosException error)
            {
                error.mensaje();
            }
            catch (SqlException error)
            {
                MessageBox.Show(error.Number + " :" + error.Message, "Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            catch (FormatException error)
            {
                MessageBox.Show("Hay campos con el formato incorrecto: " + error.Message, "Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally { Conexion.Conexion.getCon().Close(); }
            
        }
        protected void verificarCampos()
        {
            GestorDeErrores.GestorDeErrores.verificarCampoNumerico(txtPiso);
            GestorDeErrores.GestorDeErrores.verificarCampoNumerico(txtTelefono);
            GestorDeErrores.GestorDeErrores.verificarCampoChar(txtDepto);
        }
        protected void btnLimpiar_Click(object sender, EventArgs e)
        {
            camposObligatorios.ForEach(box => box.Clear());
            txtPiso.Clear();
            txtDepto.Clear();
        }
        protected void cargarCmd(SqlCommand cmd)
        {
            Rubro r = cmbRubros.SelectedItem as Rubro;
            cmd.Parameters.Add("@rs", SqlDbType.NVarChar,100).Value=txtRs.Text;
            cmd.Parameters.Add("@email", SqlDbType.NVarChar, 255).Value = txtEmail.Text;
            cmd.Parameters.Add("@telefono", SqlDbType.NVarChar, 18).Value = txtTelefono.Text;
            cmd.Parameters.Add("@ciudad", SqlDbType.NVarChar, 255).Value = txtCiudad.Text;
            cmd.Parameters.Add("@codigo_postal", SqlDbType.NVarChar, 20).Value = txtCp.Text;
            cmd.Parameters.Add("@cuit", SqlDbType.NVarChar, 20).Value = txtCuit.Text;
            cmd.Parameters.Add("@rubro_id", SqlDbType.SmallInt).Value=Convert.ToInt16(r.Id);
            cmd.Parameters.Add("@contacto", SqlDbType.NVarChar, 255).Value = txtContacto.Text; ;
            cmd.Parameters.Add("@direccion", SqlDbType.NVarChar,255).Value=txtDireccion.Text;
            if (txtPiso.Text != "") { cmd.Parameters.Add("@piso", SqlDbType.SmallInt).Value = txtPiso.Text; } else { cmd.Parameters.Add("@piso", SqlDbType.SmallInt).Value = DBNull.Value; }
            if (txtDepto.Text != "") { cmd.Parameters.Add("@depto", SqlDbType.Char).Value = txtDepto.Text; } else { cmd.Parameters.Add("@depto", SqlDbType.Char).Value = DBNull.Value; }
            if (us != null)
            {
                cmd.Parameters.Add("@user", SqlDbType.NVarChar, 255).Value = us.getNombreUsuario();
                String hash = Utilidades.Utilidades.obtenerHash(us.getPass());
                cmd.Parameters.Add("@pass", SqlDbType.NVarChar, 255).Value = hash;
                cmd.Parameters.Add("@rol_id", SqlDbType.SmallInt).Value = Convert.ToInt16(rol_id);
            }
            else
            {
                cmd.Parameters.Add("@user", SqlDbType.NVarChar, 255).Value = DBNull.Value;
                cmd.Parameters.Add("@pass", SqlDbType.NVarChar, 255).Value = DBNull.Value;
                cmd.Parameters.Add("@rol_id", SqlDbType.SmallInt).Value = DBNull.Value;
            }
        }

        private void ControlChanged(object sender, EventArgs e)
        {
            Control ctrl = (Control)sender;
            ctrl.BackColor = Color.White;
        }
    }

}

