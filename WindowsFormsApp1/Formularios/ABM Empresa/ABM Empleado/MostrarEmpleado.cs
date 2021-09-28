using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data;
using WindowsFormsApp1.Negocio;

namespace WindowsFormsApp1.Formularios.ABM_Empresa.ABM_Empleado
{
    public partial class MostrarEmpleado : Form
    {
        public string id_empleado { get; set; }
        NE_Empleados empleado = new NE_Empleados();
        
        public MostrarEmpleado()
        {
            InitializeComponent();
        }

        private void MostrarDatos(DataTable tabla)
        {
            txt_tipoDoc.Text = tabla.Rows[0]["Tipo_documento"].ToString();
            txt_nroDoc.Text = tabla.Rows[0]["Nro_documento"].ToString();
            txt_Nombre.Text = tabla.Rows[0]["Nombre"].ToString();
            txt_Apellido.Text = tabla.Rows[0]["Apellido"].ToString();
            dtp_FechaNacimiento.Value = (DateTime)tabla.Rows[0]["Fecha_nacimiento"];
            dtp_FechaIngreso.Value = (DateTime)tabla.Rows[0]["Fecha_ingreso"];
            txt_Sucursal.Text = tabla.Rows[0]["ID_sucursal"].ToString();
            txt_Matricula.Text = tabla.Rows[0]["Matricula"].ToString();
        }

        private void MostrarEmpleado_Load(object sender, EventArgs e)
        {
            MostrarDatos(empleado.Recuperar_x_IDempleado(Convert.ToInt32(id_empleado)));
        }

        private void btn_eliminar_Click(object sender, EventArgs e)
        {
            empleado.EliminarEmpleado(Convert.ToInt32(id_empleado));
            MessageBox.Show("Se elimino el Empleado");
        }
    }
}
