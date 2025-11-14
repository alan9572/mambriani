using Microsoft.Data.Sqlite;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace cancha
{
    public class Cliente
    {
        protected int id;
        protected string nom_cancha;
        protected string deporte;

        public Cliente(int idCliente, string nombreCancha, string deporteCancha)
        {
            id = idCliente;
            nom_cancha = nombreCancha;
            deporte = deporteCancha;
        }
        public Cliente(string nombreCancha, string deporteCancha)
        {
            nom_cancha = nombreCancha;
            deporte = deporteCancha;
        }
        public int Id
        {
            get { return id; }
            private set { }
        }
        public string Nom_cancha
        {
            get { return nom_cancha; }
            set { nom_cancha = value; }
        }
        public string Deporte
        {
            get { return deporte; }
            set { deporte = value; }
        }

        public void AgregarABaseDeDatos(SqliteConnection conexion)
        {
            conexion.Open();
            string consulta = $"INSERT INTO cliente (nombre, descripcion, precio) VALUES ('{nombre}', '{descripcion}', '{precio}')";
            SqliteCommand comando = new SqliteCommand(consulta, conexion);
            comando.ExecuteNonQuery();
            conexion.Close();
        }
    }
}




        public void AgregarABaseDeDatos(SqliteConnection conexion)
        {
            conexion.Open();
            string consulta = $"INSERT INTO sabores (nombre, descripcion, precio) VALUES ('{nombre}', '{descripcion}', '{precio}')";
            SqliteCommand comando = new SqliteCommand(consulta, conexion);
            comando.ExecuteNonQuery();
            conexion.Close();
        }
        public void EditarSabor(SqliteConnection conexion)
        {
            conexion.Open();
            string consulta = $"UPDATE sabores SET nombre='{nombre}' , descripcion='{descripcion}', precio='{precio}' where id_sabores='{id}'";
            SqliteCommand comando = new SqliteCommand(consulta, conexion);
            comando.ExecuteNonQuery();
            conexion.Close();
        }

    }
}

