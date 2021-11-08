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
        //int SEXOO = 0;
        


        BE_Acceso_datos _BD = new BE_Acceso_datos();
        DataTable tabla = new DataTable();

        public DataTable BuscarPeso_x_Altura_x_Raza(string nombre)
        {
            string sql = @"SELECT p.Denominacion,s.Nombre,p.Peso_minimo,p.Peso_maximo,p.Altura_media"
                            + " FROM sexo s join peso_altura_x_raza p on s.ID = p.Sexo"
                            + " WHERE p.Denominacion like '" + nombre + "'";
            return _BD.EjecutarSelect(sql);
        }

        public DataTable BuscarTodos_Peso_x_Altura_x_Raza()
        {
            string sql = @"SELECT p.Denominacion,s.Nombre,p.Peso_minimo,p.Peso_maximo,p.Altura_media"
                            + " FROM sexo s join peso_altura_x_raza p on s.ID = p.Sexo";
            return _BD.EjecutarSelect(sql);
        }

        public DataTable BuscarTodosLOS_DATOS_DE_Peso_x_Altura_x_Raza(string denominacion,int sexo)
        {      
            string sql = @"SELECT * FROM peso_altura_x_raza WHERE Denominacion = '"+denominacion+"' AND Sexo = "+sexo;
            return _BD.EjecutarSelect(sql);
        }

        public void AltaPeso_x_Altura_x_Raza(string denominacion,int sexo,int pesoMin, int pesoMax,int alturaMedia)
        {
            string sqlInsertar = "INSERT INTO peso_altura_x_raza(Denominacion,Sexo,Peso_minimo,Peso_maximo,Altura_media) VALUES('" + denominacion + "'," + sexo + "," + pesoMin + "," + pesoMax + "," + alturaMedia + ")";
            _BD.Insertar(sqlInsertar);
        }

        public void Modificar_Peso_altura_x_Raza(string denominacion, int sexo, int peso_minimo, int peso_maximo, int altura_media, string DENOMINACION,int IDSEXO)
        {
            string sqlModificarEmpleado = @"UPDATE peso_altura_x_raza SET Denominacion = '" + denominacion + "',"
                                          + "Sexo = " + sexo + ","
                                          + "Peso_minimo = " + peso_minimo + ","
                                          + "Peso_maximo = " + peso_maximo + ","
                                          + "Altura_media = " + altura_media + " "
                                          + "WHERE Denominacion = '" + DENOMINACION +"' AND Sexo = "+ IDSEXO;
            _BD.Insertar(sqlModificarEmpleado);
        }


        public void Eliminar_UN_Peso_altura_x_Raza(string denominacion , int sexo)
        {
            string sqlEliminarEmpleado = "DELETE FROM peso_altura_x_raza WHERE Denominacion = '" + denominacion + "' AND Sexo = "+sexo;
            _BD.Insertar(sqlEliminarEmpleado);
        }
    }
}
