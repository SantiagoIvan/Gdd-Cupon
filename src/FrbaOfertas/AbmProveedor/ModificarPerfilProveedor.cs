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
using System.Data.SqlClient;
using FrbaOfertas.Utilidades;
using FrbaOfertas.GestorDeErrores;
namespace FrbaOfertas.AbmProveedor
{
    public partial class ModificarPerfilProveedor : AltaProveedor
    {
        Usuario us = new Usuario();
        public ModificarPerfilProveedor()
        {
            InitializeComponent();
        }
        public ModificarPerfilProveedor(Proveedor proveedor,Form v)
        {
            InitializeComponent();
            ventanaAnterior = v;
            inicializarCamposObligatorios();
            cargarCampos(proveedor);
            us.setNombreUsuario(proveedor.Nombre_usuario);
        }
        private void inicializarCamposObligatorios()
        {
            camposObligatorios.Add(txtCiudad);
            camposObligatorios.Add(txtContacto);
            camposObligatorios.Add(txtCp);
            camposObligatorios.Add(txtCuit);
            camposObligatorios.Add(txtDireccion);
            camposObligatorios.Add(txtEmail);
            camposObligatorios.Add(txtRs);
            camposObligatorios.Add(txtTelefono);

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
        private void cargarCampos(Proveedor proveedor)
        {
            txtRs.Text = proveedor.Rs;
            txtCuit.Text = proveedor.Cuit;
            txtDireccion.Text = proveedor.Direccion;
            txtCp.Text = proveedor.Cp;
            txtEmail.Text = proveedor.Email;
            txtTelefono.Text = proveedor.Telefono;
            txtCiudad.Text = proveedor.Ciudad;
            txtPiso.Text = proveedor.Piso.ToString();
            txtDepto.Text = proveedor.Dpto.ToString();
            txtContacto.Text = proveedor.Contacto;
        }

        private new void btnCrear_Click(object sender, EventArgs e)
        {
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            try
            {
                GestorDeErrores.GestorDeErrores.verificarCamposObligatoriosCompletos(camposObligatorios);
                verificarCampos();

                SqlCommand cmd = new SqlCommand("update [RE_GDDIENTOS].Clientes set dni=@dni,cliente_nombre=@nom,cliente_apellido=@ap, fecha_nacimiento=@fecha,ciudad=@ciudad,codigo_postal=@cp, telefono=@tel, email=@email,direccion=@direccion,piso=@piso,dpto=@depto where nombre_usuario=@user");
                cmd.CommandType = CommandType.Text;
                cargarCmd(cmd);
                Conexion.Conexion.ejecutar(cmd);

                MessageBox.Show("Cliente actualizado con éxito!", "Ok", MessageBoxButtons.OK, MessageBoxIcon.Information);
                ventanaAnterior.Show();
                this.Hide();
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
            catch (Exception error)
            {
                MessageBox.Show("Hay campos con el formato incorrecto: " + error.Message, "Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                Conexion.Conexion.getCon().Close();
            }
        }
    }
}
