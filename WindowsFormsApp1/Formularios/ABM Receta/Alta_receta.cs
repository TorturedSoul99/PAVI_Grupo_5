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

namespace WindowsFormsApp1.Formularios.ABM_Receta
{
    public partial class Alta_receta : Form
    {
        NE_receta receta = new NE_receta();
        public Alta_receta()
        {
            InitializeComponent();
        }

        private void Alta_receta_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'bD3K3G05_2021DataSet5.sucursal' Puede moverla o quitarla según sea necesario.
            this.sucursalTableAdapter.Fill(this.bD3K3G05_2021DataSet5.sucursal);

        }

        private void btn_agregar_Click(object sender, EventArgs e)
        {
            //    int id_sucu = Int32.Parse(comboBox1.Text);
        //  bool agregar = receta.Alta_receta(id_sucu);
         //   if (agregar)
           // {
            //    this.Close();
            //}
            //else
            //{
             //   MessageBox.Show("Ya existe una receta para esa sucursal", "Error al cargar la receta", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            //}
        }
    }
}
