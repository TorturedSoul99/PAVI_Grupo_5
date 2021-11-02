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
        DataTable tabla = new DataTable(); 

        public DataTable BuscarEmpleadoNombre(string nombre)
        {
            string sql = "SELECT e.ID_empleado,e.Tipo_documento,e.Nro_documento,e.Nombre,e.Apellido,e.Fecha_nacimiento,e.Fecha_ingreso,s.Nombre_sucursal,e.Matricula FROM empleados e join sucursal s on e.ID_sucursal = s.ID_sucursal WHERE Nombre like '%" + nombre + "%'";
            return _BD.EjecutarSelect(sql);
        }
        
        public DataTable BuscarEmpleadoID(int num)
        {
            string sql = "SELECT e.ID_empleado,e.Tipo_documento,e.Nro_documento,e.Nombre,e.Apellido,e.Fecha_nacimiento,e.Fecha_ingreso,s.Nombre_sucursal,e.Matricula FROM empleados e join sucursal s on e.ID_sucursal = s.ID_sucursal WHERE ID_empleado = " + num;
            return _BD.EjecutarSelect(sql);
        }
        
        public DataTable BuscarEmpleadoIDSucursal(string nomSucursal)
        {
            string sql = "SELECT e.ID_empleado,e.Tipo_documento,e.Nro_documento,e.Nombre,e.Apellido,e.Fecha_nacimiento,e.Fecha_ingreso,s.Nombre_sucursal,e.Matricula FROM empleados e join sucursal s on e.ID_sucursal = s.ID_sucursal WHERE Nombre_sucursal = '" +nomSucursal+"'";
            return _BD.EjecutarSelect(sql);
        }
        
        public DataTable BuscarTodosEmpleados()
        {
            string sql = "SELECT e.ID_empleado,e.Tipo_documento,e.Nro_documento,e.Nombre,e.Apellido,e.Fecha_nacimiento,e.Fecha_ingreso,s.Nombre_sucursal,e.Matricula FROM empleados e join sucursal s on e.ID_sucursal = s.ID_sucursal";
            return _BD.EjecutarSelect(sql);
        }

        public void AltaEmpleado(string tipDoc, int nroDoc, string nombre,string apellido,string fechaNacimiento,string fechaIngreso,int idSucursal,string matricula)
        {
            string sqlInsertar = "INSERT INTO empleados(Tipo_documento,Nro_documento,Nombre,Apellido,Fecha_nacimiento,Fecha_ingreso,ID_sucursal,Matricula) VALUES('" + tipDoc + "'," + nroDoc + ",'" + nombre + "','"+ apellido +"','"+ fechaNacimiento +"','"+fechaIngreso+"',"+idSucursal+",'"+matricula+"')";
            _BD.Insertar(sqlInsertar);
        }


        public DataTable Recuperar_x_IDempleado(int ID)
        {
            string sqlRecuperarID = "SELECT * FROM empleados WHERE ID_empleado = " + ID;
            //_BD.EjecutarSelect(sqlRecuperarID);
            return _BD.EjecutarSelect(sqlRecuperarID);
        }


        public void Modificar_Empleado(string TipoDoc,int nroDoc,string nombre,string apellido,string fechaNacimiento,string fechaIngreso,int Idsucursal,string matricula,int idEMPLEADO)
        {
            string sqlModificarEmpleado = @"UPDATE empleados SET Tipo_documento = '"+TipoDoc+"',"
                                          +"Nro_documento = "+nroDoc+","
                                          +"Nombre = '"+nombre+"',"
                                          +"Apellido = '"+apellido+"',"
                                          +"Fecha_nacimiento = '"+fechaNacimiento+"',"
                                          +"Fecha_ingreso = '"+fechaIngreso+"',"
                                          +"ID_sucursal = "+Idsucursal+","
                                          +"Matricula = '"+matricula+"' "
                                          +"WHERE ID_empleado = "+idEMPLEADO;
            _BD.Insertar(sqlModificarEmpleado);
        }


        public void EliminarEmpleado(int id)
        {
            string sqlEliminarEmpleado = "DELETE FROM empleados WHERE ID_empleado = "+id;
            _BD.Insertar(sqlEliminarEmpleado);
        }



        public DataTable Buscar_empleado_x_FechaIngreso(int anno)
        {
            string sql = "SELECT ID_empleado, Nro_documento, Nombre, Apellido, Fecha_ingreso FROM empleados WHERE Fecha_ingreso between '"+anno+"0101' AND '"+anno+"1231' ORDER BY Fecha_ingreso" ;
            return _BD.EjecutarSelect(sql);
        }

        public DataTable Empleados_x_Sucursal(int sucursal)
        {
            string sql = "SELECT e.Nro_documento,e.Nombre,e.Apellido,e.Fecha_nacimiento,e.Matricula FROM empleados e WHERE e.ID_sucursal = "+sucursal;
            return _BD.EjecutarSelect(sql);
        }
        
    }
}
