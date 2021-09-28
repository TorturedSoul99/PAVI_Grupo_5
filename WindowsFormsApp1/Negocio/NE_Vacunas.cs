using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WindowsFormsApp1.Back_end;
using System.Data;

namespace WindowsFormsApp1.Negocio
{
    class NE_Vacunas
    {
        BE_Acceso_datos _BD = new BE_Acceso_datos();

        public DataTable Cargar_vacunas()
        {
            string sql = "SELECT * FROM vacunas;";
            DataTable tabla = _BD.EjecutarSelect(sql);
            return tabla;
        }
        public DataTable BuscarVacunas(string nombre)
        {
            string sql = "SELECT ID_vacuna, Nombre FROM vacunas WHERE Nombre like '%" + nombre + "%'";
            return _BD.EjecutarSelect(sql);

        }
        public bool Alta_vacuna(string nombre)
        {
            string sql = "SELECT ID_vacuna, Nombre FROM vacunas WHERE Nombre like '%" + nombre + "%'";

            DataTable vacuna = _BD.EjecutarSelect(sql);

            if (vacuna.Rows.Count != 0)
            {
                return false;
            }
            sql = @"INSERT INTO vacunas ( Nombre )
                    VALUES ('" + nombre + "');";

            _BD.EjecutarABM(sql);

            return true;
        }

        public void Modificar_vacuna(string nombre, string nuevoNombre)
        {
            string sql = "SELECT ID_vacuna FROM vacunas WHERE Nombre = '" + nombre + "';";

            DataTable tabla = _BD.EjecutarSelect(sql);

            int id_vacuna = int.Parse(tabla.Rows[0][0].ToString());

            sql = @"UPDATE vacunas
                           SET Nombre = '" + nuevoNombre +
                         "' WHERE ID_vacuna = " + id_vacuna + ";";

            _BD.EjecutarABM(sql);

        }
    }
}
