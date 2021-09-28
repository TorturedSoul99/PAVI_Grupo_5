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
    public partial class Modificar_receta : Form
    {
        NE_receta receta = new NE_receta();
        public int _id { get; set; }
        public int _idSucursal { get; set; }
        public Modificar_receta()
        {
            InitializeComponent();
        }

        private void Modificar_receta_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'bD3K3G05_2021DataSet6.sucursal' Puede moverla o quitarla según sea necesario.
            this.sucursalTableAdapter1.Fill(this.bD3K3G05_2021DataSet6.sucursal);
            // TODO: esta línea de código carga datos en la tabla 'bD3K3G05_2021DataSet5.sucursal' Puede moverla o quitarla según sea necesario.
            //this.sucursalTableAdapter.Fill(this.bD3K3G05_2021DataSet5.sucursal);
            cmb_sucursal.Text = _idSucursal.ToString();
        }

        private void btn_modificar_Click(object sender, EventArgs e)
        {
            int nuevaSucu = int.Parse(cmb_sucursal.Text.ToString());
            receta.Modificar_receta(_idSucursal, nuevaSucu);
            this.Close();
        }
    }
}
