using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WindowsFormsApp1.Back_end;
using System.Data;

namespace WindowsFormsApp1.Negocio
{
    class NE_calendario_vacunas
    {
        BE_Acceso_datos _BD = new BE_Acceso_datos();

        public DataTable Cargar_calendario_vacunas()
        {
            string sql = @"SELECT cv.ID_historia_clinica, v.Nombre as 'Vacuna', cv.Fecha_estimada, 
                           cv.Fecha_real, e.Nombre as Empleado, l.Nombre as 'Laboratorio', cv.Dosis
                           FROM calendario_vacunas cv JOIN historia_clinica hc ON cv.ID_historia_clinica = hc.[N° Historia Clinica]
                           JOIN vacunas v ON cv.ID_vacuna = v.ID_vacuna
                           LEFT JOIN empleados e ON cv.ID_empleado = e.ID_empleado
                           LEFT JOIN laboratorios l ON cv.ID_laboratorio = l.ID_laboratorio;";
            DataTable tabla = _BD.EjecutarSelect(sql);
            return tabla;
        }

        public DataTable Buscar_calendario_vacunas(string nhc)
        {
            string sql = @"SELECT cv.ID_historia_clinica, v.Nombre as 'Vacuna', cv.Fecha_estimada, 
                           cv.Fecha_real, e.Nombre as Empleado, l.Nombre as 'Laboratorio', cv.Dosis
                           FROM calendario_vacunas cv JOIN historia_clinica hc ON cv.ID_historia_clinica = hc.[N° Historia Clinica]
                           JOIN vacunas v ON cv.ID_vacuna = v.ID_vacuna
                           LEFT JOIN empleados e ON cv.ID_empleado = e.ID_empleado
                           LEFT JOIN laboratorios l ON cv.ID_laboratorio = l.ID_laboratorio
                           WHERE CV.ID_historia_clinica = " + nhc + ";";
            DataTable tabla = _BD.EjecutarSelect(sql);
            return tabla;
        }


    }
}
