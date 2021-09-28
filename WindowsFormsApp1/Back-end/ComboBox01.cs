using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data;
using WindowsFormsApp1.Back_end;

namespace WindowsFormsApp1.Back_end
{
    class ComboBox01 : ComboBox
    {
        BE_Acceso_datos _BD = new BE_Acceso_datos();
        
        public string Pp_MessageError { get; set; }
        public string Pp_Pk { get; set; }
        public string Pp_Descripcion { get; set; }
        public string Pp_Tabla { get; set; }
        public bool Pp_conseleccion { get; set; }
        public bool validable { get; set; }

        // Variables Emma
        public bool _ComboSinSeleccion { get; set; } = false;
        public string _tabla_cargar_combo { get; set; }
        public string _tabla_cargar_descriptor { get; set; }
        public string _tabla_cargar_pk { get; set; }
        public string _tabla_cargar_relacion { get; set; }
        public string _tabla_cargar_relacion_pk { get; set; }
        public string _tabla_cargar_fk { get; set; }
        public string _tabla_cargar_condicion { get; set; }


        public void cargarCombo()
        {            
            //DataTable tabla = new DataTable();
            string sqlCombo = "SELECT " + Pp_Pk + ","+Pp_Descripcion+" FROM "+Pp_Tabla;
            //tabla = _BD.EjecutarSelect(sqlCombo);
            this.DisplayMember = Pp_Descripcion;
            this.ValueMember = Pp_Pk;
            this.DataSource = _BD.EjecutarSelect(sqlCombo);

            if (this.Pp_conseleccion == true)
            {
                this.SelectedIndex = 0;
            }
            else
            {
                this.SelectedIndex = -1;
            }
        }

        // Funciones Emma
        public void _Cargar()
        {
            string sql = "SELECT " + _tabla_cargar_pk + ", " + _tabla_cargar_descriptor + " FROM " + _tabla_cargar_combo;
            this.DisplayMember = _tabla_cargar_descriptor;
            this.ValueMember = _tabla_cargar_pk;
            this.DataSource = _BD.EjecutarSelect(sql);
            if (_ComboSinSeleccion == true)
                this.SelectedIndex = -1;
            else
                this.SelectedIndex = 0;
        }

        public void _CargarDistintos()
        {
            string sql = "SELECT DISTINCT " + _tabla_cargar_pk + ", " + _tabla_cargar_descriptor + " FROM " + _tabla_cargar_combo;
            this.DisplayMember = _tabla_cargar_descriptor;
            this.ValueMember = _tabla_cargar_pk;
            this.DataSource = _BD.EjecutarSelect(sql);
            if (_ComboSinSeleccion == true)
                this.SelectedIndex = -1;
            else
                this.SelectedIndex = 0;
        }

        public void _CargarRelacion(string condicion)
        {
            string sql = "SELECT a." + _tabla_cargar_pk + ", a." + _tabla_cargar_descriptor + " " +
                         "FROM " + _tabla_cargar_combo + " a " +
                         "JOIN " + _tabla_cargar_relacion + " b ON a." + _tabla_cargar_fk + " = b." + _tabla_cargar_relacion_pk + " " +
                         "WHERE b." + _tabla_cargar_condicion + " = '" + condicion + "';";
            this.DisplayMember = _tabla_cargar_descriptor;
            this.ValueMember = _tabla_cargar_pk;
            this.DataSource = _BD.EjecutarSelect(sql);
            if (_ComboSinSeleccion == true)
                this.SelectedIndex = -1;
            else
                this.SelectedIndex = 0;
        }

    }
}
