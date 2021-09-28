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

namespace WindowsFormsApp1.Formularios.ABM_Empresa.ABM_Empleado
{
    public partial class Modificar_Empleado : Form
    {
        NE_Empleados empleado = new NE_Empleados();
        Sabueso_Feliz_Validaciones sabueso = new Sabueso_Feliz_Validaciones();


        public string Id_empleado { get; set; }
        public Modificar_Empleado()
        {
            InitializeComponent();
        }

        private void Modificar_Empleado_Load(object sender, EventArgs e)
        {
            cmb_IDSucursal.cargarCombo();
            MostrarDatos(empleado.Recuperar_x_IDempleado(Convert.ToInt32(Id_empleado)));
        }




        private void MostrarDatos(DataTable tabla)
        {
            txt_tipoDoc.Text = tabla.Rows[0]["Tipo_documento"].ToString();
            txt_nroDoc.Text = tabla.Rows[0]["Nro_documento"].ToString();
            txt_Nombre.Text = tabla.Rows[0]["Nombre"].ToString();
            txt_Apellido.Text = tabla.Rows[0]["Apellido"].ToString();
            dtp_FechaNacimiento.Value = (DateTime)tabla.Rows[0]["Fecha_nacimiento"];
            dtp_FechaIngreso.Value = (DateTime)tabla.Rows[0]["Fecha_ingreso"];
            cmb_IDSucursal.SelectedValue = int.Parse(tabla.Rows[0]["ID_sucursal"].ToString());
            txt_Matricula.Text = tabla.Rows[0]["Matricula"].ToString();
        }

        private void btn_aceptar_Click(object sender, EventArgs e)
        {
            if (sabueso.Validar(this.Controls)==Sabueso_Feliz_Validaciones.Resultado.correcto)
            {
                empleado.Modificar_Empleado(txt_tipoDoc.Text, Convert.ToInt32(txt_nroDoc.Text),
                txt_Nombre.Text, txt_Apellido.Text, dtp_FechaNacimiento.Value.ToString(), dtp_FechaIngreso.Value.ToString(),
                Convert.ToInt32(cmb_IDSucursal.SelectedValue), txt_Matricula.Text, Convert.ToInt32(Id_empleado));
                MessageBox.Show("Se modifico correctamente");
            }
            else
            {
                return;
            }
        }
    }
}
