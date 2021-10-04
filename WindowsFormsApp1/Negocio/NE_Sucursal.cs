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

        public void AltaSucursal(string nombre, int supervisor, int supervisorSuplente)
        {
            if (nombre != "" & supervisor == -1 && supervisorSuplente == -1)
            {
                string sqlInsertar = "INSERT INTO sucursal(Nombre_sucursal,ID_supervisor,ID_supervisor_suplente) VALUES('" + nombre + "',null,null)";
                _BD.Insertar(sqlInsertar);
            }
            else
            {
                string sqlInsertar = "INSERT INTO sucursal(Nombre_sucursal,ID_supervisor,ID_supervisor_suplente) VALUES('" + nombre + "'," + supervisor + "," + supervisorSuplente + ")";
                _BD.Insertar(sqlInsertar);
            }
        }

        public DataTable Recuperar_x_ID_Sucursal(int ID)
        {
            string sqlRecuperarID = "SELECT * FROM sucursal WHERE ID_sucursal = " + ID;
            //_BD.EjecutarSelect(sqlRecuperarID);
            return _BD.EjecutarSelect(sqlRecuperarID);
        }

        public void Modificar_Sucursal(string NomSucursal, int id_supervisor, int id_supervisor_suplente, int id_sucursal)
        {
            string sqlModificarSucursal = @"UPDATE sucursal SET Nombre_sucursal = '" + NomSucursal + "',"
                                          + "ID_supervisor = " + id_supervisor + ","
                                          + "ID_supervisor_suplente = " + id_supervisor_suplente + " "
                                          + "WHERE ID_sucursal = " + id_sucursal;
            _BD.Insertar(sqlModificarSucursal);
        }


        public void EliminarSucursal(int id)
        {
            string sqlEliminarSucursal = "DELETE FROM sucursal WHERE ID_sucursal = " + id;
            _BD.Insertar(sqlEliminarSucursal);
        }

    }
}
