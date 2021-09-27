using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using WindowsFormsApp1.Back_end;

namespace WindowsFormsApp1.Negocio
{
    class NE_Sucursal
    {
        BE_Acceso_datos _BD = new BE_Acceso_datos();

        public DataTable BuscarSucursal(string nombre)
        {
            string sql = "SELECT * FROM sucursal WHERE Nombre_sucursal like '%" + nombre + "%'";
            return _BD.EjecutarSelect(sql);
        }
        public DataTable BuscarTodosSurcursales()
        {
            string sql = "SELECT * FROM sucursal";
            return _BD.EjecutarSelect(sql);
        }
    }
}
