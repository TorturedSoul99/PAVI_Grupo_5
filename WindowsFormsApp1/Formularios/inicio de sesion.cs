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

namespace WindowsFormsApp1.Formularios
{
    public partial class frm_inicio_de_sesion : Form
    {
        public frm_inicio_de_sesion()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnIngresar_Click(object sender, EventArgs e)
        {
            if (txtUsuario.Text == "")
            {
                MessageBox.Show("Falta cargar el nombre del usuario", "Importante", MessageBoxButtons.OK, MessageBoxIcon.Stop);

                return;
            }
            if (txt_contraseña.Text == "")
            {
                MessageBox.Show("Falta cargar la contraseña del usuario", "Importante", MessageBoxButtons.OK, MessageBoxIcon.Stop);

                return;
            }

            NE_usuario usuario = new NE_usuario();

            if (usuario.Validar(txtUsuario.Text, txt_contraseña.Text) == NE_usuario.Validacion.correcta)
            {
                MessageBox.Show("Validacion Correcta", "", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                this.Close();

            }
            else
            {
                MessageBox.Show("Validacion Incorrecta", "", MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }
            
        }

        
    }
}
