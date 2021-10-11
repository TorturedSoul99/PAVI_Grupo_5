using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1.Formularios.Proceso_receta
{
    public partial class Registrar_Receta : Form
    {
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
            // TODO: esta línea de código carga datos en la tabla 'bD3K3G05_2021DataSet9.receta' Puede moverla o quitarla según sea necesario.
            this.recetaTableAdapter.Fill(this.bD3K3G05_2021DataSet9.receta);

        }
    }
}
