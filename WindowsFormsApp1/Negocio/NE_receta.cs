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
            public DataTable BuscarReceta(int ID, string columna = "ID")
            {
                string sql = @"SELECT ID, ID_sucursal
                           FROM receta WHERE " + columna + " like '%" + ID + "%'";

                return _BD.EjecutarSelect(sql);
            }
        
    }
}
