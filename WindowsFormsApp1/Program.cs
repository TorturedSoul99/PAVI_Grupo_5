using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApp1.Formularios;
using WindowsFormsApp1.Formularios.ABM_Empresa.ABM_Empleado;
using WindowsFormsApp1.Formularios.Proceso_Consulta;
using WindowsFormsApp1.Formularios.ABM_InformacionCanes.ABM_Peso_x_Altura_x_Raza;
using WindowsFormsApp1.Formularios.Estadisticas.RazasXConsulta;

namespace WindowsFormsApp1
{
    static class Program
    {
        /// <summary>
        /// Punto de entrada principal para la aplicación.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new frmMenuPPAL());
            //Application.Run(new Proceso_Consulta_Para_Canes());
            //Application.Run(new ABM_Empleado());
        }
    }
}
