using PP3capas;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Presentacion
{
    public partial class Modificar : Form
    {
        Empleado empleadoIniciado;
        public Modificar(int ID, Empleado e)
        {
            this.empleadoIniciado = e;
            InitializeComponent();
            cmbModEmpleado.Items.Add("Administrador");
            cmbModEmpleado.Items.Add("Auditor");
            cmbModEmpleado.Items.Add("Empleado");

            cargarDatos(ID);
        }

        public void cargarDatos(int ID)
        {
            SQLconexionNegocio co = new SQLconexionNegocio();
            Empleado EmpleadoAModificar=co.ObtenerUsuarioPorId(ID);
            if (EmpleadoAModificar != null)
            {
                try
                {

                    DateTime solofe = EmpleadoAModificar.FechaNac.Date;


                    txtDNI.Text = EmpleadoAModificar.DNI.ToString();
                    txtApellido.Text = EmpleadoAModificar.Apellido;
                    txtNombre.Text = EmpleadoAModificar.Nombre;
                    txtTelefono.Text = EmpleadoAModificar.Telefono;
                    txtFechaNac.Text = solofe.ToString("dd-MM-yyyy");
                    txtUsuario.Text = EmpleadoAModificar.Usuario;
                    txtClave.Text = EmpleadoAModificar.Clave;
                    if (EmpleadoAModificar.Puesto.Equals("Administrador"))
                    {
                        cmbModEmpleado.SelectedIndex = 0;
                    }
                    if (EmpleadoAModificar.Puesto.Equals("Auditor"))
                    {
                        cmbModEmpleado.SelectedIndex = 1;
                    }
                    if (EmpleadoAModificar.Puesto.Equals("Empleado"))
                    {
                        cmbModEmpleado.SelectedIndex = 2;
                    }
                  
                }
                catch (Exception e)
                {
                    MessageBox.Show("Selecciona una ID");
                }
            }
            else
            {

                MessageBox.Show("Hola");
                
            }
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            ABMempleados volverEmpleado = new ABMempleados(empleadoIniciado);
            volverEmpleado.Show();
            this.Hide();
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            if (txtClave.Text == txtclave2.Text)
            {
                try
                {
                    SQLconexionNegocio co = new SQLconexionNegocio();
                    string puestoModEmpleado = "" + cmbModEmpleado.SelectedItem;
                    co.ModificarUnempleado(int.Parse(txtDNI.Text), txtApellido.Text, txtNombre.Text, txtTelefono.Text, DateTime.Parse(txtFechaNac.Text), txtUsuario.Text, txtClave.Text, puestoModEmpleado);
                    MessageBox.Show("Empleado modificado correctamente");

                }
              catch (Exception a)
                {
                    MessageBox.Show(a.Message);
                }
            }
            else
            {
                MessageBox.Show("Las contraseñas deben coincidir");
            }
        
        }

        private void lblUsuario_Click(object sender, EventArgs e)
        {

        }

        private void txtUsuario_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
