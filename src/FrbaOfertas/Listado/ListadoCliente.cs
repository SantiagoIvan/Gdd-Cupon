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

namespace FrbaOfertas.Listado
{
    public partial class ListadoCliente : Form
    {
        private String queryBase = "Select * from [RE_GDDIENTOS].Clientes";
        private List<TextBox> filtrosDeTextoLibre = new List<TextBox>();
        private List<TextBox> filtrosDeTextoExacto = new List<TextBox>();

        private TextBox campoObjetivo;
        public ListadoCliente(TextBox txt)
        {
            InitializeComponent();
            campoObjetivo = txt;
            filtrosDeTextoExacto.Add(dni);
            filtrosDeTextoLibre.Add(cliente_apellido);
            filtrosDeTextoLibre.Add(cliente_nombre);
            filtrosDeTextoLibre.Add(email);
        }
        public ListadoCliente()
        {
            InitializeComponent();
            filtrosDeTextoExacto.Add(dni);
            filtrosDeTextoLibre.Add(cliente_apellido);
            filtrosDeTextoLibre.Add(cliente_nombre);
            filtrosDeTextoLibre.Add(email);
        }

        private void ListadoCliente_Load(object sender, EventArgs e)
        {
            DataSet ds = Conexion.Conexion.ejecutarConsulta(queryBase);
            dgClientes.DataSource = ds.Tables[0];
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            filtrosDeTextoLibre.Concat(filtrosDeTextoExacto).ToList().ForEach(box => box.Clear());
            DataSet ds = Conexion.Conexion.ejecutarConsulta(queryBase);
            dgClientes.DataSource = ds.Tables[0];
        }

        private void btnSeleccionar_Click(object sender, EventArgs e)
        {
            campoObjetivo.Text = dgClientes.SelectedRows[0].Cells[0].Value.ToString();
            this.Close();
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            if (filtrosDeTextoLibre.Concat(filtrosDeTextoExacto).Any(box => box.TextLength > 0))
            {
                String query = queryBase + " where ";
                query = query + Utilidades.Utilidades.condicionesFiltrosTextoExacto(filtrosDeTextoExacto);
                query = query + Utilidades.Utilidades.condicionesFiltrosTextoLibre(filtrosDeTextoLibre);
                query = query.Remove(query.Length - 5);

                DataSet ds = Conexion.Conexion.ejecutarConsulta(query);
                dgClientes.DataSource = ds.Tables[0];
            }
        }
    }
}
