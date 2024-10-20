using PP3capas;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Presentacion
{
    public partial class ABMempleados : Form
    {
        Empleado empleadoIniciado;
        public ABMempleados(Empleado e)
        {
            this.empleadoIniciado = e;
            InitializeComponent();
       
        }

        private void ABMempleados_Load(object sender, EventArgs e)
        {
            SQLconexionNegocio con = new SQLconexionNegocio();
            dataGridView1.DataSource = con.CargarTablaEmpleados();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            SQLconexionNegocio con = new SQLconexionNegocio();
            if (empleadoIniciado.ID== int.Parse(dataGridView1.SelectedCells[0].Value.ToString()))
            {
                MessageBox.Show("NO SE PUEDE ELIMINAR A USTED MISMO");
            }
            else
            {
               dataGridView1.DataSource = con.EliminarUnempleado(int.Parse(dataGridView1.SelectedCells[0].Value.ToString()));
                MessageBox.Show("Se elimino el empleado");
            }
            
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            Login login = new Login();
            login.Show();
            this.empleadoIniciado = null;
            this.Hide();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            MenuUsuario menu = new MenuUsuario(empleadoIniciado);
            menu.Show();
            this.Hide();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            Formulario formulario = new Formulario(empleadoIniciado);
            formulario.Show();
            this.Hide();
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            try
            {
                Modificar modificar = new Modificar(int.Parse(dataGridView1.SelectedCells[0].Value.ToString()), empleadoIniciado);
                
                modificar.Show();
                this.Hide();

            }
            catch
            {
                MessageBox.Show("Seleccionar un Id de empleado valido");
            }
             
        }

       
    }
}
