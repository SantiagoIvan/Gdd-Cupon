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
using System.Collections;
using FrbaOfertas.Conexion;
using FrbaOfertas.Utilidades;
using FrbaOfertas.GestorDeErrores;
using FrbaOfertas.Entidades;

namespace FrbaOfertas.AbmCliente
{
    public partial class AltaCliente : AltaForm
    {
        protected Usuario us;
        private int rol_id = RepoRol.getInstance().buscarRol("cliente").Id;

        public AltaCliente(Usuario user,Form v)
        {
            InitializeComponent();
            inicializarCamposObligatorios();
            ventanaAnterior = v;
            us = user;
        }
        public AltaCliente()
        {
            InitializeComponent();
        }
        public AltaCliente(Form v)
        {
            InitializeComponent();
            inicializarCamposObligatorios();
            ventanaAnterior = v;
        }
        private void inicializarCamposObligatorios(){
            camposObligatorios.Add(txtApellido);
            camposObligatorios.Add(txtNombre);
            camposObligatorios.Add(txtDni);
            camposObligatorios.Add(txtTelefono);
            camposObligatorios.Add(txtEmail);
            camposObligatorios.Add(txtCiudad);
            camposObligatorios.Add(txtDireccion);
            camposObligatorios.Add(txtCp);
        }
        virtual protected void btnCrear_Click(object sender, EventArgs e)
        {
            try
            {
                GestorDeErrores.GestorDeErrores.verificarCamposObligatoriosCompletos(camposObligatorios);
                verificarCampos();
                GestorDeErrores.GestorDeErrores.verificarClientesDuplicados(txtDni.Text.ToString());

                SqlCommand cmd = new SqlCommand("[RE_GDDIENTOS].alta_cliente");
                cmd.CommandType = CommandType.StoredProcedure;
                cargarCmd(cmd);
                Conexion.Conexion.ejecutar(cmd);

                MessageBox.Show("Cliente guardado exitosamente!", "Saved", MessageBoxButtons.OK, MessageBoxIcon.Information);
                ventanaAnterior.Show();
                this.Hide();
            }
            catch (CamposObligatoriosIncompletosException error)
            {
                error.mensaje();
            }
            catch (ClienteDuplicadoException c)
            {
                c.mensaje();
            }
            catch (UsuarioConRolExistenteException c)
            {
                c.mensaje();
            }
            catch (FormatException error)
            {
                MessageBox.Show("Hay campos con el formato incorrecto: "+error.Message, "Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                Conexion.Conexion.getCon().Close();
            }

        }

        protected void AltaCliente_FormClosed(object sender, FormClosedEventArgs e)
        {
            ventanaAnterior.Show();
        }

        protected void btnLimpiar_Click(object sender, EventArgs e)
        {
            camposObligatorios.ForEach(box => box.Clear());
            txtPiso.Clear();
            txtDepto.Clear();
        }
        
        protected void cargarCmd(SqlCommand cmd)
        {
            cmd.Parameters.Add("@dni", SqlDbType.NVarChar, 18).Value = txtDni.Text;
            cmd.Parameters.Add("@nom", SqlDbType.NVarChar, 255).Value = txtNombre.Text;
            cmd.Parameters.Add("@ap", SqlDbType.NVarChar, 255).Value = txtApellido.Text;
            cmd.Parameters.Add("@fecha", SqlDbType.DateTime).Value = fechaNacimiento.Value;
            cmd.Parameters.Add("@ciudad", SqlDbType.NVarChar, 255).Value = txtCiudad.Text;
            cmd.Parameters.Add("@cp", SqlDbType.NVarChar, 20).Value = txtCp.Text;
            cmd.Parameters.Add("@tel", SqlDbType.NVarChar, 18).Value = txtTelefono.Text;
            cmd.Parameters.Add("@email", SqlDbType.NVarChar, 255).Value = txtEmail.Text;
            cmd.Parameters.Add("@direccion", SqlDbType.NVarChar, 255).Value = txtDireccion.Text;

            if (txtPiso.Text != "") { cmd.Parameters.Add("@piso", SqlDbType.SmallInt).Value = txtPiso.Text; }
            else { cmd.Parameters.Add("@piso", SqlDbType.SmallInt).Value = DBNull.Value; }

            if (txtDepto.Text != "") { cmd.Parameters.Add("@depto", SqlDbType.Char).Value = txtDepto.Text; }
            else { cmd.Parameters.Add("@depto", SqlDbType.Char).Value = DBNull.Value; }

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

        protected void btnAtras_Click_1(object sender, EventArgs e)
        {
            this.Close();
        }
        protected void verificarCampos()
        {

            GestorDeErrores.GestorDeErrores.verificarCampoNumerico(txtDni);
            GestorDeErrores.GestorDeErrores.verificarCampoNumerico(txtPiso);
            GestorDeErrores.GestorDeErrores.verificarCampoNumerico(txtTelefono);
            GestorDeErrores.GestorDeErrores.verificarCampoChar(txtDepto);
        }

        protected void ControlChanged(object sender, EventArgs e)
        {
            Control ctrl = (Control)sender;
            ctrl.BackColor=Color.White;
        }
    }
}
