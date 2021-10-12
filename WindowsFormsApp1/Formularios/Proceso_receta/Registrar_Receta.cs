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

namespace WindowsFormsApp1.Formularios.Proceso_receta
{
    public partial class Registrar_Receta : Form
    {
        NE_receta rece = new NE_receta();
        NE_Sucursal sucu = new NE_Sucursal();
        NE_Medicamento med = new NE_Medicamento();
        NE_MedicamentoXReceta medxrec = new NE_MedicamentoXReceta();
        public Registrar_Receta()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Registrar_Receta_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'bD3K3G05_2021DataSet12.medicamentos' Puede moverla o quitarla según sea necesario.
            this.medicamentosTableAdapter.Fill(this.bD3K3G05_2021DataSet12.medicamentos);
            // TODO: esta línea de código carga datos en la tabla 'bD3K3G05_2021DataSet11.sucursal' Puede moverla o quitarla según sea necesario.
            this.sucursalTableAdapter.Fill(this.bD3K3G05_2021DataSet11.sucursal);
            // TODO: esta línea de código carga datos en la tabla 'bD3K3G05_2021DataSet10.receta' Puede moverla o quitarla según sea necesario.
            this.recetaTableAdapter1.Fill(this.bD3K3G05_2021DataSet10.receta);
            DataTable receta = rece.CargarReceta();
            dgvReceta2.Cargar(receta);
        }

        private void dataGridView011_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            DataTable tabla = new DataTable();


            if (cbID.SelectedItem != null)
            {
                tabla = rece.BuscarReceta2(Int32.Parse(cbID.Text));
                dgvReceta2.Cargar(tabla);
            }
            else
            {
                MessageBox.Show("No se selecciono un id de receta, Porfavor seleccione uno");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string nombre_sucu = comboBox1.Text;
            string nombre_medic = comboBox2.Text;
            string periodicidad = textBox2.Text;
            string dosis = textBox1.Text;
            DataTable tabla = new DataTable();
            DataTable tabla2 = new DataTable();
            tabla = sucu.BuscarSucursal(nombre_sucu);
            int id_sucu = int.Parse(tabla.Rows[0][0].ToString());
            tabla2 = med.BuscarMedicamento(nombre_medic);
            int id_med = int.Parse(tabla2.Rows[0][0].ToString());
            rece.Alta_receta(id_sucu);
            int Id_Receta = rece.BuscarIDUltimaReceta();
            medxrec.Alta_MedicamentoXReceta(id_med, Id_Receta, periodicidad, dosis);
            
            DataTable receta = rece.CargarReceta();
            dgvReceta2.Cargar(receta);
        }
    }
}
