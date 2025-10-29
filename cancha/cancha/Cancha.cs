using Microsoft.Data.Sqlite;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cancha
{
    internal class Cancha
    {
        protected int id_cancha;
        protected string deporte;
        protected int num_jugadores;
        protected int turnos;
        protected string nom_jugadores;

        public void ActualizarBD()
        {
            string consulta = "UPDATE cancha SET deporte=@deporte, turno=@turno, cliente=@cliente, num_jugadores=@num_jugadores WHERE id_cancha=@id";
            List<SqliteParameter> parametros = new List<SqliteParameter>();
            parametros.Add(new SqliteParameter("@deporte", 10));
            parametros.Add(new SqliteParameter("@turno", 10));
            parametros.Add(new SqliteParameter("@cliente", 10));
            parametros.Add(new SqliteParameter("@num_jugadores", 10));
            parametros.Add(new SqliteParameter("@id", 10));
            GestorConexion.Instancia.ModificarBD(consulta, parametros);
        }
        public static List<Cancha> traertodas()
        {
            string consulta = "SELECT * FROM cancha";
            DataTable tabla = GestorConexion.Instancia.ConsultarBD(consulta, null);
            foreach (DataRow fila in tabla.Rows)
            {
                Cancha nuevoObjeto = new Cancha();
                nuevoObjeto.atributo1 = fila["columna1"].ToString();
                nuevoObjeto.atributo1 = int.Parse(fila["columna2"].ToString());
                lista.add(nuevoObjeto);
            }
            return lista;
        }
        public static Cancha traeruno(int idAbuscar);

    }
}
