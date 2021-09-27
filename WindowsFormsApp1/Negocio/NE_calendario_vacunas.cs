using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WindowsFormsApp1.Back_end;
using System.Data;
using System.Windows.Forms;

namespace WindowsFormsApp1.Negocio
{
    class NE_calendario_vacunas
    {
        BE_Acceso_datos _BD = new BE_Acceso_datos();

        public DataTable Cargar_calendario_vacunas()
        {
            string sql = @"SELECT DISTINCT cv.ID_historia_clinica, s.Nombre_sucursal, v.Nombre as 'Vacuna', cv.Fecha_estimada, 
                           cv.Fecha_real, e.Nombre as Empleado, l.Nombre as 'Laboratorio', cv.Dosis
                           FROM calendario_vacunas cv JOIN historia_clinica hc ON cv.ID_historia_clinica = hc.Nro_historia_clinica
                           JOIN vacunas v ON cv.ID_vacuna = v.ID_vacuna
                           JOIN sucursal s ON cv.ID_sucursal = s.ID_sucursal
                           LEFT JOIN empleados e ON cv.ID_empleado = e.ID_empleado
                           LEFT JOIN laboratorios l ON cv.ID_laboratorio = l.ID_laboratorio;";
            DataTable tabla = _BD.EjecutarSelect(sql);
            return tabla;
        }

        public DataTable Buscar_calendario_vacunas(string nhc, string sucursal)
        {
            string sql = @"SELECT cv.ID_historia_clinica, s.Nombre_sucursal, v.Nombre as 'Vacuna', cv.Fecha_estimada, 
                           cv.Fecha_real, e.Nombre as Empleado, l.Nombre as 'Laboratorio', cv.Dosis
                           FROM calendario_vacunas cv JOIN historia_clinica hc ON cv.ID_historia_clinica = hc.Nro_historia_clinica
                           JOIN vacunas v ON cv.ID_vacuna = v.ID_vacuna
                           JOIN sucursal s ON cv.ID_sucursal = s.ID_sucursal
                           LEFT JOIN empleados e ON cv.ID_empleado = e.ID_empleado
                           LEFT JOIN laboratorios l ON cv.ID_laboratorio = l.ID_laboratorio
                           WHERE CV.ID_historia_clinica = " + nhc + " AND cv.ID_sucursal = " + sucursal + ";";
            DataTable tabla = _BD.EjecutarSelect(sql);
            return tabla;
        }
       
        public bool Alta_calendario_vacunas(string nhc, string vacuna, string sucursal, string fecha)
        {
            string sql = "SELECT * FROM calendario_vacunas WHERE ID_historia_clinica = " + nhc + " AND ID_vacuna = " + vacuna + " AND ID_sucursal = " + sucursal;

            DataTable calendario_vacunas = _BD.EjecutarSelect(sql);

            sql = "SELECT * FROM historia_clinica WHERE Nro_historia_clinica = " + nhc + " AND ID_sucursal = " + sucursal + ";";

            DataTable historia_clinica = _BD.EjecutarSelect(sql);


            if (calendario_vacunas.Rows.Count > 0 || historia_clinica.Rows.Count == 0)
            {
                return false;
            }

            sql = @"INSERT INTO calendario_vacunas (ID_historia_clinica, ID_vacuna, ID_sucursal, Fecha_estimada)
                    VALUES (" + nhc + ", " + vacuna + ", " + sucursal + ", '" + fecha + "');";

            _BD.EjecutarABM(sql);

            return true;
        }

        public void Modificar_calendario_vacunas(string sucursal, string nhc, string vacuna, string fecha_estimada, string fecha_real, string laboratorio, string empleado, string dosis)
        {
            string sql = "SELECT ID_sucursal FROM sucursal WHERE Nombre_sucursal = '" + sucursal + "';";

            DataTable tabla = _BD.EjecutarSelect(sql);

            sucursal = tabla.Rows[0][0].ToString();

            sql = "SELECT ID_vacuna FROM vacunas WHERE Nombre = '" + vacuna + "';";

            tabla = _BD.EjecutarSelect(sql);

            vacuna = tabla.Rows[0][0].ToString();


            sql = @"UPDATE calendario_vacunas
                           SET Fecha_estimada = '" + fecha_estimada + "', Fecha_real = '" + fecha_real + "', ID_empleado = '" + empleado + "', " + "ID_laboratorio = " + 
                           laboratorio + ", Dosis = " + dosis +
                         " WHERE ID_historia_clinica = " + nhc + " AND ID_vacuna = " + vacuna + " AND ID_sucursal = " + sucursal + ";";

            _BD.EjecutarABM(sql);
        }

        public void Eliminar_calendario_vacunas(string nhc, string sucursal, string vacuna)
        {
            string sql = "SELECT ID_sucursal FROM sucursal WHERE Nombre_sucursal = '" + sucursal + "';";

            DataTable tabla = _BD.EjecutarSelect(sql);

            sucursal = tabla.Rows[0][0].ToString();

            sql = "SELECT ID_vacuna FROM vacunas WHERE Nombre = '" + vacuna + "';";

            tabla = _BD.EjecutarSelect(sql);

            vacuna = tabla.Rows[0][0].ToString();

            sql = "DELETE FROM calendario_vacunas WHERE ID_historia_clinica = " + nhc + " AND ID_sucursal = " + sucursal + " AND ID_vacuna = " + vacuna +";";
            _BD.EjecutarABM(sql);
        }
    }
}
