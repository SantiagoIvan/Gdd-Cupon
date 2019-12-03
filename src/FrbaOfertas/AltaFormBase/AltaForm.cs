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

namespace FrbaOfertas
{
    public partial class AltaForm : Form
    {
        protected List<TextBox> camposObligatorios = new List<TextBox>();
        protected Form ventanaAnterior;

        public AltaForm()
        {
            InitializeComponent();
        }
        public AltaForm(Form v)
        {
            InitializeComponent();
            ventanaAnterior = v;
        }
        
        protected bool camposObligatoriosCompletados()
        {
            bool flag = true;
            if (camposObligatorios.Exists(campo => campo.Text == string.Empty))
            {
                flag = false;
                List<TextBox> camposSinLlenar = camposObligatorios.Where(campo => campo.Text == string.Empty).ToList();
                MessageBox.Show("Falta llenar campos: " + camposSinLlenar.Aggregate("", (s, next) => s + next.Name.TrimStart('t', 'x', 't') + " , ").TrimEnd(',', ' '), "Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            return flag;
        }

        protected void btnAtras_Click(object sender, EventArgs e)
        {
            this.Hide();
            this.ventanaAnterior.Show();
        }
    }
}
