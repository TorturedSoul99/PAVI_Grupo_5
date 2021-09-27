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

    }
}
