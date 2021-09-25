using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApp1.Back_end;

namespace WindowsFormsApp1.Back_end
{
    class ComboBox01 : ComboBox
    {
        BE_Acceso_datos _BD = new BE_Acceso_datos();

        public bool _ComboSinSeleccion { get; set; } = false;
        public string _tabla_cargar_combo { get; set; }
        public string _tabla_cargar_descriptor { get; set; }
        public string _tabla_cargar_pk { get; set; }

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
    }
}
