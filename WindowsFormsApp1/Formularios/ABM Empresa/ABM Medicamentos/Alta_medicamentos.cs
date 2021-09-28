using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApp1.Back_end;
using WindowsFormsApp1.Negocio;

namespace WindowsFormsApp1.Formularios.ABM_Empresa.ABM_Medicamentos
{
    public partial class Alta_medicamentos : Form
    {
        NE_Medicamento medicamento = new NE_Medicamento();
        public Alta_medicamentos()
        {
            InitializeComponent();
        }

        

        private void Alta_medicamentos_Load(object sender, EventArgs e)
        {
            cmb_laboratorio_med.cargarCombo();
            cmb_sucursal_med.cargarCombo();
        }

        private void btn_agregar_Click(object sender, EventArgs e)
        {
            medicamento.AltaMedicamento(txt_nombre_medicamento.Text, cmb_laboratorio_med.SelectedIndex, dtp_fechaCompra.Value.ToString(), cmb_sucursal_med.SelectedIndex);          
        }
    }
}
