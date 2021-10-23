using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApp1.Negocio;
using WindowsFormsApp1.Formularios.ABM_InformacionCanes.ABM_Peso_x_Altura_x_Raza;

namespace WindowsFormsApp1.Formularios.ABM_InformacionCanes
{
    public partial class Peso_x_altura_x_Raza : Form
    {
        public string DENOMINACION { get; set; }
        public string SEXO { get; set; }

        NE_Peso_x_Altura_x_Raza peso_altura = new NE_Peso_x_Altura_x_Raza();
        DataTable tabla = new DataTable();
        
        public Peso_x_altura_x_Raza()
        {
            InitializeComponent();
        }

        private void btnConsultar_Click(object sender, EventArgs e)
        {
            if (chk_todos.Checked == true)
            {
                tabla = peso_altura.BuscarTodos_Peso_x_Altura_x_Raza();
                cargar_grilla(tabla);
            }
            else
            {
                if (txt_denominacion.Text != "")
                {
                    tabla = peso_altura.BuscarPeso_x_Altura_x_Raza(txt_denominacion.Text);
                    cargar_grilla(tabla);
                }
                else
                {
                    MessageBox.Show("Por favor agregar una denominacion para buscar");
                }
            }
        }

        private void Peso_x_altura_x_Raza_Load(object sender, EventArgs e)
        {

        }

        private void cargar_grilla(DataTable tabla)
        {
            grid_Peso_altura_raza.Rows.Clear();
            for (int i = 0; i < tabla.Rows.Count; i++)
            {
                grid_Peso_altura_raza.Rows.Add();
                grid_Peso_altura_raza.Rows[i].Cells[0].Value = tabla.Rows[i]["Denominacion"].ToString();
                grid_Peso_altura_raza.Rows[i].Cells[1].Value = tabla.Rows[i]["Nombre"].ToString();
                grid_Peso_altura_raza.Rows[i].Cells[2].Value = tabla.Rows[i]["Peso_minimo"].ToString();
                grid_Peso_altura_raza.Rows[i].Cells[3].Value = tabla.Rows[i]["Peso_maximo"].ToString();
                grid_Peso_altura_raza.Rows[i].Cells[4].Value = tabla.Rows[i]["Altura_media"].ToString();
            }
        }

        private void grid_Peso_altura_raza_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DENOMINACION = grid_Peso_altura_raza.CurrentRow.Cells["Denominacion"].Value.ToString();
            SEXO = grid_Peso_altura_raza.CurrentRow.Cells["Sexo"].Value.ToString();
        }

        private void grid_Peso_altura_raza_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            Mostrar_Peso_x_Altura_x_Raza mostrar_peso_altura = new Mostrar_Peso_x_Altura_x_Raza();
            mostrar_peso_altura.denominacion_recuperado = DENOMINACION;
            mostrar_peso_altura.sexo_recuperado = SEXO;
            mostrar_peso_altura.ShowDialog();
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            if (DENOMINACION != "")
            {
                Modificar_Peso_x_Altura_x_Raza modificar_peso_altura = new Modificar_Peso_x_Altura_x_Raza();
                modificar_peso_altura.denominacion_recuperado = DENOMINACION;
                modificar_peso_altura.sexo_recuperado = SEXO;
                modificar_peso_altura.ShowDialog();
            }
            else
            {
                MessageBox.Show("Por favor seleccione una Denominacion");
            }
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            Alta_Peso_x_Altura_x_Raza alta_peso = new Alta_Peso_x_Altura_x_Raza();
            alta_peso.contFEMENINO = true;
            alta_peso.contMASCULINO = true;
            alta_peso.ShowDialog();
        }
    }
}
