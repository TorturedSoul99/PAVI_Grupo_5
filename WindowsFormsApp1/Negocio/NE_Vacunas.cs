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

        public DataTable BuscarVacunas(string nombre)
        {
            string sql = "SELECT ID_vacuna, Nombre FROM vacunas WHERE Nombre like '%" + nombre + "%'";
            return _BD.EjecutarSelect(sql);

        }

    }
}
