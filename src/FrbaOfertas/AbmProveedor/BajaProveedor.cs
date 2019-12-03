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

namespace FrbaOfertas.AbmProveedor
{
    public partial class BajaProveedor : Form
    {
        private Form menu;
        public BajaProveedor(Form v)
        {
            InitializeComponent();
            menu = v;
        }
        public BajaProveedor()
        {
            InitializeComponent();
        }
        private void desbloquearBoton(Button btn)
        {
            btn.Enabled = true;
            btn.BackColor = SystemColors.Control;
        }
        private void txtCuit_TextChanged(object sender, EventArgs e)
        {
            desbloquearBoton(btnDarBaja);
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            Form v = new ListadoDeProveedores(txtCuit);
            v.Show();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void BajaProveedor_FormClosed(object sender, FormClosedEventArgs e)
        {
            menu.Show();
        }

        private void btnDarBaja_Click(object sender, EventArgs e)
        {
            try
            {
                GestorDeErrores.GestorDeErrores.verificarProveedorHabilitado(txtCuit.Text);
                String query = String.Format("update [RE_GDDIENTOS].Proveedores set habilitado = 0 where cuit ='{0}'", txtCuit.Text);
                Conexion.Conexion.ejecutar(query);
                MessageBox.Show("Proveedor dado de baja con éxito!", "Ok", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Hide();
            }
            catch (GestorDeErrores.ClienteDeshabilitadoException error)
            {
                error.mensaje();
            }
        }
    }
}
