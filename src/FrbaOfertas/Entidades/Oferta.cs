using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FrbaOfertas.Entidades
{
    public class Oferta
    {
        public String Oferta_id;
        public DateTime Fecha_publicacion;
        public DateTime Fecha_vto;
        public Decimal Precio_oferta;
        public Decimal Precio_viejo;
        public String Proveedor_Cuit;
        public Int16 Stock;
        public String Oferta_descripcion;
        public Int16 Limite_de_compra;

        public Oferta(String of,DateTime fecha_pub,DateTime fecha_vto,Decimal precio_of,Decimal precio_viejo,String cuit, Int16 stock, String descripcion, Int16 limite)
        {
            Oferta_id = of;
            Fecha_publicacion = fecha_pub;
            Fecha_vto = fecha_vto;
            Precio_oferta = precio_of;
            Precio_viejo = precio_viejo;
            Proveedor_Cuit = cuit;
            Stock = stock;
            Oferta_descripcion = descripcion;
            Limite_de_compra = limite;
        }

    }
}
