using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WindowsFormsApp1.Back_end;
using System.Data;

namespace WindowsFormsApp1.Negocio
{
    class NE_Raza
    {
        BE_Acceso_datos _BD = new BE_Acceso_datos();

        public DataTable BuscarRazaDenominacion(string nombre)
        {
            string sql = "SELECT * FROM raza WHERE Denominacion like '%" + nombre + "%'";
            return _BD.EjecutarSelect(sql);
        }

        public DataTable BuscarTodosRaza()
        {
            string sql = "SELECT * FROM raza";
            return _BD.EjecutarSelect(sql);
        }
    }
}
