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
        public void AltaDeposito_x_sucursal(int id_med, int id_sucu, int minimo, int stock_act)
        {
           string sqlInsertar = "INSERT INTO deposito_x_sucursal(ID_Medicamento,ID_Sucursal,Minimo_stock,Stock_Actual) VALUES(" + id_med + "," + id_sucu +"," + minimo + "," + stock_act + ")";
                _BD.Insertar(sqlInsertar);
            
        }

        public DataTable Recuperar_x_ID_medicamento_sucursal(int ID_med, int ID_sucu)
        {
            string sqlRecuperarID = "SELECT * FROM deposito_x_sucursal WHERE ID_Medicamento = " + ID_med + "AND ID_Sucursal = " + ID_sucu;
            return _BD.EjecutarSelect(sqlRecuperarID);
        }

        public void Modificar_deposito_x_sucursal(int ID_med, int ID_sucu, int minimo, int actual, int nuevo_med, int nueva_sucu)
        {
            string sqlModificar_deposito_x_sucursal = @"UPDATE deposito_x_sucursal SET ID_Medicamento = " + ID_med + ","
                                                      + "ID_Sucursal = " + ID_sucu + ","
                                                      + "Minimo_stock = " + minimo + ","
                                                      + "Stock_Actual = " + actual + " "
                                                      + "WHERE ID_Medicamento = " + nuevo_med + "AND ID_Sucursal = " + nueva_sucu;
            _BD.Insertar(sqlModificar_deposito_x_sucursal);
        }


        public void Eliminardeposito_x_sucursal(int id_med, int id_sucu)
        {
            string sqlEliminardeposito_x_sucursal = "DELETE FROM deposito_x_sucursal WHERE ID_Medicamento = " + id_med + "AND ID_Sucursal = " +id_sucu;
            _BD.Insertar(sqlEliminardeposito_x_sucursal);
        }
        public DataTable Buscar_medicamentos_por_sucursal(int sucursal)
        {
            string sql = @"SELECT m.Nombre, d.Minimo_stock, d.Stock_Actual
                           FROM deposito_x_sucursal d JOIN medicamentos m ON d.ID_Medicamento = m.ID_medicamento
                           WHERE d.ID_Sucursal = " + sucursal;
            return _BD.EjecutarSelect(sql);
        }
    }
}
