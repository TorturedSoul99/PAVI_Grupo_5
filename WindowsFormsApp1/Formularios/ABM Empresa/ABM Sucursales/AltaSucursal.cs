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
using WindowsFormsApp1.Back_end;

namespace WindowsFormsApp1.Formularios.ABM_Empresa.ABM_Sucursales
{
    public partial class AltaSucursal : Form
    {
        //NE_Sucursal sucursal = new NE_Sucursal();

        public AltaSucursal()
        {
            InitializeComponent();
        }

        NE_Sucursal sucursal = new NE_Sucursal();
        Sabueso_Feliz_Validaciones sabueso = new Sabueso_Feliz_Validaciones();

        private void AltaSucursal_Load(object sender, EventArgs e)
        {
            cmb_supervisor.cargarCombo();
            cmb_supervisorSuplente.cargarCombo();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            //Convert.ToInt32(cmb_receta.SelectedValue.ToString())

            sucursal.AltaSucursal(txt_nombreSurcursal.Text, Convert.ToInt32(cmb_supervisor.SelectedValue.ToString()) , Convert.ToInt32(cmb_supervisorSuplente.SelectedValue.ToString()));
            //sucursal.AltaSucursal(txt_nombreSurcursal.Text, cmb_supervisor.SelectedIndex, cmb_supervisorSuplente.SelectedIndex);
            MessageBox.Show("Se cargo correctamente");

            
        }
    }
}
