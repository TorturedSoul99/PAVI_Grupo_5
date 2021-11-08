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

namespace WindowsFormsApp1.Formularios.ABM_Empresa.ABM_Medicamentos
{
    public partial class Modificar_medicamentos : Form
    {

        public string ID_MEDICAMENTO { get; set; }
        NE_Medicamento medicamento = new NE_Medicamento();

        public Modificar_medicamentos()
        {
            InitializeComponent();
        }

        private void Modificar_medicamentos_Load(object sender, EventArgs e)
        {
            cmb_sucu_medicamento.cargarCombo();
            cmb_lab_medic.cargarCombo();
            MostrarDatos(medicamento.recuperar_por_id_medicamento(Convert.ToInt32(ID_MEDICAMENTO)));
        }
        private void MostrarDatos(DataTable tabla)
        {            
            
            txt_nombre_medicamento.Text = tabla.Rows[0]["Nombre"].ToString();
            cmb_lab_medic.SelectedValue = (int.Parse(tabla.Rows[0]["Laboratorio"].ToString()));
            dtp_fecha_compra.Value = (DateTime)tabla.Rows[0]["FechaUltimaCompra"];
            cmb_sucu_medicamento.SelectedValue = (int.Parse(tabla.Rows[0]["ID_Sucursal"].ToString()));

        }

        private void btn_agregar_Click(object sender, EventArgs e)
        {
            //Convert.ToInt32(cmb_receta.SelectedValue.ToString())
            medicamento.Modificar_medicamento(Convert.ToInt32(ID_MEDICAMENTO), txt_nombre_medicamento.Text, Convert.ToInt32(cmb_lab_medic.SelectedValue.ToString()), dtp_fecha_compra.Value.ToString(), Convert.ToInt32(cmb_sucu_medicamento.SelectedValue.ToString()));

            //medicamento.Modificar_medicamento(Convert.ToInt32(ID_MEDICAMENTO), txt_nombre_medicamento.Text, cmb_lab_medic.SelectedIndex, dtp_fecha_compra.Value.ToString(), cmb_sucu_medicamento.SelectedIndex);
            MessageBox.Show("Se modifico correctamente");
        }
    }
}
