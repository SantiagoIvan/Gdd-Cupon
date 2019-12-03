using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FrbaOfertas.Entidades
{
    public class Proveedor
    {

        public Proveedor(String rs, String cuit,String contacto, String ciudad, String cp, String tel, String email, String dir, Int16 piso, Char dpto, Boolean habilitado, String usuario)
        {
            Rs = rs;
            Cuit = cuit;
            Ciudad = ciudad;
            Cp = cp;
            Telefono = tel;
            Email = email;
            Direccion = dir;
            Piso = piso;
            Dpto = dpto;
            Habilitado = habilitado;
            Nombre_usuario = usuario;
            Contacto = contacto;
        }
        public String Rs;
        public String Cuit;
        public String Ciudad;
        public String Cp;
        public String Telefono;
        public String Email;
        public String Direccion;
        public Int16 Piso;
        public Char Dpto;
        public Boolean Habilitado;
        public String Nombre_usuario;
        public String Contacto;
    }
}
