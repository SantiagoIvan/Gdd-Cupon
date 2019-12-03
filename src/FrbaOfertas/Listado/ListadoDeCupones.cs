using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FrbaOfertas.GestorDeErrores;
using FrbaOfertas.Utilidades;

namespace FrbaOfertas.Listado
{
    public partial class ListadoDeCupones : Form
    {
        private TextBox target;
        private String queryBase = "Select * from [RE_GDDIENTOS].Cupones";
        private List<TextBox> filtrosDeTextoLibre = new List<TextBox>();
        private List<TextBox> filtrosDeTextoExacto = new List<TextBox>();

        public ListadoDeCupones()
        {
            InitializeComponent();
        }
        public ListadoDeCupones(TextBox txt)
        {
            InitializeComponent();
            target = txt;
            filtrosDeTextoExacto.Add(cupon_id);
            filtrosDeTextoExacto.Add(cliente_comprador_dni);
            filtrosDeTextoLibre.Add(oferta_id);
        }
        private void bloquearBoton(Button btn)
        {
            btn.Enabled = false;
            btn.BackColor = SystemColors.ControlDarkDark;
        }
        private void desbloquearBoton(Button btn)
        {
            btn.Enabled = true;
            btn.BackColor = SystemColors.Control;
        }
        private void ListadoDeCupones_Load(object sender, EventArgs e)
        {
            bloquearBoton(btnSeleccionar);
            bloquearBoton(btnBuscar);
        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            filtrosDeTextoLibre.Concat(filtrosDeTextoExacto).ToList().ForEach(box => box.Clear());
            dgCupones.DataSource = null;
            bloquearBoton(btnBuscar);
            bloquearBoton(btnSeleccionar);
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            String query = queryBase + " where ";
            query = query + Utilidades.Utilidades.condicionesFiltrosTextoExacto(filtrosDeTextoExacto);
            query = query + Utilidades.Utilidades.condicionesFiltrosTextoLibre(filtrosDeTextoLibre);
            query = query.Remove(query.Length - 5);

            DataSet ds = Conexion.Conexion.ejecutarConsulta(query);
            dgCupones.DataSource = ds.Tables[0];

            desbloquearBoton(btnSeleccionar);
        }

        private void ControlChanged(object sender, EventArgs e)
        {
            desbloquearBoton(btnBuscar);
        }

        private void btnSeleccionar_Click(object sender, EventArgs e)
        {
            if (dgCupones.SelectedRows != null)
            {
                target.Text=dgCupones.SelectedRows[0].Cells["cupon_id"].ToString();
                this.Close();
            }
        }

    }
}
