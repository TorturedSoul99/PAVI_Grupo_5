using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WindowsFormsApp1.Back_end;
using System.Data;

namespace WindowsFormsApp1.Negocio
{
    class NE_sintomas
    {
        BE_Acceso_datos _BD = new BE_Acceso_datos();

        public DataTable Cargar_sintomas()
        {
            string sql = "SELECT * FROM sintomas";
            DataTable tabla = _BD.EjecutarSelect(sql);
            return tabla;
        }

        public void Agregar_sintomas(string nuevo_sintoma)
        {
            string sql = @"INSERT INTO sintomas (Nombre)
                           VALUES ('" + nuevo_sintoma + "');";

            _BD.EjecutarABM(sql);
        }

        public void Modificar_sintomas(string sintoma, string corregido)
        {
            string sql = @"UPDATE sintomas
                           SET Nombre='" + corregido + @"'
                           WHERE Nombre='" + sintoma +"';";
            _BD.EjecutarABM(sql);
        }

        public void Eliminar_sintoma(string id_sintoma)
        {
            string sql = "DELETE FROM sintomas WHERE ID_sintoma=" + id_sintoma + ";";
            _BD.EjecutarABM(sql);
        }

        public DataTable Buscar_sintoma(string buscar)
        {
            string sql = @"SELECT * 
                           FROM sintomas 
                           WHERE Nombre LIKE '%" + buscar + "%';";
            DataTable tabla = _BD.EjecutarSelect(sql);
            return tabla;
        }
    }
}
