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
        public DataTable BuscarDiagnostico(string nombre, string columna = "Nombre")
        {
            string sql = @"SELECT ID_diagnostico, Nombre
                           FROM diagnostico WHERE " + columna + " like '%" + nombre + "%'";

            return _BD.EjecutarSelect(sql);
        }
    }
}
