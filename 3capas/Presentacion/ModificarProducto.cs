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
    public partial class ModificarProducto : Form
    {
        Empleado empleadoIniciado;
        public ModificarProducto(int Codigo, Empleado e)
        {
            this.empleadoIniciado = e;
            InitializeComponent();
            cargarProducto(Codigo);
        }
        public void cargarProducto(int Codigo)
        {
            SQLconexionNegocio co = new SQLconexionNegocio();
            Producto ProductoAmodificar = co.ObtenerProductoporCodigo(Codigo);

           


            txtCodigo.Text = ProductoAmodificar.codigo.ToString();
            txtNombreProducto.Text = ProductoAmodificar.NombreProducto;
            txtNombreCorto.Text = ProductoAmodificar.NombreCorto;
            txtPrecioCosto.Text = ProductoAmodificar.PrecioCosto.ToString();
            txtStock.Text = ProductoAmodificar.Stock.ToString();
            txtStockMinimo.Text = ProductoAmodificar.StockMinimo.ToString();
            txtPorcentajeGanancias.Text = ProductoAmodificar.PorcentajeGanancia.ToString();
         

        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            ABMProductos volver = new ABMProductos(empleadoIniciado);
            volver.Show();
            this.Hide();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
                try
                {
                    SQLconexionNegocio co = new SQLconexionNegocio();
                    co.ModificarUnproducto(int.Parse(txtCodigo.Text), txtNombreProducto.Text, txtNombreCorto.Text, float.Parse(txtPrecioCosto.Text), float.Parse(txtStock.Text), float.Parse(txtStockMinimo.Text), int.Parse(txtPorcentajeGanancias.Text));
                    MessageBox.Show("Producto modificado correctamente.");
                }
                catch (Exception a)
                {
                    MessageBox.Show(a.Message);
                }
            


        }
    }
}
