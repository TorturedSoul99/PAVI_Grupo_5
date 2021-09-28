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

        public void AltaLaboratorio(string nombre,string descripcion) 
        {
            string sqlInsertar = "INSERT INTO laboratorios(Nombre,Descripcion) VALUES('"+nombre+"','"+descripcion+"')";
            _BD.Insertar(sqlInsertar);
        }
        public DataTable recuperar_por_id_laboratorio(int id)
        {
            string sqlRecuperarID = "SELECT * FROM laboratorios WHERE ID_laboratorio = " + id;
            //_BD.EjecutarSelect(sqlRecuperarID);
            return _BD.EjecutarSelect(sqlRecuperarID);
        }
        public void Modificar_laboratorio(int id, string nombre, string descripcion)
        {

            string sqlModificar = @"UPDATE laboratorios SET Nombre = '" + nombre + "',"
                                          + "Descripcion = '" + descripcion + "' WHERE ID_laboratorio = " + id;

            _BD.Insertar(sqlModificar);
        }
        public void Eliminar_laboratorio(int id)
        {
            string sqlEliminar = "DELETE FROM laboratorios WHERE ID_laboratorio = " + id;
            _BD.Insertar(sqlEliminar);
        }


    }    
    
    

}
