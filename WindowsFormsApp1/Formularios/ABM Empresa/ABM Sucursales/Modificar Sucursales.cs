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
    public partial class Modificar_Sucursales : Form
    {
        public string ID_sucursal_recuperado { get; set; }
        NE_Sucursal sucursal = new NE_Sucursal();
        Sabueso_Feliz_Validaciones sabueso = new Sabueso_Feliz_Validaciones();
        
        public Modificar_Sucursales()
        {
            InitializeComponent();
        }

        private void MostrarDatos(DataTable tabla)
        {
            txt_nombre_sucursal.Text = tabla.Rows[0]["Nombre_sucursal"].ToString();
            cmb_supervisor.SelectedValue = (int.Parse(tabla.Rows[0]["ID_supervisor"].ToString()));
            cmb_supervisor_suplente.SelectedValue = (int.Parse(tabla.Rows[0]["ID_supervisor_suplente"].ToString()));
            
        }

        private void Modificar_Sucursales_Load(object sender, EventArgs e)
        {
            cmb_supervisor.cargarCombo();
            cmb_supervisor_suplente.cargarCombo();
            MostrarDatos(sucursal.Recuperar_x_ID_Sucursal(Convert.ToInt32(ID_sucursal_recuperado)));
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            if (sabueso.Validar(this.Controls) == Sabueso_Feliz_Validaciones.Resultado.correcto)
            {
                //Convert.ToInt32(cmb_receta.SelectedValue.ToString())

                sucursal.Modificar_Sucursal(txt_nombre_sucursal.Text, Convert.ToInt32(cmb_supervisor.SelectedValue.ToString()), Convert.ToInt32(cmb_supervisor_suplente.SelectedValue.ToString()), Convert.ToInt32(ID_sucursal_recuperado));

                //sucursal.Modificar_Sucursal(txt_nombre_sucursal.Text,cmb_supervisor.SelectedIndex,
                //cmb_supervisor_suplente.SelectedIndex,Convert.ToInt32(ID_sucursal_recuperado));
                
                MessageBox.Show("Se modifico correctamente");
            }
            else
            {
                return;
            }
        }
    }
}
