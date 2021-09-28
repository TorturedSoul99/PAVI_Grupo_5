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
        public DataTable BuscarMedicamentosReceta(int ID, string columna = "ID_receta")
        {
            string sql = @"SELECT ID_receta, ID_medicamento, Periodicidad, Dosis
                           FROM medicamentos_x_receta WHERE " + columna + " like '%" + ID + "%'";

            return _BD.EjecutarSelect(sql);
        }
    }
}
