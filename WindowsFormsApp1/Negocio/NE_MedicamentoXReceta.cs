using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WindowsFormsApp1.Back_end;
using System.Data;

namespace WindowsFormsApp1.Negocio
{
    class NE_MedicamentoXReceta
    {
        BE_Acceso_datos _BD = new BE_Acceso_datos();

        public DataTable Cargar_medicamentosxreceta()
        {
            string sql = "SELECT * FROM medicamentos_x_receta;";
            DataTable tabla = _BD.EjecutarSelect(sql);
            return tabla;
        }

        public DataTable BuscarMedicamentosReceta(int ID, string columna = "ID_receta")
        {
            string sql = @"SELECT ID_receta, ID_medicamento, Periodicidad, Dosis
                           FROM medicamentos_x_receta WHERE " + columna + " like '%" + ID + "%'";

            return _BD.EjecutarSelect(sql);
        }
        public bool Alta_MedicamentoXReceta(int medicamento, int receta, string perio, string dosis)
        {
            string sql = "SELECT * FROM medicamentos_x_receta WHERE ID_medicamento = '" + medicamento + "' AND ID_receta = '" + receta+ "'";

            DataTable MXReceta = _BD.EjecutarSelect(sql);

            if (MXReceta.Rows.Count != 0)
            {
                return false;
            }
            sql = @"INSERT INTO medicamentos_x_receta ( ID_receta, ID_medicamento, Periodicidad, Dosis )
                    VALUES ('" + receta + "' , '" + medicamento + "' , '"+ perio + "' , '" + dosis + "'); ";

            _BD.EjecutarABM(sql);

            return true;
        }

        public void Modificar_medXreceta( int idRec, int idMed, string nuevaDosis, string nuevaPerio)
        {
            string sql = @"UPDATE medicamentos_x_receta
                           SET Periodicidad = '" + nuevaPerio + "', Dosis = '" + nuevaDosis +
                         "' WHERE ID_receta = " + idRec + " AND ID_medicamento = " + idMed + " ;";

            _BD.EjecutarABM(sql);
        }

        public void Eliminar_medicamentoxreceta( int idReceta, int idMedic, string dosis, string periodicidad)
        {
            string sql = "DELETE FROM medicamentos_x_receta WHERE ID_receta = " + idReceta + " AND ID_medicamento = " + idMedic + " AND Periodicidad = '" + periodicidad +"' AND Dosis = '" + dosis + "';";
            _BD.EjecutarABM(sql);
        }

        public DataTable Calcular_cantidad_medicamentos_x_fecha (string mes, string año)
        {
            string sql = @"SELECT c.Nro_orden, COUNT(m.ID_medicamento) AS 'ID_medicamento', c.Fecha_entrada
                          FROM medicamentos_x_receta m JOIN consulta c ON c.ID_receta = m.ID_receta
                          GROUP BY c.Nro_orden, c.Fecha_entrada
                          HAVING MONTH(c.Fecha_entrada) = " + mes + " AND YEAR(c.Fecha_entrada) = " + año + ";";

            DataTable tabla = _BD.EjecutarSelect(sql);
            return tabla;
        }

    }
}
