using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1.Formularios
{
    public partial class inicio_de_sesion : Form
    {
        public inicio_de_sesion()
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
            }
        }
    }
}
