using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WindowsFormsApp1.Back_end;
using System.Data;

namespace WindowsFormsApp1.Negocio
{
    class Negocio_Proceso_Consulta_Canes
    {
        BE_Acceso_datos _BD = new BE_Acceso_datos();

        public DataTable RecuperarPerro(string nombre)
        {

            string sql = "SELECT Nro_historia_clinica,ID_sucursal,Nombre,Raza,Nombre_dueño,Apellido_dueño,Telefono FROM historia_clinica WHERE Nombre like '%" + nombre + "%'";


            return _BD.EjecutarSelect(sql);

        }

        public DataTable RecuperarConsultas()
        {

            string sql = "SELECT Nro_orden,Nro_historia_clinica,ID_sucursal,Fecha_entrada,ID_empleado,Fecha_salida FROM consulta";


            return _BD.EjecutarSelect(sql);

        }

        public DataTable RecuperarConsultasPerro(int id_nroHistoriaClinica, int ID_sucursalConsulta)
        {

            string sql = @"SELECT Nro_orden,Nro_historia_clinica,ID_sucursal,Fecha_entrada,ID_empleado,Fecha_salida " +
                "FROM consulta " +
                "WHERE Nro_historia_clinica = "+id_nroHistoriaClinica+" AND ID_sucursal = "+ID_sucursalConsulta;


            return _BD.EjecutarSelect(sql);

        }
    }
}
