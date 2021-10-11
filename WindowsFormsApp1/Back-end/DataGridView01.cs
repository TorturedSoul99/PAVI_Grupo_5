using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data;

namespace WindowsFormsApp1.Back_end
{
    class DataGridView01 : DataGridView
    {
        // Nombre de columna, ancho de columna, IDC (Izquierda, Derecha, Centro);  (; esto significa que sigue otra columna)
        //EJ: Apellido, 150, C; Nombre, 100, C; DNI, 75, C
        public void Formatear (string formato)
        {
            //formato.split significa que lo que le ponga por () formatea el objeto en varios elementos separados
            string[] datosColumna = formato.Split(';');

            this.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
            for (int i = 0; i < datosColumna.Length; i++)
            {
                string[] datos = datosColumna[i].Split(',');
                this.Columns.Add("Columna" + i.ToString(), datos[0].ToString());
                this.Columns[i].Width = int.Parse(datos[1].ToString());
                if (datos.Length == 3)
                {
                    switch (datos[2].Trim())
                    {
                        case "I":
                            this.Columns[i].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;
                            break;
                        case "D":
                            this.Columns[i].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
                            break;
                        case "C":
                            this.Columns[i].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
                            break;
                        default:
                            this.Columns[i].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleLeft;
                            break;
                    }
                }
            }
        }
        
        public void Cargar(DataTable tabla)
        {
            this.Rows.Clear();
            for (int fila = 0; fila < tabla.Rows.Count; fila++)
            {
                this.Rows.Add();
                for (int columna = 0; columna < tabla.Columns.Count; columna++)
                {
                    this.Rows[fila].Cells[columna].Value = tabla.Rows[fila][columna];
                }
            }
        }
    }
}
