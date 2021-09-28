using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WindowsFormsApp1.Back_end;
using System.Data;

namespace WindowsFormsApp1.Negocio
{
    class NE_receta
    {

        BE_Acceso_datos _BD = new BE_Acceso_datos();

        public DataTable Cargar_receta()
        {
            string sql = "SELECT * FROM receta;";
            DataTable tabla = _BD.EjecutarSelect(sql);
            return tabla;
        }
        public DataTable BuscarReceta(int ID, string columna = "ID")
        {
            string sql = @"SELECT ID, ID_sucursal
                           FROM receta WHERE " + columna + " like '%" + ID + "%'";

            return _BD.EjecutarSelect(sql);
        }

        public bool Alta_receta(int sucu)
        {
            string sql = "SELECT ID, ID_sucursal FROM receta";

            DataTable receta = _BD.EjecutarSelect(sql);

            if (receta.Rows.Count == 0)
            {
                return false;
            }
            sql = @"INSERT INTO receta ( ID_sucursal )
                    VALUES (" + sucu + ");";

            _BD.EjecutarABM(sql);

            return true;

        }

        public void Modificar_receta(int id_sucursal, int nuevaSucursal)
        {
            string sql = "SELECT ID FROM receta WHERE ID_sucursal = '" + id_sucursal + "';";

            DataTable tabla = _BD.EjecutarSelect(sql);

            int id_receta = int.Parse(tabla.Rows[0][0].ToString());

            sql = @"UPDATE receta
                           SET ID_sucursal = '" + nuevaSucursal +
                         "' WHERE ID = " + id_receta + ";";

            _BD.EjecutarABM(sql);

        }

        public void Eliminar_receta( int id, int id_sucursal)
        {
            string sql = "DELETE FROM receta WHERE ID = " + id + " AND ID_sucursal = " + id_sucursal + ";";
            _BD.EjecutarABM(sql);
        }
    }
}
