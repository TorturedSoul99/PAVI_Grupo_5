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

namespace WindowsFormsApp1.Formularios.ABM_InformacionCanes.ABM_Peso_x_Altura_x_Raza
{
    public partial class Alta_Peso_x_Altura_x_Raza : Form
    {
        
        
        public Alta_Peso_x_Altura_x_Raza()
        {
            InitializeComponent();
        }

        private void Alta_Peso_x_Altura_x_Raza_Load(object sender, EventArgs e)
        {
            cmb_denominacion.cargarCombo();
            cmb_sexo.cargarCombo();
        }

        private void btn_Agregar_Click(object sender, EventArgs e)
        {
            Sabueso_Feliz_Validaciones sabueso = new Sabueso_Feliz_Validaciones();
            NE_Peso_x_Altura_x_Raza peso_altura = new NE_Peso_x_Altura_x_Raza();

            //if (sabueso.Validar(this.Controls) == Sabueso_Feliz_Validaciones.Resultado.correcto)
            //{
            //    empleado.AltaEmpleado(txt_tipoDocumento.Text, Convert.ToInt32(txt_NroDocumento.Text), txt_NombreEmpleado.Text, txt_ApellidoEmpleado.Text, dtp_FechaNacimiento.Value.ToString(), dtp_FechaIngreso.Value.ToString(), cmb_Sucursales.SelectedIndex, txt_Matricula.Text);
            //}
            //else
            //{
            //    return;
            //}
        }
    }
}
