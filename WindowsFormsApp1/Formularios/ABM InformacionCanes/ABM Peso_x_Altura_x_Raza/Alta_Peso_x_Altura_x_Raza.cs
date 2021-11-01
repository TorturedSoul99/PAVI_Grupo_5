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
        DataTable tabla = new DataTable();
        public bool contFEMENINO;
        public bool contMASCULINO;

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
            contFEMENINO = true;
            contMASCULINO = true;
            Sabueso_Feliz_Validaciones sabueso = new Sabueso_Feliz_Validaciones();
            NE_Peso_x_Altura_x_Raza peso_altura = new NE_Peso_x_Altura_x_Raza();

            if (sabueso.Validar(this.Controls) == Sabueso_Feliz_Validaciones.Resultado.correcto)
            {
                tabla = peso_altura.BuscarPeso_x_Altura_x_Raza(cmb_denominacion.SelectedValue.ToString());

                if (tabla.Rows.Count == 2)
                {
                    MessageBox.Show("Ya estan ingresados todas las variantes de la Raza "+ cmb_denominacion.SelectedValue.ToString());
                }
                else
                {
                    if (tabla.Rows.Count == 0)
                    {
                        peso_altura.AltaPeso_x_Altura_x_Raza(cmb_denominacion.SelectedValue.ToString(), Convert.ToInt32(cmb_sexo.SelectedValue.ToString()), Convert.ToInt32(txt_pesoMin.Text), Convert.ToInt32(txt_PesoMax.Text), Convert.ToInt32(txt_alturaMedia.Text));
                        MessageBox.Show("Registrado Correctamente");
                    }
                    else
                    {
                        if (tabla.Rows[0]["Nombre"].ToString() == "Femenino" && Convert.ToInt32(cmb_sexo.SelectedValue.ToString()) == 1)// || tabla.Rows[0]["Nombre"].ToString() == "Masculino")
                        {
                            //MessageBox.Show("Ya hay registrado una raza " + cmb_denominacion.SelectedValue.ToString() +" Con ese Sexo");
                            contFEMENINO = false;
                        }
                        if (tabla.Rows[0]["Nombre"].ToString() == "Masculino" && Convert.ToInt32(cmb_sexo.SelectedValue.ToString()) == 2)
                        {
                            //MessageBox.Show("Ya hay registrado una raza " + cmb_denominacion.SelectedValue.ToString() + " Con ese Sexo");
                            contMASCULINO = false;
                        }

                        if (contFEMENINO == true && contMASCULINO == true)
                        {
                            peso_altura.AltaPeso_x_Altura_x_Raza(cmb_denominacion.SelectedValue.ToString(), Convert.ToInt32(cmb_sexo.SelectedValue.ToString()), Convert.ToInt32(txt_pesoMin.Text), Convert.ToInt32(txt_PesoMax.Text), Convert.ToInt32(txt_alturaMedia.Text));
                            MessageBox.Show("Registrado Correctamente");
                        }
                        else
                        {
                            MessageBox.Show("Ya hay registrado una raza " + cmb_denominacion.SelectedValue.ToString() + " Con ese Sexo");
                        }
                    }
                    
                }
            }
            else
            {
                return;
            }
        }
    }
}
