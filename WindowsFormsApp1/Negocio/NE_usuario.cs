using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WindowsFormsApp1.Back_end;
using System.Data;

namespace WindowsFormsApp1.Negocio
{
    class NE_usuario
    {
        public enum Validacion { correcta, incorrecta }
        BE_Acceso_datos _BD = new BE_Acceso_datos();

        public Validacion Validar (string nombre, string password)
        {
            string sql = @"SELECT * FROM usuarios 
                          WHERE[nombre usuario] = '" + nombre +"'" 
                          + " AND contraseña = " + password;

            DataTable tabla = new DataTable();
            tabla = _BD.EjecutarSelect(sql);

            if (tabla.Rows.Count == 1)
            {
                return Validacion.correcta;
            }
            else
            {
                return Validacion.incorrecta;
            }
        }
        


    }

}
