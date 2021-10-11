using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1.Formularios.FORMULARIO_BASE
{
    public partial class Formulario_Base_ABM : Form
    {
        //Propiedad Publica de el label del titulo definida
        public string _titulo
        {
            get { return this.lbl_titulo.Text; }
            set { lbl_titulo.Text = value; }
        }
        
        public Formulario_Base_ABM()
        {
            InitializeComponent();
        }
    }
}
