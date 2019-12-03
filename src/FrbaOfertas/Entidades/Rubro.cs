using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FrbaOfertas.Entidades
{
    public class Rubro
    {
        public String Nombre { get; set; }
        public int Id { get; set; }
        public Rubro(String name, int id)
        {
            Nombre = name;
            Id = id;
        }

    }
}
