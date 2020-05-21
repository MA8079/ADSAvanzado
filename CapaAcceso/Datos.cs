using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using System.Windows.Forms;
using System.Configuration;

namespace SAServicios_TSMV.CapaAcceso
{
     class Datos
    {
        
        private SqlConnection Conexion;
        public Datos()
        {
            Conexion = new SqlConnection(@"Data Source=LAPTOP-NKDVUSVE\SQLEXPRESS; Initial Catalog=SAServicios_TSMV;Integrated Security=true");

        }
        public void EjecutarRegistro(String query,List<SqlParameter> parametros) 
        {
            SqlCommand Comando = new SqlCommand(query,Conexion);
            Comando.CommandType = CommandType.Text;
            for (int i = 0; i < parametros.Count; i++)
            {
                Comando.Parameters.Add(parametros[i]);
            }
            Conexion.Open();
            Comando.ExecuteNonQuery();
            Conexion.Close();
        }
        public DataTable EjecutarVista(String query)
        {
            SqlCommand Consulta = new SqlCommand(query,Conexion);
            Consulta.CommandType = CommandType.Text;
            SqlDataAdapter Adaptador = new SqlDataAdapter(Consulta);
            DataTable Tabla = new DataTable();
            Adaptador.Fill(Tabla);
            return Tabla;
        }
        public void EliminarRegistro(String query, List<SqlParameter> parametros)
        {
            SqlCommand Comando = new SqlCommand(query, Conexion);
            Comando.CommandType = CommandType.Text;
            for (int i = 0; i < parametros.Count; i++)
            {
                Comando.Parameters.Add(parametros[i]);
            }
            Conexion.Open();
            Comando.ExecuteNonQuery();
            Conexion.Close();
        }
        public void ModificarRegistro(String query,List<SqlParameter>parametros)
        {
            SqlCommand Comando = new SqlCommand(query,Conexion);
            Comando.CommandType = CommandType.Text;
            for (int i = 0; i < parametros.Count; i++)
            {
                Comando.Parameters.Add(parametros[i]);
            }
            Conexion.Open();
            Comando.ExecuteNonQuery();
            Conexion.Close();
        }
        public DataTable EjecutarLectura(String query)
        {
            Conexion.Open();
            SqlCommand Comando = new SqlCommand(query,Conexion);
            Comando.CommandType = CommandType.Text;
            SqlDataAdapter Adaptador = new SqlDataAdapter(Comando);
            DataTable Tabla = new DataTable();
            Adaptador.Fill(Tabla);
            return Tabla;
            
        }
        public DataTable EjecutarLectura(String query, List<SqlParameter> parametros)
        {
            Conexion.Open();
            SqlCommand Comando = new SqlCommand(query, Conexion);
            Comando.CommandType = CommandType.Text;
            for (int i = 0; i < parametros.Count; i++)
            {
                Comando.Parameters.Add(parametros[i]);
            }
            SqlDataAdapter DA = new SqlDataAdapter(Comando);
            DataTable Data = new DataTable();
            DA.Fill(Data);
            return Data;
        }
    }
    
}
