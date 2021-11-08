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

namespace WindowsFormsApp1.Formularios.ABM_Empresa.ABM_Sucursales
{
    public partial class Mostrar_sucursal : Form
    {
        
        public string Id_recuperado_sucursal { get; set; }
        NE_Sucursal sucursal = new NE_Sucursal();
        
        public Mostrar_sucursal()
        {
            InitializeComponent();
        }

        private void MostrarDatos(DataTable tabla)
        {
            txt_nombre.Text = tabla.Rows[0]["Nombre_sucursal"].ToString();
            txt_supervisor.Text = tabla.Rows[0]["ID_supervisor"].ToString();
            txt_supervisor_suplente.Text = tabla.Rows[0]["ID_supervisor_suplente"].ToString();
        }

        private void Mostrar_sucursal_Load(object sender, EventArgs e)
        {
            MostrarDatos(sucursal.Recuperar_x_ID_Sucursal(Convert.ToInt32(Id_recuperado_sucursal)));
        }

        private void btn_eliminar_Click(object sender, EventArgs e)
        {
            sucursal.EliminarSucursal(Convert.ToInt32(Id_recuperado_sucursal));
            MessageBox.Show("Se elimino la sucursal seleccionada");
        }
    }
}
