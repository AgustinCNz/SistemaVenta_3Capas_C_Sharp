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
    public partial class AgregarProducto : Form
    {
        Empleado empleadoIniciado;
        public AgregarProducto(Empleado e)
        {
            this.empleadoIniciado = e;
            InitializeComponent();
        }

     

        private void btnAgregar_Click(object sender, EventArgs e)
        {
          
                try
                {
                    SQLconexionNegocio con = new SQLconexionNegocio();
                int Resultado = con.AgregarUnProducto(int.Parse(txtCodigo.Text), txtNombreProducto.Text, txtNombreCorto.Text, float.Parse(txtPrecioCosto.Text), float.Parse(txtStock.Text), float.Parse(txtStockMinimo.Text), int.Parse(txtPorcentajeGanancias.Text));
                    if (Resultado == 1)
                    {
                        MessageBox.Show("Producto agregado correctamente.");
                        txtCodigo.Clear();
                        txtNombreProducto.Clear();
                        txtNombreCorto.Clear();
                        txtPrecioCosto.Clear();
                        txtStock.Clear();
                        txtStockMinimo.Clear();
                        txtPorcentajeGanancias.Clear();                
                    }
              

                }
                catch (Exception a)
                {
                    MessageBox.Show(a.Message);
                }
            
        }

        private void btnVolverAtras_Click(object sender, EventArgs e)
        {
            ABMProductos volver = new ABMProductos(empleadoIniciado);
            volver.Show();
            this.Hide();
        }
    }
}
