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
    public partial class VentaProducto : Form
    {
        private List<Producto> ListaVenta = new List<Producto>();
        private List<int> cantidades = new List<int>();
        Empleado empleadoIniciado;
        Cliente clienteIniciado;
        public VentaProducto(Empleado e)
        {
            this.empleadoIniciado = e;
            InitializeComponent();
        }

        private void VentaProducto_Load(object sender, EventArgs e)
        {
            SQLconexionNegocio con = new SQLconexionNegocio();
            dataGridViewVenta.DataSource = con.CargarProducto();
        }

        private void btnAñadir_Click(object sender, EventArgs e)
        {
            try
            {
                // Validar que el código de producto es válido
                if (!int.TryParse(txtProducto.Text, out int codigo))
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
                bool existe = ListaVenta.Any(prod => prod.codigo == p.codigo);
                if (existe)
                {
                    MessageBox.Show("Este producto ya fue cargado");
                    return;
                }
                
                if (p.Stock<cantidad)
                {
                    MessageBox.Show("No hay suficiente stock");
                    return;
                }
  

                // Agregar producto y cantidad a la lista
                ListaVenta.Add(p);
                cantidades.Add(cantidad);

                // Crear la visualización en el ListBox
                string item = $"{p.NombreProducto} -  Cantidad: {cantidad}";
                listFacturaVenta.Items.Add(item);


               
                txtCantidad.Clear();
                txtProducto.Clear();
               

            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al agregar la compra: {ex.Message}");
            }
        }

        private void btnVolverAtras_Click(object sender, EventArgs e)
        {
            MenuUsuario volver = new MenuUsuario(empleadoIniciado);
            volver.Show();
            this.Hide();
        }
       
        private void txtClienteLeave(object sender, EventArgs e)
        { 
            try
            {
                if (!txtCliente.Text.Equals(""))
                {

                    SQLconexionNegocio co = new SQLconexionNegocio();
                    Cliente c = co.BuscarCliente(int.Parse(txtCliente.Text));

                    if (c != null)
                    {
                        txtDescuento.Text = "" + c.Descuento;
                        clienteIniciado = c;
                    }
                    else
                    {
                        MessageBox.Show("Error al cargar el cliente");
                    }
                }


            }
            catch (SqlException ex)
            {
                MessageBox.Show($"Error al cargar el precio: {ex.Message}");
            }

        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            try
            {
                int index = 0;
                int i = 0;
                foreach (var pro in ListaVenta)
                {


                    if (pro.NombreProducto.Equals(listFacturaVenta.SelectedItem))
                    {
                        index = i;
                    }
                    i++;
                }

                ListaVenta.RemoveAt(index);
                cantidades.RemoveAt(index);
                listFacturaVenta.Items.Remove(listFacturaVenta.SelectedItem);

            }
            catch (Exception es)
            {
                MessageBox.Show("" + es);

            }
        }

        private void btnFinalizar_Click(object sender, EventArgs e)
        {
            try
            {
                // Crear instancia de la capa de negocio y conexión
                SQLconexionNegocio con = new SQLconexionNegocio();
                Comprobante comprobanteNegocio = new Comprobante();

            

                // Modificar los productos (actualizar stock)
                int i = 0;
                foreach (var pro in ListaVenta)
                {
                    float stockNuevo = pro.Stock - cantidades[i];
                    con.ModificarUnproducto(pro.codigo, pro.NombreProducto, pro.NombreCorto, pro.PrecioCosto, stockNuevo, pro.StockMinimo, pro.PorcentajeGanancia);
                    i++;
                }

                // Actualizar la tabla
                dataGridViewVenta.DataSource = con.CargarProducto();

                // Convertir cantidades a float si es necesario
                List<float> cantidadesFloat = cantidades.Select(c => (float)c).ToList();

                // Calcular el monto total
                float montoTotal = comprobanteNegocio.CalcularTotal(ListaVenta, cantidadesFloat);
                float montofinal = montoTotal - montoTotal * clienteIniciado.Descuento / 100;
                // Guardar el comprobante en la base de datos
                DateTime fechaHoy = DateTime.Now;
                con.AgregarUnmonto(1,0, fechaHoy, empleadoIniciado.ID, clienteIniciado.codigo, montoTotal);
                // Mostrar un mensaje de éxito
                string mensaje = $"Comprobante emitido:\n" +                 
                                 $"Fecha: {fechaHoy.ToString("MM/dd/yyyy")}\n" +
                                 $"Empleado: {empleadoIniciado.ID}\n" +
                                 $"Monto total: {montoTotal}\n" +
                                 $"Descuento: {clienteIniciado.Descuento}\n"+
                                 $"Monto Final: {montofinal}";

                MessageBox.Show(mensaje, "Información del Comprobante", MessageBoxButtons.OK, MessageBoxIcon.Information);

                // Limpiar los campos y listas
                txtCantidad.Clear();
                txtCliente.Clear();
                txtProducto.Clear();
                txtCantidad.Clear();
                txtDescuento.Clear();
              listFacturaVenta.Items.Clear();

                ListaVenta = new List<Producto>();
                cantidades = new List<int>();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message + "\n" + ex.StackTrace);
            }
        }
    }
}
