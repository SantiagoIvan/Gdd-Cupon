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
using System.Data.SqlClient;
using FrbaOfertas.Conexion;
using FrbaOfertas.Utilidades;
using FrbaOfertas.GestorDeErrores;

namespace FrbaOfertas.AbmCliente
{
    public partial class BajaCliente : Form
    {
        private Form menuPrincipal;
        public BajaCliente(Form vent)
        {
            InitializeComponent();
            menuPrincipal = vent;
        }

        private void BajaCliente_FormClosed(object sender, FormClosedEventArgs e)
        {
            menuPrincipal.Show();
            
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            Form v = new ListadoCliente(txtDni);
            v.Show();
        }

        private void txtUsuario_TextChanged(object sender, EventArgs e)
        {
            btnBaja.Enabled = true;
            btnBaja.BackColor = SystemColors.Control;
            txtDni.BackColor = Color.White;
        }

        private void btnBaja_Click(object sender, EventArgs e)
        {
            try
            {
                verificarCampos();
                GestorDeErrores.GestorDeErrores.verificarClienteHabilitado(txtDni.Text);
                String query = String.Format("update [RE_GDDIENTOS].Clientes set habilitado = 0 where dni ='{0}'", txtDni.Text);
                Conexion.Conexion.ejecutar(query);
                MessageBox.Show("Cliente dado de baja con éxito!", "Ok", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (GestorDeErrores.ClienteDeshabilitadoException error)
            {
                error.mensaje();
            }
            catch (FormatException error)
            {
                MessageBox.Show("Hay campos con el formato incorrecto: " + error.Message, "Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                Conexion.Conexion.getCon().Close();
            }


        }
        private void verificarCampos()
        {
            int num;
            if (!int.TryParse(txtDni.Text, out num))
            {
                Exception error = new FormatException("El DNI debe contener solamente numeros");
                txtDni.BackColor = Color.LightCoral;
                throw error;
            }
        }
        private void btnCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

    }
}
