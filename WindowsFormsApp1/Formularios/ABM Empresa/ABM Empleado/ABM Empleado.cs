using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WindowsFormsApp1.Formularios.ABM_Empresa.ABM_Empleado;
using WindowsFormsApp1.Negocio;


namespace WindowsFormsApp1.Formularios.ABM_Empresa.ABM_Empleado
{
    public partial class ABM_Empleado : Form
    {
        
        public ABM_Empleado()
        {
            InitializeComponent();
        }
        NE_Empleados empleado = new NE_Empleados();
        DataTable tabla = new DataTable();

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            AltaEmpleado altaempleado = new AltaEmpleado();
            altaempleado.ShowDialog();

        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            Modificar_Empleado modificarE = new Modificar_Empleado();
            modificarE.ShowDialog();
        }

        private void btnConsultarNombre_Click(object sender, EventArgs e)
        {
            if (chkBuscarTodos.Checked == true)
            {
                tabla = empleado.BuscarTodosEmpleados();
                cargar_grilla(tabla);
            }
            else
            {
                tabla = empleado.BuscarEmpleadoNombre(txt_nombre.Text);
                cargar_grilla(tabla);
                if (tabla.Rows.Count == 0)
                {
                    MessageBox.Show("No se encontro a ningun empleado con ese nombre, vuelva a intentarlo");
                }
            }
        }

        private void btnConsultaID_Click(object sender, EventArgs e)
        {
            if (chkBuscarTodos.Checked == true)
            {
                tabla = empleado.BuscarTodosEmpleados();
                cargar_grilla(tabla);
            }
            else
            {
                if (txt_IDEmpleado.Text == "")
                {
                    MessageBox.Show("Porfavor Ingrese un numero de ID del empleado");
                }
                else 
                {
                    tabla = empleado.BuscarEmpleadoID(Convert.ToInt32(txt_IDEmpleado.Text));
                    cargar_grilla(tabla);
                    if (tabla.Rows.Count == 0)
                    {
                        MessageBox.Show("No se encontro a ningun empleado con ese numero de ID, vuelva a intentarlo");
                    }
                }
            }
        }

        private void btnIDSucursal_Click(object sender, EventArgs e)
        {
            if (chkBuscarTodos.Checked == true)
            {
                tabla = empleado.BuscarTodosEmpleados();
                cargar_grilla(tabla);
            }
            else
            {
                if (txt_IDSucursal.Text == "")
                {
                    MessageBox.Show("Porfavor Ingrese un numero de ID de sucursal");
                }
                else
                {
                    tabla = empleado.BuscarEmpleadoIDSucursal(Convert.ToInt32(txt_IDSucursal.Text));
                    cargar_grilla(tabla);
                    if (tabla.Rows.Count == 0)
                    {
                        MessageBox.Show("No se encontro a ningun empleado con ese numero de ID de Sucursal, vuelva a intentarlo");
                    }
                }
            }
        }

        private void cargar_grilla(DataTable tabla)
        {
            grid_empleados.Rows.Clear();
            for (int i = 0; i < tabla.Rows.Count; i++)
            {
                grid_empleados.Rows.Add();
                grid_empleados.Rows[i].Cells[0].Value = tabla.Rows[i]["ID_empleado"].ToString();
                grid_empleados.Rows[i].Cells[1].Value = tabla.Rows[i]["Tipo_documento"].ToString();
                grid_empleados.Rows[i].Cells[2].Value = tabla.Rows[i]["Nro_documento"].ToString();
                grid_empleados.Rows[i].Cells[3].Value = tabla.Rows[i]["Nombre"].ToString();
                grid_empleados.Rows[i].Cells[4].Value = tabla.Rows[i]["Apellido"].ToString();
                grid_empleados.Rows[i].Cells[5].Value = tabla.Rows[i]["Fecha_nacimiento"].ToString();
                grid_empleados.Rows[i].Cells[6].Value = tabla.Rows[i]["Fecha_ingreso"].ToString();
                grid_empleados.Rows[i].Cells[7].Value = tabla.Rows[i]["ID_sucursal"].ToString();
                grid_empleados.Rows[i].Cells[8].Value = tabla.Rows[i]["Matricula"].ToString();

            }
        }

        
    }
}
