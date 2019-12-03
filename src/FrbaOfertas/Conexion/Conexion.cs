using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using FrbaOfertas.GestorDeErrores;
using System.Windows.Forms;
namespace FrbaOfertas.Conexion
{
    public class Conexion
    {
        private static string configuracionConexionSQL = @"Data Source=localhost\SQLSERVER2012;Integrated Security=False;User ID=gdCupon2019;Password=gd2019;Connect Timeout=15;Encrypt=False;TrustServerCertificate=False";

        private static SqlConnection con = new SqlConnection(configuracionConexionSQL);
        private static int cantidadDeIntentos = 3;

        public static int getCantidadDeIntentos() { return cantidadDeIntentos; }
        public static SqlConnection getCon() { return con; }

        public static DataSet ejecutarConsulta(String query)
        {
            con.Open();

            DataSet ds = new DataSet();
            SqlDataAdapter adapter = new SqlDataAdapter(query, con);

            adapter.Fill(ds);
            con.Close();
            return ds;
        }
        public static DataSet ejecutarConsulta(SqlCommand query)
        {
            query.Connection = getCon();
            con.Open();
            DataSet ds = new DataSet();
            SqlDataAdapter adapter = new SqlDataAdapter(query);

            adapter.Fill(ds);
            con.Close();
            return ds;
        }

        public static void ejecutar(String query)
        {
            SqlCommand cmd = new SqlCommand(query, con);
            con.Open();
            cmd.ExecuteNonQuery();
            con.Close();
        }
        public static void ejecutar(SqlCommand cmd)
        {
            cmd.Connection = getCon();
            con.Open();
            cmd.ExecuteNonQuery();
            con.Close();
        }
        public static SqlTransaction beginTransaction()
        {
            con.Open();
            SqlTransaction trans = con.BeginTransaction();
            con.Close();
            return trans;
        }
        public static void commit(SqlTransaction trans)
        {
            con.Open();
            trans.Commit();
            con.Close();
        }
        public static void rollback(SqlTransaction trans)
        {
            trans.Rollback();
            con.Close();
        }

        public static int ejecutarProcedure(SqlCommand cmd)
        {
            cmd.Connection = getCon();
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.Add("@returned", SqlDbType.SmallInt).Direction = ParameterDirection.ReturnValue;

            con.Open();
            cmd.ExecuteNonQuery();
            int i = (int)cmd.Parameters["@returned"].Value;
            con.Close();
            return i;
        }
    }
}
