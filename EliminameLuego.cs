/*using System;
using System.Collections;
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
    public partial class ModuloCompra : Form
    {
        public ModuloCompra()
        {
            InitializeComponent();
        }

        static string CadenaConexion = "server=DESKTOP-RVG6SPD\\SQLEXPRESS; database=EmpresaConsumo; integrated security = true";
        SqlConnection ConexionEmpresa = new SqlConnection(CadenaConexion);

        private List<Tuple<string, int, decimal>> productosEnFactura = new List<Tuple<string, int, decimal>>();
        private void pictureBox1_Click(object sender, EventArgs e)
        {

            MenuPrincipal atras = new MenuPrincipal();
            atras.Show();
            this.Hide();
        }

        private void ModuloCompra_Load(object sender, EventArgs e)
        {
            RecargarTabla(); // Llama a RecargarTabla en la carga del formulario
        }

        public void RecargarTabla()
        {
            try
            {
                if (ConexionEmpresa.State == ConnectionState.Closed) // Verifica si la conexión está cerrada
                {
                    ConexionEmpresa.Open();
                }

                string CadenaBusqueda = "SELECT * FROM Productos";
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
                if (ConexionEmpresa.State == ConnectionState.Open) // Verifica si la conexión está abierta antes de cerrarla
                {
                    ConexionEmpresa.Close();
                }
            }
        }


        public void LimpiarCaja()
        {
            txtCodigo.Clear();

            txtPrecio.Clear();
            txtCantidad.Clear();

        }

        public void LimpiarCajaTodas()
        {
            txtCodigo.Clear();
            txtFactura.Clear();
            txtPrecio.Clear();
            txtCantidad.Clear();

            lblCantidad.Text = "";
            lblPrecio.Text = "";
            lblCodigo.Text = "";
            lblFecha.Text = "";
            lblFactura.Text = "";


        }



        private void pictureBox3_Click(object sender, EventArgs e)
        {
            RecargarTabla();
        }




        private void txtCodigo_Leave(object sender, EventArgs e)
        {
            try
            {
                if (ConexionEmpresa.State == ConnectionState.Closed)
                {
                    ConexionEmpresa.Open();
                }

                string query = "SELECT Precio FROM Productos WHERE Codigo = @Codigo";
                SqlCommand command = new SqlCommand(query, ConexionEmpresa);
                command.Parameters.AddWithValue("@Codigo", txtCodigo.Text);

                SqlDataReader reader = command.ExecuteReader();
                if (reader.Read())
                {
                    decimal precio = reader.GetDecimal(0);
                    txtPrecio.Text = precio.ToString();
                }
                else
                {
                    MessageBox.Show("El producto no existe.");
                }

                reader.Close();
            }
            catch (SqlException ex)
            {
                MessageBox.Show($"Error al cargar el precio: {ex.Message}");
            }
            finally
            {
                if (ConexionEmpresa.State == ConnectionState.Open)
                {
                    ConexionEmpresa.Close();
                }
            }
        }




        private void btnAgregar_Click(object sender, EventArgs e)
        {
            // Validaciones de entrada
            if (string.IsNullOrWhiteSpace(txtFactura.Text) ||
                string.IsNullOrWhiteSpace(txtCodigo.Text) ||
                string.IsNullOrWhiteSpace(txtCantidad.Text) ||
                string.IsNullOrWhiteSpace(txtPrecio.Text))
            {
                MessageBox.Show("Por favor, complete todos los campos.");
                return;
            }

            int cantidad;
            if (!int.TryParse(txtCantidad.Text, out cantidad) || cantidad <= 0)
            {
                MessageBox.Show("Por favor, ingrese una cantidad válida. Debe ser mayor que 0.");
                return;
            }

            decimal precio;
            if (!decimal.TryParse(txtPrecio.Text, out precio) || precio <= 0)
            {
                MessageBox.Show("Por favor, ingrese un precio válido. Debe ser mayor que 0.");
                return;
            }

            try
            {
                ConexionEmpresa.Open();

                // Verificar si el producto existe
                string query = "SELECT * FROM Productos WHERE Codigo = @Codigo";
                SqlCommand command = new SqlCommand(query, ConexionEmpresa);
                command.Parameters.AddWithValue("@Codigo", int.Parse(txtCodigo.Text));

                SqlDataReader reader = command.ExecuteReader();
                if (reader.HasRows)
                {
                    reader.Close();

                    // Actualizar stock en la base de datos
                    string actualizarStock = "UPDATE Productos SET Stock = Stock + @Cantidad WHERE Codigo = @Codigo";
                    SqlCommand actualizarCommand = new SqlCommand(actualizarStock, ConexionEmpresa);
                    actualizarCommand.Parameters.AddWithValue("@Cantidad", cantidad);
                    actualizarCommand.Parameters.AddWithValue("@Codigo", txtCodigo.Text);
                    actualizarCommand.ExecuteNonQuery();

                    // Añadir el producto a la lista temporal
                    productosEnFactura.Add(new Tuple<string, int, decimal>(txtCodigo.Text, cantidad, precio));

                    MessageBox.Show("Producto agregado a la factura.");
                    lblFactura.Text = txtFactura.Text;
                    lblFecha.Text = DateTime.Now.ToString("dd/MM/yyyy");
                    lblCodigo.Text = txtCodigo.Text;
                    lblCantidad.Text = cantidad.ToString();
                    lblPrecio.Text = (cantidad * precio).ToString("F2");

                    LimpiarCaja(); // Limpiar los campos

                    RecargarTabla(); // Actualizar la tabla de productos
                }
                else
                {
                    MessageBox.Show("El producto no existe.");
                }
            }
            catch (SqlException ex)
            {
                MessageBox.Show($"Error de base de datos: {ex.Message}");
            }
            finally
            {
                ConexionEmpresa.Close();
            }
        }


        private void btnEmitirComprobante_Click(object sender, EventArgs e)
        {
            if (productosEnFactura.Count == 0)
            {
                MessageBox.Show("No hay productos en la factura.");
                return;
            }

            decimal totalFactura = 0;
            int totalCantidad = 0;

            // Calcular el total de la factura y la cantidad de productos
            foreach (var producto in productosEnFactura)
            {
                totalCantidad += producto.Item2; // Sumar cantidad
                totalFactura += producto.Item2 * producto.Item3; // Sumar precio total (cantidad * precio)
            }

            // Actualizar los labels con la información de la factura
            lblFactura.Text = txtFactura.Text;
            lblFecha.Text = DateTime.Now.ToString("dd/MM/yyyy");
            lblCantidad.Text = totalCantidad.ToString();
            lblPrecio.Text = totalFactura.ToString("F2");

            MessageBox.Show("Comprobante emitido con éxito.");

            // Limpiar lista y formulario
            productosEnFactura.Clear();
            LimpiarCajaTodas();
        }


    }

}

*/