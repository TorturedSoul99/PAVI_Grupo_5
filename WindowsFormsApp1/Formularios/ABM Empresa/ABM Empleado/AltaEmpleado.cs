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

namespace WindowsFormsApp1.Formularios.ABM_Empresa.ABM_Empleado
{
    public partial class AltaEmpleado : Form
    {
        public AltaEmpleado()
        {
            InitializeComponent();
        }

        private void lblDiagnostico_Click(object sender, EventArgs e)
        {

        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            Sabueso_Feliz_Validaciones sabueso = new Sabueso_Feliz_Validaciones();
            NE_Empleados empleado = new NE_Empleados();

            if (sabueso.Validar(this.Controls) == Sabueso_Feliz_Validaciones.Resultado.correcto)
            {
                empleado.AltaEmpleado(txt_tipoDocumento.Text,Convert.ToInt32(txt_NroDocumento.Text),txt_NombreEmpleado.Text,txt_ApellidoEmpleado.Text,dtp_FechaNacimiento.Value.ToString(),dtp_FechaIngreso.Value.ToString(),cmb_Sucursales.SelectedIndex,txt_Matricula.Text);
            }
            else
            {
                return;
            }
        }

        private void AltaEmpleado_Load(object sender, EventArgs e)
        {
            cmb_Sucursales.cargarCombo();
        }
    }
}
