using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FrbaOfertas.Conexion;
using FrbaOfertas.Utilidades;
using FrbaOfertas.GestorDeErrores;
using System.Data.SqlClient;
using System.Data;
namespace FrbaOfertas.Entidades
{
    public class Rol
    {
        public int Id { get; set; }
        public String Nombre { get; set; }
        public Boolean Habilitado { get; set; }
        public Rol() { }
        public Rol(String n)
        {
            Nombre = n;
        }
        public Rol(String name, int num)
        {
            Nombre = name;
            Id = num;
        }
        
        
    }
    public class RepoRol
    {
        private List<Rol> roles=new List<Rol>();
        public static RepoRol repo;
        public RepoRol()
        {
            DataSet ds = Conexion.Conexion.ejecutarConsulta("select rol_nombre,rol_id,habilitado from [RE_GDDIENTOS].roles");
            foreach (DataRow fila in ds.Tables[0].Rows)
            {
                Rol r = new Rol(fila["rol_nombre"].ToString(), Convert.ToInt16(fila["rol_id"]));
                r.Habilitado = Convert.ToBoolean(fila["habilitado"]);
                roles.Add(r);
            }

        }
        public static RepoRol getInstance()
        {
            if (repo == null)
            {
                repo = new RepoRol();
            }
            return repo;
        }
        public List<Rol> getRoles() { return roles; }
        public List<Rol> getRolesHabilitados() { return roles.Where(rol => rol.Habilitado).ToList(); }
        public Rol buscarRol(String nombre)
        {
            return roles.Find(rol => rol.Nombre == nombre);
        }

        public static List<Funcionalidad> obtenerFuncionalidadesDelRol(String nombre)
        {
            String cmd = String.Format("select funcionalidad_id,funcionalidad_nombre from [RE_GDDIENTOS].FuncionalidadesPorRolView where rol_nombre='{0}'", nombre.ToLower());
            DataSet ds = Conexion.Conexion.ejecutarConsulta(cmd);
            List<Funcionalidad> funcionalidades = new List<Funcionalidad>();

            foreach (DataRow fila in ds.Tables[0].Rows)
            {
                Funcionalidad f = new Funcionalidad(Convert.ToInt16(fila["funcionalidad_id"]),fila["funcionalidad_nombre"].ToString());
                funcionalidades.Add(f);
            }
            return funcionalidades;
        }
    }
}
