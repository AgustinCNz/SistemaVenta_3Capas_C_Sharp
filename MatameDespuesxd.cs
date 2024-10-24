/*using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PARCIAL
{
    public partial class ModuloVenta : Form
    {
        // Variable para almacenar el total acumulado
        private decimal totalAcumulado = 0;

        private List<(string nombreProducto, decimal cantidad, decimal precioUnitario, decimal total)> productosComprados = new List<(string, decimal, decimal, decimal)>();
       
        public ModuloVenta()
        {
            InitializeComponent();
            txtCliente.Leave += new EventHandler(txtCliente_Leave);
            txtProducto.Leave += new EventHandler(txtProducto_Leave);
            txtCantidad.Leave += new EventHandler(txtCantidad_Leave);

        }
        static string CadenaConexion = "server=DESKTOP-RVG6SPD\\SQLEXPRESS; database=EmpresaConsumo; integrated security = true";
        SqlConnection ConexionEmpresa = new SqlConnection(CadenaConexion);

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            MenuPrincipal atras = new MenuPrincipal();
            atras.Show();
            this.Close();


        }
        private void ModuloVenta_Load(object sender, EventArgs e)
        {
            RecargarTabla(); // Llama a RecargarTabla en la carga del formulario
            CargarTablaProductos();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            RecargarTabla();
            CargarTablaProductos();
        }
        public void RecargarTabla()
        {
            try
            {
                ConexionEmpresa.Open();
                string CadenaBusqueda = "SELECT * FROM Clientes"; // Asegúrate de que la columna Desc exista
                SqlDataAdapter Adaptador = new SqlDataAdapter(CadenaBusqueda, ConexionEmpresa);
                DataTable TabladeDatos = new DataTable();
                Adaptador.Fill(TabladeDatos);
                dataGridView1.DataSource = TabladeDatos; // Asigna el DataTable al DataGridView
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar los datos: " + ex.Message);
            }
            finally
            {
                if (ConexionEmpresa.State == ConnectionState.Open)
                {
                    ConexionEmpresa.Close();
                }
            }
        }

        public void CargarTablaProductos()
        {
            try
            {
                ConexionEmpresa.Open();
                string CadenaBusqueda = "SELECT * FROM Productos"; // Asegúrate de que la columna Desc exista
                SqlDataAdapter Adaptador = new SqlDataAdapter(CadenaBusqueda, ConexionEmpresa);
                DataTable TablaProductos = new DataTable();
                Adaptador.Fill(TablaProductos);
                dataGridView2.DataSource = TablaProductos; // Asigna el DataTable al DataGridView
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar los datos: " + ex.Message);
            }
            finally
            {
                if (ConexionEmpresa.State == ConnectionState.Open)
                {
                    ConexionEmpresa.Close();
                }
            }
        }


        private void txtCliente_Leave(object sender, EventArgs e)
        {


            // Validar si el campo txtCliente no está vacío
            if (string.IsNullOrWhiteSpace(txtCliente.Text))
            {
                MessageBox.Show("Por favor, ingresa un cliente.");
                return;
            }

            // Validar que el texto ingresado en txtCliente sea un número
            if (!int.TryParse(txtCliente.Text, out int codigoCliente))
            {
                MessageBox.Show("El código de cliente debe ser un número.");
                txtCliente.Clear(); // Limpiar el campo si el código no es válido
                return;
            }

            try
            {
                if (ConexionEmpresa.State == ConnectionState.Closed)
                {
                    ConexionEmpresa.Open();
                }

                // Consulta para obtener el descuento del cliente basado en el código numérico del cliente
                string query = "SELECT Codigo, Nombre, Apellido, Telefono, FechaNac, Descuento FROM Clientes WHERE Codigo = @Cliente";
                SqlCommand comando = new SqlCommand(query, ConexionEmpresa);
                comando.Parameters.AddWithValue("@Cliente", codigoCliente); // Usar el valor numérico de codigoCliente

                SqlDataReader reader = comando.ExecuteReader();

                if (reader.Read()) // Si se encuentra el cliente
                {
                    // Obtener el nombre y apellido del cliente para lblCliente
                    string nombreCliente = $"{reader["Nombre"]} {reader["Apellido"]}";
                   
                    lblCliente.Text = nombreCliente; // Mostrar nombre completo del cliente en el lblCliente

                    // Mostrar la fecha actual en lblFecha
                    lblFecha.Text = DateTime.Now.ToString("dd/MM/yyyy");


                    // Obtener el descuento (si existe) y mostrarlo en txtDescuento
                    if (!reader.IsDBNull(5)) // Índice de la columna "Descuento"
                    {
                        int descuento = reader.GetInt32(5); // Leer el valor como entero
                        txtDescuento.Text = descuento.ToString(); // Mostrar el descuento en el TextBox

                        // Registrar el descuento en lblDescuento
                        lblDescuento.Text = $"{descuento}%";
                    }
                    else
                    {
                        MessageBox.Show("El cliente no tiene un descuento asignado.");
                        txtDescuento.Clear(); // Limpiar si el descuento es nulo
                    }
                }
                else
                {
                    MessageBox.Show("Cliente no encontrado.");
                    txtDescuento.Clear(); // Limpiar el campo si el cliente no se encuentra
                }

                reader.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al buscar el cliente: " + ex.Message);
            }
            finally
            {
                if (ConexionEmpresa.State == ConnectionState.Open)
                {
                    ConexionEmpresa.Close();
                }
            }
        }




       


        private void txtProducto_Leave(object sender, EventArgs e)
        {
            // Validar si el campo txtProducto no está vacío
            if (string.IsNullOrWhiteSpace(txtProducto.Text))
            {
                MessageBox.Show("Por favor, ingresa un código de producto.");
                return;
            }

            // Validar que el texto ingresado en txtProducto sea un número
            if (!int.TryParse(txtProducto.Text, out int codigoProducto))
            {
                MessageBox.Show("El código de producto debe ser un número.");
                txtProducto.Clear(); // Limpiar el campo si el código no es válido
                return;
            }

            try
            {
                if (ConexionEmpresa.State == ConnectionState.Closed)
                {
                    ConexionEmpresa.Open();
                }

                // Consulta para obtener el producto basado en el código numérico
                string query = "SELECT NombreProducto, Precio FROM Productos WHERE Codigo = @Producto";
                SqlCommand comando = new SqlCommand(query, ConexionEmpresa);
                comando.Parameters.AddWithValue("@Producto", codigoProducto); // Usar el valor numérico de codigoProducto

                SqlDataReader reader = comando.ExecuteReader();

                if (reader.Read()) // Si se encuentra el producto
                {
                    // Obtener el nombre del producto
                    string nombreProducto = reader["NombreProducto"].ToString();
                    lblProducto.Text = nombreProducto; // Mostrar nombre del producto
                }
                else
                {
                    MessageBox.Show("Producto no encontrado.");
                    txtProducto.Clear(); // Limpiar el campo si el producto no se encuentra
                }

                reader.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al buscar el producto: " + ex.Message);
            }
            finally
            {
                if (ConexionEmpresa.State == ConnectionState.Open)
                {
                    ConexionEmpresa.Close();
                }
            }
        }



        private bool validandoCantidad = false; // Variable de bandera

        // Cambiar el método txtCantidad_Leave para manejar la lógica
        private void txtCantidad_Leave(object sender, EventArgs e)
        {
            // Verificar si ya se está validando la cantidad
            if (validandoCantidad) return; // Si ya estamos validando, salir.

            // Marcar que estamos en proceso de validación
            validandoCantidad = true;

            // Verificar si el campo está vacío
            if (string.IsNullOrWhiteSpace(txtCantidad.Text))
            {
                MessageBox.Show("Por favor, ingresa una cantidad válida.");
                validandoCantidad = false; // Restablecer la variable de bandera
                return;
            }

            // Intentar convertir la cantidad ingresada en decimal
            if (!decimal.TryParse(txtCantidad.Text, System.Globalization.NumberStyles.Any, System.Globalization.CultureInfo.InvariantCulture, out decimal cantidad))
            {
                MessageBox.Show("El formato de la cantidad no es válido. Por favor, usa un formato numérico correcto.");
                txtCantidad.Clear();
                validandoCantidad = false; // Restablecer la variable de bandera
                return;
            }

            // Validar si la cantidad es mayor que cero
            if (cantidad <= 0)
            {
                MessageBox.Show("Por favor, ingresa una cantidad mayor a cero.");
                txtCantidad.Clear();
                validandoCantidad = false; // Restablecer la variable de bandera
                return;
            }

            try
            {
                if (ConexionEmpresa.State == ConnectionState.Closed)
                {
                    ConexionEmpresa.Open();
                }

                // Validar que el código de producto esté lleno
                if (string.IsNullOrWhiteSpace(txtProducto.Text) || !int.TryParse(txtProducto.Text, out int codigoProducto))
                {
                    MessageBox.Show("Por favor, ingresa un código de producto válido.");
                    validandoCantidad = false; // Restablecer la variable de bandera
                    return;
                }

                // Consulta para obtener el precio del producto
                string query = "SELECT NombreProducto, Precio FROM Productos WHERE Codigo = @Producto";
                SqlCommand comando = new SqlCommand(query, ConexionEmpresa);
                comando.Parameters.AddWithValue("@Producto", codigoProducto);

                SqlDataReader reader = comando.ExecuteReader();

                if (reader.Read()) // Si se encuentra el producto
                {
                    // Obtener el nombre y precio del producto
                    string nombreProducto = reader["NombreProducto"].ToString();
                    decimal precioUnitario = reader.GetDecimal(reader.GetOrdinal("Precio"));

                    // Calcular el total para este producto
                    decimal totalProducto = precioUnitario * cantidad;

                    // Agregar el producto a la lista de productos comprados
                    productosComprados.Add((nombreProducto, cantidad, precioUnitario, totalProducto));

                    // Actualizar el total acumulado
                    totalAcumulado += totalProducto;

                    // Actualizar labels
                    lblProducto.Text += nombreProducto + "\n"; // Mostrar cada producto en una nueva línea
                    lblCantidad.Text += cantidad.ToString() + "\n";
                    lblPrecioUnitario.Text += precioUnitario.ToString() + "\n";
                    lblTotal.Text = totalAcumulado.ToString(); // Mostrar total acumulado
                }
                else
                {
                    MessageBox.Show("Producto no encontrado.");
                    txtProducto.Clear(); // Limpiar el campo si el producto no se encuentra
                }

                reader.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al calcular el total: " + ex.Message);
            }
            finally
            {
                if (ConexionEmpresa.State == ConnectionState.Open)
                {
                    ConexionEmpresa.Close();
                }
            }

            // Limpiar los campos de producto y cantidad para ingresar otro producto
            LimpiarCaja();
            // Restablecer la variable de bandera
            validandoCantidad = false;
        }

        public void LimpiarCaja()
        {
            txtProducto.Clear();
            txtCantidad.Clear();
        }



        private void btnVender_Click(object sender, EventArgs e)
        {
            // Validar que todos los campos requeridos estén llenos
            if (string.IsNullOrWhiteSpace(txtProducto.Text) ||
                string.IsNullOrWhiteSpace(txtCantidad.Text) ||
                string.IsNullOrWhiteSpace(txtCliente.Text))
            {
                MessageBox.Show("Por favor, completa todos los campos: Cliente, Producto y Cantidad.");
                return;
            }

            // Llamar al método de validación de cantidad
            txtCantidad_Leave(sender, e);
        }







        private void btnEmitirComprobante_Click(object sender, EventArgs e)
        {
            // Obtener los datos de lblCliente, lblFecha y txtDescuento
            string cliente = lblCliente.Text;
            string fecha = lblFecha.Text;
            int descuentoCliente = 0;

            // Validar que los datos no estén vacíos
            if (string.IsNullOrWhiteSpace(cliente) || string.IsNullOrWhiteSpace(fecha))
            {
                MessageBox.Show("Por favor, asegúrate de que los datos del cliente y la fecha estén completos.");
                return;
            }

            // Validar y obtener el descuento del cliente
            if (!string.IsNullOrWhiteSpace(txtDescuento.Text))
            {
                if (!int.TryParse(txtDescuento.Text, out descuentoCliente))
                {
                    MessageBox.Show("El descuento del cliente debe ser un número válido.");
                    return;
                }
            }

            // Aplicar el descuento al total acumulado
            decimal totalConDescuento = totalAcumulado;
            if (descuentoCliente > 0)
            {
                decimal descuentoDecimal = (decimal)descuentoCliente / 100;
                totalConDescuento = totalAcumulado - (totalAcumulado * descuentoDecimal);
            }

            // Mostrar comprobante con todos los productos comprados
            StringBuilder detalleCompra = new StringBuilder();
            detalleCompra.AppendLine($"Comprobante emitido para el cliente {cliente} en la fecha {fecha}.");
            detalleCompra.AppendLine("Productos comprados:");

            foreach (var producto in productosComprados)
            {
                detalleCompra.AppendLine($"Producto: {producto.nombreProducto}, Cantidad: {producto.cantidad}, Precio Unitario: {producto.precioUnitario}, Total: {producto.total}");
            }

            detalleCompra.AppendLine($"Total a pagar con descuento: {totalConDescuento}");

            MessageBox.Show(detalleCompra.ToString());

            // Reiniciar el total acumulado y limpiar los labels y la lista de productos
            ReiniciarVenta();
        }






        // Método para reiniciar los datos de la venta
        private void ReiniciarVenta()
        {
            totalAcumulado = 0;
            productosComprados.Clear();
            lblProducto.Text = "";
            lblCantidad.Text = "";
            lblPrecioUnitario.Text = "";
            lblTotal.Text = "";

            // Limpiar los campos adicionales
            lblCliente.Text = "";      // Limpiar el label del cliente
            lblFecha.Text = "";        // Limpiar el label de la fecha
            lblDescuento.Text = "";    // Limpiar el label del descuento
            txtCliente.Clear();        // Limpiar el TextBox del cliente
            txtDescuento.Clear();      // Limpiar el TextBox del descuento
        }





    }
}*/