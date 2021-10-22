using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WindowsFormsApp1.Back_end;
using System.Data;

namespace WindowsFormsApp1.Negocio
{
    class NE_Peso_x_Altura_x_Raza
    {
        BE_Acceso_datos _BD = new BE_Acceso_datos();
        DataTable tabla = new DataTable();

        public DataTable BuscarPeso_x_Altura_x_Raza(string nombre)
        {
            string sql = @"SELECT p.Denominacion,s.Nombre,p.Peso_minimo,p.Peso_maximo,p.Altura_media"
                            + "FROM sexo s join peso_altura_x_raza p on s.ID = p.Sexo"
                            + "WHERE p.Denominacion like '" + nombre + "'";
            return _BD.EjecutarSelect(sql);
        }

        public DataTable BuscarTodos_Peso_x_Altura_x_Raza()
        {
            string sql = @"SELECT p.Denominacion,s.Nombre,p.Peso_minimo,p.Peso_maximo,p.Altura_media"
                            + "FROM sexo s join peso_altura_x_raza p on s.ID = p.Sexo";
            return _BD.EjecutarSelect(sql);
        }

        public void AltaEmpleado(string tipDoc, int nroDoc, string nombre, string apellido, string fechaNacimiento, string fechaIngreso, int idSucursal, string matricula)
        {
            string sqlInsertar = "INSERT INTO empleados(Tipo_documento,Nro_documento,Nombre,Apellido,Fecha_nacimiento,Fecha_ingreso,ID_sucursal,Matricula) VALUES('" + tipDoc + "'," + nroDoc + ",'" + nombre + "','" + apellido + "','" + fechaNacimiento + "','" + fechaIngreso + "'," + idSucursal + ",'" + matricula + "')";
            _BD.Insertar(sqlInsertar);
        }


        public DataTable Recuperar_x_IDempleado(int ID)
        {
            string sqlRecuperarID = "SELECT * FROM empleados WHERE ID_empleado = " + ID;
            //_BD.EjecutarSelect(sqlRecuperarID);
            return _BD.EjecutarSelect(sqlRecuperarID);
        }


        public void Modificar_Empleado(string TipoDoc, int nroDoc, string nombre, string apellido, string fechaNacimiento, string fechaIngreso, int Idsucursal, string matricula, int idEMPLEADO)
        {
            string sqlModificarEmpleado = @"UPDATE empleados SET Tipo_documento = '" + TipoDoc + "',"
                                          + "Nro_documento = " + nroDoc + ","
                                          + "Nombre = '" + nombre + "',"
                                          + "Apellido = '" + apellido + "',"
                                          + "Fecha_nacimiento = '" + fechaNacimiento + "',"
                                          + "Fecha_ingreso = '" + fechaIngreso + "',"
                                          + "ID_sucursal = " + Idsucursal + ","
                                          + "Matricula = '" + matricula + "' "
                                          + "WHERE ID_empleado = " + idEMPLEADO;
            _BD.Insertar(sqlModificarEmpleado);
        }


        public void EliminarEmpleado(int id)
        {
            string sqlEliminarEmpleado = "DELETE FROM empleados WHERE ID_empleado = " + id;
            _BD.Insertar(sqlEliminarEmpleado);
        }
    }
}
