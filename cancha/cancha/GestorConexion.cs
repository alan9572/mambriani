using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Data.Sqlite;

namespace cancha
{
    internal class GestorConexion
    {
        private GestorConexion() {
            conexion = new SqliteConnection("datasource= predio.db");

        }
        private static GestorConexion _instancia;
        public static GestorConexion Instancia
        {
            get
            {
                if (_instancia == null)
                    _instancia = new GestorConexion();
                return _instancia;
            }
            private set { }
        }
        private SqliteConnection conexion;
        private SqliteCommand comando;
        private SqliteDataReader lector;
        public void ModificarBD(string consulta, List<SqliteParameter> parametros)
        {
            try
            {
                conexion.Open();
                comando = new SqliteCommand(consulta, conexion);
                comando = new SqliteCommand(consulta, conexion);
                if (parametros != null)
                    foreach (SqliteParameter p in parametros)
                        comando.Parameters.Add(p);
                comando.ExecuteNonQuery();
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            
            }
            conexion.Close();
        }
        public DataTable ConsultarBD(string consulta, List<SqliteParameter> parametros)
        {
            DataTable tabla = new DataTable();
            try
            {
                conexion.Open();
                comando = new SqliteCommand(consulta, conexion);
                if (parametros != null)
                    foreach (SqliteParameter p in parametros)
                        comando.Parameters.Add(p);
                lector=comando.ExecuteReader();
                tabla.Load(lector);
            }
            catch (Exception e)

            {
                MessageBox.Show(e.Message);

            }
            conexion.Close();
            return (tabla);
        }
    }
}
