using FrbaOfertas.AbmCliente;
using FrbaOfertas.AbmProveedor;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using FrbaOfertas.LoginYSeguridad;
using FrbaOfertas.MenuPrincipal;
using FrbaOfertas.Listado;
using FrbaOfertas.AbmRol;
using FrbaOfertas.CragaCredito;
using FrbaOfertas.Entidades;
using FrbaOfertas.CrearOferta;
using FrbaOfertas.ComprarOferta;
using FrbaOfertas.ConsumoDeCupon;
using FrbaOfertas.Facturar;
using FrbaOfertas.ListadoEstadistico;

namespace FrbaOfertas
{
    static class Program
    {
        /// <summary>
        /// Punto de entrada principal para la aplicación.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Login());
        }
    }
}
