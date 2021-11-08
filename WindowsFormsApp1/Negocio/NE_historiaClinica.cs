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
    class NE_historiaClinica


    {
        public string Nro_historia_clinica { get; set; }
        public string ID_sucursal { get; set; }
        public string Nombre { get; set; }
        public string Fecha_nacimiento { get; set; }
        public string Raza { get; set; }
        public string Peso { get; set; }
        public string Altura { get; set; }
        public string Nombre_dueño { get; set; }
        public string Apellido_dueño { get; set; }
        public string Telefono { get; set; }




        BE_Acceso_datos _BD = new BE_Acceso_datos();

        public DataTable BuscarHistoriaClinica(string nombre)
        {
            string sql = "SELECT * FROM historia_clinica WHERE Nombre like '%" + nombre + "%'";
            return _BD.EjecutarSelect(sql);
        }

        public DataTable MostrarHistoriaClinica()
        {
            string sql = "SELECT * FROM historia_clinica";
            return _BD.EjecutarSelect(sql);
        }

        public DataTable RecuperarHistoriaClinica(string nro_historia_clinica)
        {

            string sql = "SELECT * FROM historia_clinica WHERE Nro_historia_clinica = " + nro_historia_clinica;


            return _BD.EjecutarSelect(sql);

        }
        public void EliminarHistoriaClinica(string nro_historia_clinica)
        {
            string sql = "DELETE FROM historia_clinica WHERE Nro_historia_clinica=" + nro_historia_clinica + ";";
            _BD.EjecutarSelect(sql);
        }


        public void RegistrarHistoriaClinica()
        {
            string sqlInsert = "";

            sqlInsert = @"INSERT INTO historia_clinica (ID_sucursal, Nombre, Fecha_nacimiento, Raza, Peso, Altura, Nombre_dueño, Apellido_dueño, Telefono ) VALUES(";

            sqlInsert += ID_sucursal;
            sqlInsert += ",'" + Nombre + "'";
            sqlInsert += ",'" + Fecha_nacimiento + "'";
            sqlInsert += ",'" + Raza + "'";
            sqlInsert += "," + Peso + "";
            sqlInsert += "," + Altura + "";
            sqlInsert += ",'" + Nombre_dueño + "'";
            sqlInsert += ",'" + Apellido_dueño + "' ";
            sqlInsert += "," + Telefono + ")";

            _BD.Insertar(sqlInsert);

        }


        public void modificar()
        {

            string sqlModificar = "UPDATE historia_clinica SET ";

            sqlModificar += "ID_sucursal = " + ID_sucursal;
            sqlModificar += ", Nombre = '" + Nombre + "'";
            sqlModificar += ", Fecha_nacimiento = '" + Fecha_nacimiento + "'";
            sqlModificar += ", Raza = '" + Raza + "'";
            sqlModificar += ", Peso = " + Peso;
            sqlModificar += ", Altura = " + Altura;
            sqlModificar += ", Nombre_dueño = '" + Nombre_dueño + "'";
            sqlModificar += ", Apellido_dueño = '" + Apellido_dueño + "'";
            sqlModificar += ", Telefono = " + Telefono;
            sqlModificar += " WHERE Nro_historia_clinica = " + Nro_historia_clinica;

            _BD.Insertar(sqlModificar);

        }

        public DataTable Buscar_sucursal_x_historiaClinica(int id_sucursal)
        {
            string sql = "SELECT Nro_historia_clinica, Nombre, Fecha_nacimiento, Raza, Nombre_dueño, Apellido_dueño FROM historia_clinica WHERE ID_sucursal = " + id_sucursal;
            return _BD.EjecutarSelect(sql);
        }


    }
}