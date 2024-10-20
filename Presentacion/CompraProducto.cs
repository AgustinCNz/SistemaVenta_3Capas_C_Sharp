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
    public partial class CompraProducto : Form
    {

        private List<Producto> ListaProductos = new List<Producto>();
        private List<int> cantidades = new List<int>();

        


        Empleado empleadoIniciado;

        public CompraProducto(Empleado e)
        {
            this.empleadoIniciado = e;
            InitializeComponent();
        }

        private void CompraProducto_Load(object sender, EventArgs e)
        {
            SQLconexionNegocio con = new SQLconexionNegocio();
            dataGridView1.DataSource = con.CargarProducto();
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            MenuUsuario volver = new MenuUsuario(empleadoIniciado);
            volver.Show();
            this.Hide();
        }



         private void txtCodigoLeave(object sender, EventArgs e)
        {
            try
            {
                SQLconexionNegocio co = new SQLconexionNegocio();
                Producto p = co.ObtenerProductoporCodigo(int.Parse(txtCodigo.Text));
                txtPrecio.Text = ""+ p.PrecioCosto;
            }
            catch (SqlException ex)
            {
                MessageBox.Show($"Error al cargar el precio: {ex.Message}");
            }

        }

     /*   private void btnComprar_Click(object sender, EventArgs e)
        {
            try
            {
                SQLconexionNegocio co = new SQLconexionNegocio();
                Producto p = co.ObtenerProductoporCodigo(int.Parse(txtCodigo.Text));

                bool existe = false;

                foreach (var prod in ListaProductos)
                {
                    if (prod.codigo == p.codigo)
                    {
                        existe = true;
                        break;  
                    }
                }

                if (existe)
                {
                    MessageBox.Show("Este producto ya fue cargado");
                }
                else
                {
                    float Precio = float.Parse(txtPrecio.Text);
                    int Cantidad = int.Parse(txtCantidad.Text);
                    cantidades.Add(Cantidad);
                    lstCompra.Items.Add(p.NombreProducto);
                    ListaProductos.Add(p);
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message );
            }

        }*/

       

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            try
            {
            int index=0;
            int i = 0;
            foreach (var pro in ListaProductos)
                {

                
                if (pro.NombreProducto.Equals(lstCompra.SelectedItem))
                {
                    index = i;
                }
                i++;
            }

                ListaProductos.RemoveAt(index);
                cantidades.RemoveAt(index);
                lstCompra.Items.Remove(lstCompra.SelectedItem);

            }
            catch (Exception es){
                MessageBox.Show(""+es);

            }
        }

        public float calcularPrecioTotal() {
            int i = 0;
            float  total = 0;
            foreach (var pro in ListaProductos)
            {
                total = total + pro.PrecioCosto * cantidades[i];   
                i++;
            }
            return total;
        }

        /* private void btnEmitirComprobante_Click(object sender, EventArgs e)
         {           
                 try
                 {
                     SQLconexionNegocio con = new SQLconexionNegocio();

                     int i = 0;
                     foreach (var pro in ListaProductos)
                     {
                        float stocknuevo = pro.Stock + cantidades[i];      
                        con.ModificarUnproducto(pro.codigo, pro.NombreProducto, pro.NombreCorto, pro.PrecioCosto, stocknuevo, pro.StockMinimo, pro.PorcentajeGanancia);
                     i = i + 1;
                     }
                     float stoc1 = ListaProductos[0].Stock + cantidades[0];
                     con.ModificarUnproducto(ListaProductos[0].codigo, ListaProductos[0].NombreProducto, ListaProductos[0].NombreCorto, ListaProductos[0].PrecioCosto, stoc1, ListaProductos[0].StockMinimo, ListaProductos[0].PorcentajeGanancia);
                     dataGridView1.DataSource = con.CargarProducto();                   

                     MessageBox.Show("Productos actualizados");

                     DateTime fechaHoy = DateTime.Now;
                     string fechahoybuenformado = fechaHoy.ToString("yyyy-MM-dd");
                 string projectDirectory = Directory.GetParent(Environment.CurrentDirectory).Parent.Parent.FullName;
                 string path = Path.Combine(projectDirectory, "log.txt");
                 File.AppendAllText(path, $"FECHA HOY: {"" + fechahoybuenformado}\n");

                 con.AgregarUnmonto(2, int.Parse(txtFactura.Text), DateTime.Parse(fechahoybuenformado), empleadoIniciado.ID, 0, calcularPrecioTotal());

                     string mensaje = $"Comprobante emitido:\n" +
                          $"Tipo: {2}\n" +
                          $"Fecha: {DateTime.Now}\n" +
                          $"Empleado: {empleadoIniciado.ID}\n" +
                          $"Monto total: {calcularPrecioTotal():C}";

                     MessageBox.Show(mensaje, "Información del Comprobante", MessageBoxButtons.OK, MessageBoxIcon.Information);
                     txtCantidad.Text = "";
                     txtCodigo.Text = "";
                     txtFactura.Text = "";
                     txtPrecio.Text = "";
                     lstCompra.Items.Clear();
                     ListaProductos = null;
                     cantidades = null;

                }
                 catch (Exception a)
                 {
                     MessageBox.Show(a.Message);
                 }


         }
        */





        /********************************************************************************/

        /******************************************************************************************/



        private void btnComprar_Click(object sender, EventArgs e)
        {
            try
            {
                // Validar que el código de producto es válido
                if (!int.TryParse(txtCodigo.Text, out int codigo))
                {
                    MessageBox.Show("El código de producto no es válido.");
                    return;
                }

                // Obtener el producto
                SQLconexionNegocio co = new SQLconexionNegocio();
                Producto p = co.ObtenerProductoporCodigo(codigo);
                if (p == null)
                {
                    MessageBox.Show("Producto no encontrado.");
                    return;
                }

                // Validar cantidad
                if (!int.TryParse(txtCantidad.Text, out int cantidad) || cantidad <= 0)
                {
                    MessageBox.Show("La cantidad debe ser un número positivo.");
                    return;
                }

                // Verificar si ya fue agregado
                bool existe = ListaProductos.Any(prod => prod.codigo == p.codigo);
                if (existe)
                {
                    MessageBox.Show("Este producto ya fue cargado");
                    return;
                }

                // Obtener el precio
                if (!float.TryParse(txtPrecio.Text, out float precio))
                {
                    MessageBox.Show("El precio no es válido.");
                    return;
                }

                // Agregar producto y cantidad a la lista
                ListaProductos.Add(p);
                cantidades.Add(cantidad);

                // Crear la visualización en el ListBox
                string item = $"{p.NombreProducto} - Precio: {precio} - Cantidad: {cantidad} - Factura: {txtNumeroFactura.Text}";
                lstCompra.Items.Add(item);


                txtCodigo.Clear();
                txtCantidad.Clear();
                txtPrecio.Clear();

            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al agregar la compra: {ex.Message}");
            }
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnVolverAtras_Click(object sender, EventArgs e)
        {
            MenuUsuario volverMenuUsuario = new MenuUsuario(empleadoIniciado);
            volverMenuUsuario.Show();
            this.Hide();
        }
    }
}
