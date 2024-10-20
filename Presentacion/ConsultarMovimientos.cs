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
    public partial class ConsultarMovimientos : Form
    {
        Empleado empleadoIniciado;
        public ConsultarMovimientos(Empleado e)
        {
            this.empleadoIniciado = e;
            InitializeComponent();
        }

        private void ConsultarMovimientos_Load(object sender, EventArgs e)
        {
            SQLconexionNegocio con = new SQLconexionNegocio();
            dataGridView1.DataSource = con.CargarMovimiento();
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            ABMProductos volver = new ABMProductos(empleadoIniciado);
            volver.Show();
            this.Hide();
        }

 
    }
}
