using PP3capas;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Presentacion
{
    public partial class Formulario : Form
    {
        Empleado empleadoIniciado;
        public Formulario(Empleado e)
        {
            this.empleadoIniciado = e;
            InitializeComponent();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            
            if (txtClave.Text == txtClave2.Text) {
                try
                {
                    SQLconexionNegocio con = new SQLconexionNegocio();
                    int Resultado = con.AgregarUnempleado(int.Parse(txtDNI.Text), txtApellido.Text, txtNombre.Text, txtTelefono.Text, DateTime.Parse(txtFechaNac.Text), txtUsuario.Text, txtClave.Text, txtPuesto.Text);
                    if (Resultado == 1)
                    {
                        MessageBox.Show("Empleado agregado correctamente");
                        txtDNI.Clear();
                        txtApellido.Clear();
                        txtNombre.Clear();
                        txtTelefono.Clear();
                        txtFechaNac.Clear();
                        txtUsuario.Clear();
                        txtClave.Clear();
                        txtClave2.Clear();
                        txtPuesto.Clear();
                    }
                    else
                    {
                        MessageBox.Show("Datos incorrectos, intente otra vez");
                    }

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

        private void btnVolver_Click(object sender, EventArgs e)
        {
            ABMempleados empleado = new ABMempleados(empleadoIniciado);
            empleado.Show();
            this.Hide();
        }
    }
}
