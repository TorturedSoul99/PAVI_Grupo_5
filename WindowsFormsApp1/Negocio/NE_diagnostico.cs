using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using WindowsFormsApp1.Back_end;

namespace WindowsFormsApp1.Negocio
{
    class NE_diagnostico
    {
        BE_Acceso_datos _BD = new BE_Acceso_datos();

        public DataTable Cargar_diagnostico()
        {
            string sql = "SELECT * FROM diagnostico;";
            DataTable tabla = _BD.EjecutarSelect(sql);
            return tabla;
        }

        public DataTable BuscarDiagnostico(string nombre, string columna = "Nombre")
        {
            string sql = @"SELECT ID_diagnostico, Nombre
                           FROM diagnostico WHERE " + columna + " like '%" + nombre + "%'";

            return _BD.EjecutarSelect(sql);
        }
        public bool Alta_diagnostico(string nombre)
        {
            string sql = "SELECT ID_diagnostico, Nombre FROM diagnostico WHERE Nombre like '%" + nombre + "%'";

            DataTable diagnostico = _BD.EjecutarSelect(sql);

            if (diagnostico.Rows.Count != 0)
            {
                return false;
            }
            sql = @"INSERT INTO diagnostico ( Nombre )
                    VALUES ('"+ nombre +"');";

            _BD.EjecutarABM(sql);

            return true;
        }

        public void Modificar_diagnostico(int id, string nombre, string nombreNuevo)
        {
            string sql = "SELECT ID_diagnostico FROM diagnostico WHERE Nombre = '" + nombre + "';";

            DataTable tabla = _BD.EjecutarSelect(sql);

            int id_diagnostico = int.Parse(tabla.Rows[0][0].ToString());

            sql = @"UPDATE diagnostico
                           SET Nombre = '" + nombreNuevo + 
                         "' WHERE ID_diagnostico = " + id_diagnostico + ";";

            _BD.EjecutarABM(sql);
        }
    }
}
