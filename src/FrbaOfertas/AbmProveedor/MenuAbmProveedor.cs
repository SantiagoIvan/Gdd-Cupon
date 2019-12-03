using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FrbaOfertas.AbmProveedor
{
    public partial class MenuAbmProveedor : Form
    {
        private Form menu;
        public MenuAbmProveedor(Form ventana)
        {
            InitializeComponent();
            menu = ventana;
        }
        public MenuAbmProveedor()
        {
            InitializeComponent();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            Form v = new BajaProveedor(menu);
            v.Show();
            this.Hide();
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            Form v = new ModificarProveedor(menu);
            v.Show();
            this.Hide();
        }

        private void btnCargar_Click(object sender, EventArgs e)
        {
            Form v = new AltaProveedor(menu);
            v.Show();
            this.Hide();
        }

        private void MenuAbmProveedor_FormClosed(object sender, FormClosedEventArgs e)
        {
            menu.Show();
        }
    }
}
