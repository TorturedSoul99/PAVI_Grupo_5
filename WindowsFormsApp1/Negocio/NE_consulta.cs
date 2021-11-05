using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WindowsFormsApp1.Back_end;
using System.Data;
using WindowsFormsApp1.Formularios;
using System.Windows.Forms;

namespace WindowsFormsApp1.Negocio
{
    class NE_consulta
    {
        public string Nro_orden { get; set; }
        public string Nro_historia_clinica { get; set; }
        public string ID_sucursal { get; set; }
        public string Fecha_entrada { get; set; }
        public string ID_empleado { get; set; }
        public string Fecha_salida { get; set; }
        public string Sintoma { get; set; }
        public string Diagnostico { get; set; }
        public string ID_receta { get; set; }





        BE_Acceso_datos _BD = new BE_Acceso_datos();

        public DataTable BuscarConsulta(string nro_orden)
        {
            string sql = "SELECT * FROM consulta WHERE Nro_orden like '%" + nro_orden + "%'";
            return _BD.EjecutarSelect(sql);
        }

        public DataTable MostrarConsulta()
        {
            string sql = "SELECT * FROM consulta";
            return _BD.EjecutarSelect(sql);
        }

        public DataTable MostrarConsultaXleo(int annoE,int annoS)
        {
            string sql = @"SELECT Fecha_entrada, Fecha_salida FROM consulta 
                           WHERE Fecha_entrada between '"+annoE+"-01-01' AND '"+annoS+"-12-31' ORDER BY Fecha_salida";
            

            return _BD.EjecutarSelect(sql);
        }
        public DataTable RecuperarConsulta(string nro_orden)
        {

            string sql = "SELECT * FROM consulta WHERE Nro_orden = " + nro_orden;


            return _BD.EjecutarSelect(sql);

        }
        public void RegistrarConsulta()
        {
            string sqlInsert = "";

            sqlInsert = @"INSERT INTO consulta (Nro_historia_clinica, ID_sucursal, Fecha_entrada , ID_empleado, Fecha_salida , Sintoma, Diagnostico, ID_receta ) VALUES(";

            sqlInsert += Nro_historia_clinica;
            sqlInsert += "," + ID_sucursal + "";
            sqlInsert += ",'" + Fecha_entrada + "'";
            sqlInsert += "," + ID_empleado + "";
            sqlInsert += ",'" + Fecha_salida + "'";
            sqlInsert += "," + Sintoma + "";
            sqlInsert += "," + Diagnostico + "";
            sqlInsert += "," + ID_receta + ")";


            _BD.Insertar(sqlInsert);

        }
        public void EliminarConsulta(string nro_orden)
        {
            string sql = "DELETE FROM consulta WHERE Nro_orden =" + nro_orden + ";";
            _BD.EjecutarSelect(sql);
        }
        public void modificar()
        {

            string sqlModificar = "UPDATE consulta SET ";

            sqlModificar += "Nro_historia_clinica = " + Nro_historia_clinica;
            sqlModificar += ", ID_sucursal = " + ID_sucursal + "";
            sqlModificar += ", Fecha_entrada = '" + Fecha_entrada + "'";
            sqlModificar += ", ID_empleado = " + ID_empleado + "";            
            sqlModificar += ", Fecha_salida = '" + Fecha_salida + "'";
            sqlModificar += ", Sintoma= " + Sintoma + "";
            sqlModificar += ", Diagnostico = " + Diagnostico + ""; ;
            sqlModificar += ", ID_receta = " + ID_receta + "";

            sqlModificar += " WHERE Nro_orden = " + Nro_orden;

            _BD.Insertar(sqlModificar);

        }
        public DataTable Buscar_orden_x_FechaEntrada(int anno)
        {
            string sql = "SELECT c.Nro_orden, c.Nro_historia_clinica, c.ID_sucursal, c.Fecha_entrada, c.Fecha_salida, hc.Nombre FROM consulta c JOIN historia_clinica hc ON c.Nro_historia_clinica=hc.Nro_historia_clinica AND c.ID_sucursal= hc.ID_sucursal WHERE Fecha_entrada between '" + anno + "0101' AND '" + anno + "1231' ORDER BY Fecha_entrada";
            return _BD.EjecutarSelect(sql);
        }


    }
}