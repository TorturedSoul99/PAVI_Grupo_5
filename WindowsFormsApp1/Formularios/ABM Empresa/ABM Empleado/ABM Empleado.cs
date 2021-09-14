using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApp1.Formularios.ABM_Empresa.ABM_Empleado;


namespace WindowsFormsApp1.Formularios.ABM_Empresa.ABM_Empleado
{
    public partial class ABM_Empleado : Form
    {
        public ABM_Empleado()
        {
            InitializeComponent();
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            AltaEmpleado altaempleado = new AltaEmpleado();
            altaempleado.ShowDialog();

        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            Modificar_Empleado modificarE = new Modificar_Empleado();
            modificarE.ShowDialog();
        }
    }
}
