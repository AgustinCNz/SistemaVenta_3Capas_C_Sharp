using PP3capas;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace Presentacion
{
    public partial class VentaProducto : Form
    {

        Empleado empleadoIniciado;
        public VentaProducto(Empleado e)
        {
            InitializeComponent();
            this.empleadoIniciado = e;
        }

        private void VentaProducto_Load(object sender, EventArgs e)
        {
            SQLconexionNegocio con = new SQLconexionNegocio();
            dataGridViewVenta.DataSource = con.CargarProducto();
        }

        private void btnVolverAtras_Click(object sender, EventArgs e)
        {
            MenuUsuario volverMenuUsuario = new MenuUsuario(empleadoIniciado);
            volverMenuUsuario.Show();
            this.Hide();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
