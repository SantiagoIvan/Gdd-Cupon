using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;
using FrbaOfertas.Registro_de_usuario;
using FrbaOfertas.AbmRol;
using FrbaOfertas.CrearOferta;
using FrbaOfertas.AbmCliente;
using FrbaOfertas.AbmProveedor;
using FrbaOfertas.Conexion;
using FrbaOfertas.Utilidades;
using FrbaOfertas.GestorDeErrores;
using FrbaOfertas.ComprarOferta;
using FrbaOfertas.ConsumoDeCupon;
using FrbaOfertas.ListadoEstadistico;
using FrbaOfertas.CragaCredito;
using FrbaOfertas.Facturar;
namespace FrbaOfertas.Entidades
{

    public class Funcionalidad
    {
        public int Id { get; set; }
        public String Nombre { get; set; }

        public Funcionalidad() { }
        public Funcionalidad(int n,String name) {
            Id = n;
            Nombre = name;
        }
        public  Form getForm(Form menu,Usuario usuario){
            if (usuario.getRol().Nombre == "administrador general")
            {
                switch (Nombre.ToLower())
                {
                    case "registrar usuario":
                        return new RegistrarUsuario(menu);
                    case "abm de cliente":
                        return new MenuAbmCliente(menu);
                    case "abm de proveedor":
                        return new MenuAbmProveedor(menu);
                    case "crear oferta":
                        return new AltaOferta(menu);
                    case "comprar oferta":
                        return new ComprarOferta.ComprarOferta(menu);
                    case "registrar consumo":
                        return new ConsumoDeCupon.ConsumoDeCupon(menu);
                    case "listar estadisticas":
                        return new Listado_Estadistico(menu);
                    case "realizar reporte de facturacion":
                        return new ReporteDeFacturacion(menu);
                    case "abm de rol":
                        return new MenuAbmRol(menu);
                    case "carga de credito":
                        return new CargaCredito(menu);
                    default:
                        throw new Exception("Funcionalidad sin menu");
                }
            }
            else
            {
                switch (Nombre.ToLower())
                {
                    case "registrar usuario":
                        return new RegistrarUsuario(menu);
                    case "abm de cliente":
                        return new MenuAbmCliente(menu);
                    case "abm de proveedor":
                        return new MenuAbmProveedor(menu);
                    case "crear oferta":
                        return new AltaOferta(menu,usuario);
                    case "comprar oferta":
                        return new ComprarOferta.ComprarOferta(menu,usuario);
                    case "registrar consumo":
                        return new ConsumoDeCupon.ConsumoDeCupon(menu,usuario);
                    case "listar estadisticas":
                        return new Listado_Estadistico(menu);
                    case "realizar reporte de facturacion":
                        return new ReporteDeFacturacion(menu);
                    case "abm de rol":
                        return new MenuAbmRol(menu);
                    case "carga de credito":
                        return new CargaCredito(menu,usuario);
                    default:
                        throw new Exception("Funcionalidad sin menu");
                }
            }
            
        }
        public static List<Funcionalidad> getFuncionalidades()
        {
            List<Funcionalidad> list = new List<Funcionalidad>();
            String query = "Select * from [RE_GDDIENTOS].Funcionalidades";
            DataSet ds = Conexion.Conexion.ejecutarConsulta(query);
            foreach (DataRow fila in ds.Tables[0].Rows)
            {
                Funcionalidad f = new Funcionalidad(Convert.ToInt16(fila["funcionalidad_id"]), fila["funcionalidad_nombre"].ToString());
                list.Add(f);
            }
            return list;
        }

         
    }
}
