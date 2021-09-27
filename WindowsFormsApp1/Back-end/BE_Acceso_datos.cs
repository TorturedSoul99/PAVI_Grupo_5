using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace WindowsFormsApp1.Back_end
{
    class BE_Acceso_datos
    {
        SqlConnection Conexion = new SqlConnection();
        SqlCommand Cmd = new SqlCommand();
        string cadena_conexion = "Data Source=200.69.137.167,11333;Initial Catalog=BD3K3G05_2021;Persist Security Info=True;User ID=BD3K3G05_2021;Password=BDG05_7412";

        private void Conectar()
        {
            Conexion.ConnectionString = cadena_conexion;
            Conexion.Open();
            Cmd.Connection = Conexion;
            Cmd.CommandType = System.Data.CommandType.Text;
        }
        private void Cerrar()
        {
            Conexion.Close();
        }
        public DataTable EjecutarSelect(string sql)
        {
            Conectar();
            Cmd.CommandText = sql;
            DataTable tabla = new DataTable();
            tabla.Load(Cmd.ExecuteReader());
            Cerrar();
            return tabla;
        }

        public void Insertar(string sqlInsertar)
        {
            Conectar();
            Cmd.CommandText = sqlInsertar;
            Cmd.ExecuteNonQuery();
            Cerrar();
        }


    }
}
