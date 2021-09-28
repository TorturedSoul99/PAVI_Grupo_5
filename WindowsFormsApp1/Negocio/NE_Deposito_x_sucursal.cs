using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WindowsFormsApp1.Back_end;
using System.Data;

namespace WindowsFormsApp1.Negocio
{
    class NE_Deposito_x_sucursal
    {
        BE_Acceso_datos _BD = new BE_Acceso_datos();

        public DataTable BuscarDeposito_x_sucursal(String id_medicamento)
        {
            string sql = "SELECT * FROM deposito_x_sucursal WHERE ID_Medicamento like '%" + id_medicamento + "%'";
            return _BD.EjecutarSelect(sql);
        }
    }
}
