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
        public void AltaRaza(string denominacion,string cuidados)
        {
            string sqlInsertar = "INSERT INTO raza(Denominacion,Cuidados_especiales) VALUES('" + denominacion + "','" + cuidados + "')";
            _BD.Insertar(sqlInsertar);
        }
        public DataTable recuperar_por_Denominacion_Raza(string denominacion)
        {
            string sqlRecuperarID = "SELECT * FROM raza WHERE Denominacion = '" + denominacion +"'";
            //_BD.EjecutarSelect(sqlRecuperarID);
            return _BD.EjecutarSelect(sqlRecuperarID);
        }
        public void Modificar_Raza(string cuidados,string Actual_denominacion)
        {

            string sqlModificar = @"UPDATE raza SET Denominacion = '" + Actual_denominacion + "',"
                                          + "Cuidados_especiales = '" + cuidados + "'  WHERE Denominacion = '" + Actual_denominacion+"'";

            _BD.Insertar(sqlModificar);
        }
        public void Eliminar_Raza(string Actual_denominacion)
        {
            string sqlEliminar = "DELETE FROM raza WHERE Denominacion = '" + Actual_denominacion+"'";
            _BD.Insertar(sqlEliminar);
        }
    }
}
