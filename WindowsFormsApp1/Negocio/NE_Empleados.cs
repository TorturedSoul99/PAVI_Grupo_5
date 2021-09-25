using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WindowsFormsApp1.Back_end;
using System.Data;

namespace WindowsFormsApp1.Negocio
{
    class NE_Empleados
    {
        BE_Acceso_datos _BD = new BE_Acceso_datos();

        public DataTable BuscarEmpleadoNombre(string nombre)
        {
            string sql = "SELECT * FROM empleados WHERE Nombre like '%" + nombre + "%'";
            return _BD.EjecutarSelect(sql);
        }
        
        public DataTable BuscarEmpleadoID(int num)
        {
            string sql = "SELECT * FROM empleados WHERE ID_empleado = " + num;
            return _BD.EjecutarSelect(sql);
        }
        
        public DataTable BuscarEmpleadoIDSucursal(int numSucursal)
        {
            string sql = "SELECT * FROM empleados WHERE ID_sucursal = " + numSucursal;
            return _BD.EjecutarSelect(sql);
        }
        
        public DataTable BuscarTodosEmpleados()
        {
            string sql = "SELECT * FROM empleados";
            return _BD.EjecutarSelect(sql);
        }
    }
}
