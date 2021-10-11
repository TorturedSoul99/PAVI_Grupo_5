﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WindowsFormsApp1.Back_end;
using System.Data;

namespace WindowsFormsApp1.Negocio
{
    class NE_Medicamento
    {
        BE_Acceso_datos _BD = new BE_Acceso_datos();

        public DataTable BuscarMedicamento(string nombre)
        {
            string sql = "SELECT * FROM medicamentos WHERE Nombre like '%" + nombre + "%'";
            return _BD.EjecutarSelect(sql);
        }
        public void AltaMedicamento(string nombre, int laboratorio, string fecha, int sucursal)
        {
            string sqlInsertar = "INSERT INTO medicamentos(ID_sucursal,Laboratorio,Nombre,FechaUltimaCompra) VALUES(" + sucursal + "," + laboratorio + ", '" + nombre + "','" + fecha + "')";
            _BD.Insertar(sqlInsertar);
        }
        public DataTable recuperar_por_id_medicamento(int id)
        {
            string sqlRecuperarID = "SELECT * FROM medicamentos WHERE ID_medicamento = " + id;
            //_BD.EjecutarSelect(sqlRecuperarID);
            return _BD.EjecutarSelect(sqlRecuperarID);
        }
        public void Modificar_medicamento(int id, string nombre, int laboratorio, string fecha, int sucursal)
        {

            string sqlModificar = @"UPDATE medicamentos SET ID_Sucursal = " + sucursal + ","
                                          + "Laboratorio = " + laboratorio + ", " + "Nombre = '" + nombre + "', FechaUltimaCompra = '" + fecha + "'  WHERE ID_medicamento = " + id;

            _BD.Insertar(sqlModificar);
        }
        public void Eliminar_medicamento(int id)
        {
            string sqlEliminar = "DELETE FROM medicamentos WHERE ID_medicamento = " + id;
            _BD.Insertar(sqlEliminar);
        }
    }
}