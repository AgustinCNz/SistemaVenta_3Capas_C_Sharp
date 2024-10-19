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
    public partial class ABMProductos : Form
    {
        Empleado empleadoIniciado;
        public ABMProductos(Empleado e)
        {
            this.empleadoIniciado = e;
            InitializeComponent();
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            Login logeo = new Login();
            logeo.Show();
            this.empleadoIniciado = null;
            this.Hide();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            MenuUsuario menu = new MenuUsuario(empleadoIniciado);
            menu.Show();
            this.Hide();
        }

        private void ABMProductos_Load(object sender, EventArgs e)
        {
            SQLconexionNegocio con = new SQLconexionNegocio();
            dataGridView1.DataSource = con.CargarProducto();
        }

        private void btnAgregarProducto_Click(object sender, EventArgs e)
        {
            AgregarProducto agregar = new AgregarProducto(empleadoIniciado);
            agregar.Show();
            this.Hide();
        }

        private void btnEliminarProducto_Click(object sender, EventArgs e)
        {
            try
            {
                SQLconexionNegocio con = new SQLconexionNegocio();
                dataGridView1.DataSource = con.EliminarUnproducto(int.Parse(dataGridView1.SelectedCells[0].Value.ToString()));
                MessageBox.Show("El producto se elimino correctamente.");
            }
            catch (Exception s)
            {
                MessageBox.Show("Selecciona un codigo");
            }
        }

        private void btnModificarProducto_Click(object sender, EventArgs e)
        {
            ModificarProducto producto = new ModificarProducto(int.Parse(dataGridView1.SelectedCells[0].Value.ToString()), empleadoIniciado); 
            producto.Show();
            this.Hide();           
        }

        private void btnMovimientos_Click(object sender, EventArgs e)
        {
            ConsultarMovimientos movimiento = new ConsultarMovimientos(empleadoIniciado);
            movimiento.Show();
            this.Hide();
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
