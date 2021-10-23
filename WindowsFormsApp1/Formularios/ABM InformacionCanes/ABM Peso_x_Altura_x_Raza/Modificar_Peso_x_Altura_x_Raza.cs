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

namespace WindowsFormsApp1.Formularios.ABM_InformacionCanes
{
    public partial class Modificar_Peso_x_Altura_x_Raza : Form
    {
        int SEXO = 0;
        public bool contFEMENINO;
        public bool contMASCULINO;


        public string denominacion_recuperado { get; set; }
        public string sexo_recuperado { get; set; }
        NE_Peso_x_Altura_x_Raza peso_altura = new NE_Peso_x_Altura_x_Raza();
        Sabueso_Feliz_Validaciones sabueso = new Sabueso_Feliz_Validaciones();
        DataTable tabla = new DataTable();

        public Modificar_Peso_x_Altura_x_Raza()
        {
            InitializeComponent();
        }

        private void btn_Modificar_Click(object sender, EventArgs e)
        {
            contFEMENINO = true;
            contMASCULINO = true;


            if (sabueso.Validar(this.Controls) == Sabueso_Feliz_Validaciones.Resultado.correcto)
            {
                tabla = peso_altura.BuscarPeso_x_Altura_x_Raza(cmb_denominacion.SelectedValue.ToString());

                if (tabla.Rows.Count == 2)
                {
                    MessageBox.Show("Ya estan ingresados todas las variantes de la Raza " + cmb_denominacion.SelectedValue.ToString());
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
                        peso_altura.Modificar_Peso_altura_x_Raza(denominacion_recuperado, 
                                                                Convert.ToInt32(cmb_sexo.SelectedValue.ToString()), 
                                                                Convert.ToInt32(txt_pesoMin.Text), 
                                                                Convert.ToInt32(txt_PesoMax.Text), 
                                                                Convert.ToInt32(txt_alturaMedia.Text),
                                                                denominacion_recuperado,
                                                                SEXO);
                        MessageBox.Show("Modificado Correctamente");
                    }
                    else
                    {
                        MessageBox.Show("Ya hay registrado una raza " + cmb_denominacion.SelectedValue.ToString() + " Con ese Sexo");
                    }
                }
            }
            else
            {
                return;
            }
        }



        private void MostrarDatos(DataTable tabla)
        {
            cmb_denominacion.SelectedValue = tabla.Rows[0]["Denominacion"].ToString();
            cmb_sexo.SelectedValue = (int.Parse(tabla.Rows[0]["Sexo"].ToString()));
            txt_pesoMin.Text = tabla.Rows[0]["Peso_minimo"].ToString();
            txt_PesoMax.Text = tabla.Rows[0]["Peso_maximo"].ToString();
            txt_alturaMedia.Text = tabla.Rows[0]["Altura_media"].ToString();
        }

        private void Modificar_Peso_x_Altura_x_Raza_Load(object sender, EventArgs e)
        {
            if (sexo_recuperado == "Femenino")
            {
                SEXO = 1;
            }
            else
            {
                SEXO = 2;
            }
            
            
            cmb_denominacion.cargarCombo();
            cmb_sexo.cargarCombo();
            MostrarDatos(peso_altura.BuscarTodosLOS_DATOS_DE_Peso_x_Altura_x_Raza(denominacion_recuperado,SEXO));
        }
    }
}
