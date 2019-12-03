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
using FrbaOfertas.Entidades;

namespace FrbaOfertas.ComprarOferta
{
    public partial class ConfirmarCompra : Form
    {
        private Form menuPrincipal;
        private Form ventanaAnterior;
        private Oferta oferta;
        private Usuario usuario;
        public ConfirmarCompra()
        {
            InitializeComponent();
        }
        public ConfirmarCompra(Usuario us,Oferta ofertaComprada, Form atras, Form menu)
        {
            InitializeComponent();
            menuPrincipal = menu;
            ventanaAnterior = atras;
            oferta = ofertaComprada;
            cargarCampos();
            usuario = us;
        }
        private void cargarCampos()
        {
            txtCuit.Text = oferta.Proveedor_Cuit;
            txtDescripcion.Text = oferta.Oferta_descripcion;
            txtId.Text = oferta.Oferta_id;
            txtPrecio.Text = oferta.Precio_oferta.ToString();
            String query = String.Format("select nombre_contacto from [RE_GDDIENTOS].proveedores where cuit='{0}'", oferta.Proveedor_Cuit);
            txtNombreProveedor.Text = Conexion.Conexion.ejecutarConsulta(query).Tables[0].Rows[0]["nombre_contacto"].ToString();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Hide();
            ventanaAnterior.Show();
        }

        private void btnConfirmar_Click(object sender, EventArgs e)
        {
            try
            {
                SqlCommand cmd = new SqlCommand("[RE_GDDIENTOS].comprar_oferta");
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.Add("@user_name", SqlDbType.NVarChar, 255).Value = usuario.getNombreUsuario();
                cmd.Parameters.Add("@oferta_id", SqlDbType.NVarChar, 50).Value = oferta.Oferta_id;
                cmd.Parameters.Add("@fecha_actual", SqlDbType.DateTime).Value = Utilidades.Utilidades.fechaConfig;

                Conexion.Conexion.ejecutar(cmd);
                MessageBox.Show("Compra realizada con éxito!", "Ok", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Hide();
                ventanaAnterior.Hide();
                menuPrincipal.Show();
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

        private void ConfirmarCompra_FormClosed(object sender, FormClosedEventArgs e)
        {
            ventanaAnterior.Show();
        }
    }
}
