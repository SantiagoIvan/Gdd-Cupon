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
using FrbaOfertas.Conexion;
using FrbaOfertas.Utilidades;
using FrbaOfertas.GestorDeErrores;
namespace FrbaOfertas.AbmCliente
{
    public partial class ModificarPerfilCliente : AltaCliente
    {
        public ModificarPerfilCliente()
        {
            InitializeComponent();
        }
        public ModificarPerfilCliente(Cliente cliente,Form v)
        {
            us = new Usuario();
            InitializeComponent();
            ventanaAnterior = v;
            inicializarCamposObligatorios();
            cargarCampos(cliente);
            us.setNombreUsuario(cliente.Nombre_usuario);
        }
        private void inicializarCamposObligatorios()
        {
            camposObligatorios.Add(txtApellido);
            camposObligatorios.Add(txtCiudad);
            camposObligatorios.Add(txtCp);
            camposObligatorios.Add(txtDireccion);
            camposObligatorios.Add(txtDni);
            camposObligatorios.Add(txtEmail);
            camposObligatorios.Add(txtNombre);
            camposObligatorios.Add(txtTelefono);
        }
        private void cargarCampos(Cliente cliente)
        {
            txtNombre.Text = cliente.Cliente_nombre;
            txtApellido.Text = cliente.Cliente_apellido;
            txtDireccion.Text = cliente.Direccion;
            txtCp.Text = cliente.Cp;
            txtDni.Text = cliente.Dni;
            txtEmail.Text = cliente.Email;
            txtTelefono.Text = cliente.Telefono;
            txtCiudad.Text = cliente.Ciudad;
            txtPiso.Text = cliente.Piso.ToString();
            txtDepto.Text = cliente.Dpto.ToString();
        }

        protected override void btnCrear_Click(object sender, EventArgs e)
        {
        }

        private void btnActualizar_Click(object sender, EventArgs e)
        {
            try
            {
                GestorDeErrores.GestorDeErrores.verificarCamposObligatoriosCompletos(camposObligatorios);
                
                verificarCampos();
                
                SqlCommand cmd = new SqlCommand("update [RE_GDDIENTOS].Clientes set cliente_nombre=@nom,cliente_apellido=@ap, fecha_nacimiento=@fecha,ciudad=@ciudad,codigo_postal=@cp, telefono=@tel, email=@email,direccion=@direccion,piso=@piso,dpto=@depto where nombre_usuario=@user");
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
            finally
            {
                Conexion.Conexion.getCon().Close();
            }
        }
    }
}
