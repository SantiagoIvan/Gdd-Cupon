using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FrbaOfertas.Entidades
{
    public class Cliente
    {
        public Cliente(String dni, String nom,String ap, DateTime fecha, String ciudad, String cp, String tel, String email, String dir, Int16 piso, Char dpto, Boolean habilitado,String usuario)
        {
            Dni = dni;
            Cliente_nombre = nom;
            Cliente_apellido = ap;
            Fecha_de_nacimiento = fecha;
            Ciudad = ciudad;
            Cp = cp;
            Telefono = tel;
            Email = email;
            Direccion = dir;
            Piso = piso;
            Dpto = dpto;
            Habilitado = habilitado;
            Nombre_usuario = usuario;
        }
        public String Dni;
        public String Cliente_nombre;
        public String Cliente_apellido;
        public DateTime Fecha_de_nacimiento;
        public String Ciudad;
        public String Cp;
        public String Telefono;
        public String Email;
        public String Direccion;
        public Int16 Piso;
        public Char Dpto;
        public Boolean Habilitado;
        public String Nombre_usuario;
 

    }
}
