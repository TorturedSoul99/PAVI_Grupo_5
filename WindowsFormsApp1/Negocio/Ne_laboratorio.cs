using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using WindowsFormsApp1.Back_end;

namespace WindowsFormsApp1.Negocio
{
    class NE_laboratorio
    {
        BE_Acceso_datos _BD = new BE_Acceso_datos();

        public DataTable BuscarLaboratorio(string nombre)
        {
            string sql = "SELECT * FROM laboratorios WHERE Nombre like '%" + nombre + "%'";
            return _BD.EjecutarSelect(sql);
        }

    }    
    
    

}
