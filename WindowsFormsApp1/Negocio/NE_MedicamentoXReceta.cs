﻿using System;
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
    }
}
