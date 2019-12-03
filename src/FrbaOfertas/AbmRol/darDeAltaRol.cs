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

namespace FrbaOfertas.AbmRol
{
    public partial class darDeAltaRol : Form
    {
        ClaseConexion bd = new ClaseConexion();
        SqlDataAdapter adapt;
        DataTable dt;
        
        public darDeAltaRol()
        {
            InitializeComponent();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void comboBoxRoles_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        /*private void btnModificar_Click(object sender, EventArgs e)
        {
            ModificarRol ventana = new ModificarRol(comboBoxRoles.Text.ToString());
            ventana.show();
            this.Hide();
        }*/

        private void darDeAltaRol_Load(object sender, EventArgs e)
        {
            bd.Conectar();
            adapt = new SqlDataAdapter("select id_rol from [LEISTE_EL_CODIGO?].Rol", bd.obtenerConexion());
            dt = new DataTable();
            adapt.Fill(dt);
            comboBoxRoles.DataSource = dt;
            comboBoxRoles.ValueMember = "id_rol";
            bd.Desconectar();
        }
    }
}
