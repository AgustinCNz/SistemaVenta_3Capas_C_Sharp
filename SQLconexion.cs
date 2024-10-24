
using System;
using System.Data;
using System.Data.SqlClient;
using System.Globalization;
using System.IO;
using System.Net;
using System.Net.NetworkInformation;
using System.Runtime.Remoting;
using System.Security.Claims;
using System.Security.Cryptography.X509Certificates;


namespace Datos
{
    public class SQLconexion
    {
        static string StrConexion = "Server = MSI\\SQLEXPRESS; database = SistemaCompras; integrated security = true;";
        SqlConnection Miconexion = new SqlConnection(StrConexion);
        public int iniciarSesion(string Usuario, string Clave)
        {
            Miconexion.Open();
            string Consulta = "Select count (*) from Empleado where Usuario ='" + Usuario + "' and Clave ='" + Clave + "'";
            SqlCommand Miconsulta = new SqlCommand(Consulta, Miconexion);
            int Resultado = Convert.ToInt32(Miconsulta.ExecuteScalar());
            Miconexion.Close();
            return Resultado;

        }
        public string[] BuscarUsuario(string Us, string Cl)
        {
            string query = "SELECT * FROM Empleado WHERE Usuario ='" + Us + "' and Clave ='" + Cl + "'";

            SqlCommand cmd = new SqlCommand(query, Miconexion);

            string[] em = new string[9];



            try
            {
                Miconexion.Open();
                using (SqlDataReader reader = cmd.ExecuteReader())
                {
                    if (reader.Read())
                    {
                        string ID = reader["ID"].ToString();
                        string DNI = reader["DNI"].ToString();
                        string apellido = reader["Apellido"].ToString();
                        string nombre = reader["Nombre"].ToString();
                        string Telefono = reader["Telefono"].ToString();
                        string FechaNac = reader["FechaNac"].ToString();
                        string Usu = reader["Usuario"].ToString();
                        string Cla = reader["Clave"].ToString();
                        string Puesto = reader["Puesto"].ToString();

                        em[0] = ID;
                        em[1] = DNI;
                        em[2] = apellido;
                        em[3] = nombre;
                        em[4] = Telefono;
                        em[5] = FechaNac;
                        em[6] = Usu;
                        em[7] = Cla;
                        em[8] = Puesto;
                        //la clave del exito

                        return em;
                    }
                    else
                    {
                        Console.WriteLine("No se encontró ningún elemento con esa ID.");
                    }

                    reader.Close();
                }

            }


            catch (Exception ex)
            {
                Console.WriteLine(ex);
            }
            Miconexion.Close();
            return null;
        }

        public string[] BuscarUsuarioPorId(int Id)
        {
            string query = "SELECT * FROM Empleado WHERE ID ='" + Id + "'";

            SqlCommand cmd = new SqlCommand(query, Miconexion);

            string[] em = new string[9];

            try
            {
                Miconexion.Open();
                using (SqlDataReader reader = cmd.ExecuteReader())
                {
                    if (reader.Read())
                    {
                        string ID = reader["ID"].ToString();
                        string DNI = reader["DNI"].ToString();
                        string apellido = reader["Apellido"].ToString();
                        string nombre = reader["Nombre"].ToString();
                        string Telefono = reader["Telefono"].ToString();
                        string FechaNac = reader["FechaNac"].ToString();
                        string Usu = reader["Usuario"].ToString();
                        string Cla = reader["Clave"].ToString();
                        string Puesto = reader["Puesto"].ToString();

                        em[0] = ID;
                        em[1] = DNI;
                        em[2] = apellido;
                        em[3] = nombre;
                        em[4] = Telefono;
                        em[5] = FechaNac;
                        em[6] = Usu;
                        em[7] = Cla;
                        em[8] = Puesto;
                        //la clave del exito
                        return em;
                    }
                    else
                    {
                        Console.WriteLine("No se encontró ningún elemento con esa ID.");
                    }

                    reader.Close();
                }

            }


            catch (Exception ex)
            {
                Console.WriteLine(ex);
            }
            Miconexion.Close();
            return null;
        }

        public DataTable ObtenerTablaEmpleados()
        {
            string CadenaBusqueda = "select * from Empleado";
            SqlDataAdapter Adaptador = new SqlDataAdapter(CadenaBusqueda, Miconexion);

            DataTable TabladeDatos = new DataTable();
            Adaptador.Fill(TabladeDatos);
            return TabladeDatos;
        }
        public DataTable EliminarEmpleado(int ID)
        {
            Miconexion.Open();

            string CadenaEliminar = "delete from Empleado where ID='" + ID + "'";
            SqlCommand ComandoEliminar = new SqlCommand(CadenaEliminar, Miconexion);
            ComandoEliminar.ExecuteNonQuery();
            Miconexion.Close();
            return ObtenerTablaEmpleados();
        }
        public int AgregarEmpleado(int DNI, string Apellido, string Nombre, string Telefono, DateTime FechaNac, string Usuario, string Clave, string Puesto)
        {
            Miconexion.Open();
            try
            {
                string fechaACargar = FechaNac.ToString("MM/dd/yyyy");

                string CadenaAgregar = "insert into Empleado (DNI," + "Apellido, Nombre,Telefono, FechaNac,Usuario, Clave,Puesto) values (" +
                    "'" + DNI + "'," +
                    "'" + Apellido + "'," +
                    "'" + Nombre + "'," +
                    "'" + Telefono + "'," +
                    "'" + fechaACargar + "'," +
                    "'" + Usuario + "'," +
                    "'" + Clave + "'," +
                    "'" + Puesto + "')";

                string projectDirectory = Directory.GetParent(Environment.CurrentDirectory).Parent.Parent.FullName;
                string path = Path.Combine(projectDirectory, "log.txt");
                File.AppendAllText(path, $"QERY AGREGAR EMPLEADO: {CadenaAgregar}\n");

                SqlCommand ComandoAgregar = new SqlCommand(CadenaAgregar, Miconexion);
                ComandoAgregar.ExecuteNonQuery();
                //SqlCommand ComandoAgregar = new SqlCommand(CadenaAgregar, ConexionEmpresa);
                // ComandoAgregar.ExecuteNonQuery();      
                Miconexion.Close();
            }
            catch (Exception e)
            {
                return 0;
            }
            return 1;
        }
        public void ModificarEmpleado(int DNI, string Apellido, string Nombre, string Telefono, DateTime FechaNac, string Usuario, string Clave, string Puesto)
        {
            try
            {
                Miconexion.Open();
                string fechaACargar = FechaNac.ToString("MM/dd/yyyy");
                string query = "UPDATE Empleado SET Apellido = @Apellido, Nombre = @Nombre, Telefono = @Telefono, FechaNac = @FechaNac, Usuario = @Usuario, Clave = @Clave, Puesto = @Puesto WHERE DNI = @DNI";
                SqlCommand cmd = new SqlCommand(query, Miconexion);

                cmd.Parameters.AddWithValue("DNI", DNI);
                cmd.Parameters.AddWithValue("Apellido", Apellido);
                cmd.Parameters.AddWithValue("Nombre", Nombre);
                cmd.Parameters.AddWithValue("Telefono", Telefono);
                cmd.Parameters.AddWithValue("FechaNac", fechaACargar);
                cmd.Parameters.AddWithValue("Usuario", Usuario);
                cmd.Parameters.AddWithValue("Clave", Clave);
                cmd.Parameters.AddWithValue("Puesto", Puesto);

                int FilasAfectadas = cmd.ExecuteNonQuery();


            }
            catch (Exception ex)
            {

            }
            Miconexion.Close();
        }
        public DataTable Producto()
        {
            string CadenaBusqueda = "select * from Producto";
            SqlDataAdapter Adaptador = new SqlDataAdapter(CadenaBusqueda, Miconexion);

            DataTable TabladeDatos = new DataTable();
            Adaptador.Fill(TabladeDatos);
            return TabladeDatos;
        }
        public int AgregarProducto(int Codigo, string NombreProducto, string NombreCorto, float PrecioCosto, float Stock, float StockMinimo, int PorcentajeGanancias)
        {
            Miconexion.Open();
            try
            {
                string CadenaAgregar = "insert into Producto (Codigo," + "NombreProducto, NombreCorto, PrecioCosto, Stock, StockMinimo, PorcentajeGanancia) values (" +
                    "'" + Codigo + "'," +
                    "'" + NombreProducto + "'," +
                    "'" + NombreCorto + "'," +
                    "'" + PrecioCosto + "'," +
                    "'" + Stock + "'," +
                    "'" + StockMinimo + "'," +
                    "'" + PorcentajeGanancias + "')";

                SqlCommand ComandoAgregar = new SqlCommand(CadenaAgregar, Miconexion);
                ComandoAgregar.ExecuteNonQuery();
                //SqlCommand ComandoAgregar = new SqlCommand(CadenaAgregar, ConexionEmpresa);
                // ComandoAgregar.ExecuteNonQuery();      
                Miconexion.Close();
            }
            catch (Exception e)
            {
                return 0;
            }
            return 1;
        }
        public DataTable EliminarProducto(int Codigo)
        {
            Miconexion.Open();

            string CadenaEliminar = "delete from Producto where codigo='" + Codigo + "'";
            SqlCommand ComandoEliminar = new SqlCommand(CadenaEliminar, Miconexion);
            ComandoEliminar.ExecuteNonQuery();
            Miconexion.Close();
            return Producto();
        }
        public void ModificarProducto(int Codigo, string NombreProducto, string NombreCorto, double PrecioCosto, float Stock, float StockMinimo, int PorcentajeGanancias)
        {
            try
            {
               
                Miconexion.Open();
                

                string query = "UPDATE Producto SET Codigo = @Codigo, NombreProducto = @NombreProducto, NombreCorto = @NombreCorto, PrecioCosto = @PrecioCosto, Stock = @Stock, StockMinimo = @StockMinimo, PorcentajeGanancia = @PorcentajeGanancia WHERE Codigo = @Codigo";
                SqlCommand cmd = new SqlCommand(query, Miconexion);
                                
                              

                cmd.Parameters.AddWithValue("Codigo", Codigo);
                cmd.Parameters.AddWithValue("NombreProducto", NombreProducto);
                cmd.Parameters.AddWithValue("NombreCorto", NombreCorto);
                cmd.Parameters.AddWithValue("PrecioCosto", PrecioCosto);
                cmd.Parameters.AddWithValue("Stock", Stock);
                cmd.Parameters.AddWithValue("StockMinimo", StockMinimo);
                cmd.Parameters.AddWithValue("PorcentajeGanancia", PorcentajeGanancias);


                int FilasAfectadas = cmd.ExecuteNonQuery();



                Miconexion.Close();
            }
            catch (Exception ex)
            {
                string projectDirectory3 = Directory.GetParent(Environment.CurrentDirectory).Parent.Parent.FullName;
                string path3 = Path.Combine(projectDirectory3, "log.txt");
                File.AppendAllText(path3, "FAIL");
                Miconexion.Close();
            }
            Miconexion.Close();
        }
        public string[] BuscarProductoporCodigo(int Codigo)
        {
            string query = "SELECT * FROM Producto WHERE Codigo ='" + Codigo + "'";

            SqlCommand cmd = new SqlCommand(query, Miconexion);

            string[] pro = new string[7];

            try
            {
                Miconexion.Open();
                using (SqlDataReader reader = cmd.ExecuteReader())
                {
                    if (reader.Read())
                    {
                        string Co = reader["Codigo"].ToString();
                        string NombreProducto = reader["NombreProducto"].ToString();
                        string NombreCorto = reader["NombreCorto"].ToString();
                        string PrecioCosto = reader["PrecioCosto"].ToString();
                        string Stock = reader["Stock"].ToString();
                        string StockMinimo = reader["StockMinimo"].ToString();
                        string PorcentajeGanancia = reader["PorcentajeGanancia"].ToString();


                        pro[0] = Co;
                        pro[1] = NombreProducto;
                        pro[2] = NombreCorto;
                        pro[3] = PrecioCosto;
                        pro[4] = Stock;
                        pro[5] = StockMinimo;
                        pro[6] = PorcentajeGanancia;

                        //la clave del exito
                        return pro;
                    }
                    else
                    {
                        Console.WriteLine("No se encontró ningún elemento con ese Codigo.");
                    }

                    reader.Close();
                }

            }


            catch (Exception ex)
            {
                Console.WriteLine(ex);
            }
            Miconexion.Close();
            return null;
        }
        public DataTable ConsultarMovimientos()
        {
            string CadenaBusqueda = "select * from Comprobante";
            SqlDataAdapter Adaptador = new SqlDataAdapter(CadenaBusqueda, Miconexion);

            DataTable TabladeDatos = new DataTable();
            Adaptador.Fill(TabladeDatos);
            return TabladeDatos;
        }
        public void CargarComprobante(int Tipo, int Numero, DateTime Fecha, int Empleado, int Cliente, double Monto)
        {
    
            Miconexion.Open();
            try
            {
                double montoFinal = Math.Round(Monto, 2);
                string valorFormateado = montoFinal.ToString(CultureInfo.InvariantCulture); // Convierte 100,32 a 100.32 por ej

                string fechaACargar = Fecha.ToString("MM/dd/yyyy");

                string CadenaAgregar = "insert into Comprobante (Tipo," + "Numero, Fecha, Empleado, Cliente, Monto) values (" +
                    "'" + Tipo + "'," +
                    "'" + Numero + "'," +
                    "'" + fechaACargar + "'," +
                    "'" + Empleado + "'," +
                    "'" + Cliente + "'," +
                    "'" + valorFormateado + "')";

                string projectDirectory = Directory.GetParent(Environment.CurrentDirectory).Parent.Parent.FullName;
                string path = Path.Combine(projectDirectory, "log.txt");
                File.AppendAllText(path, $"Datos: {"" + CadenaAgregar}\n");


                SqlCommand ComandoAgregar = new SqlCommand(CadenaAgregar, Miconexion);
                ComandoAgregar.ExecuteNonQuery();
                //SqlCommand ComandoAgregar = new SqlCommand(CadenaAgregar, ConexionEmpresa);
                // ComandoAgregar.ExecuteNonQuery();      
                Miconexion.Close();
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }

        }
        public string[] consultarCliente(int codigoCliente)
        {
             
            try
            {
                Miconexion.Open();
                string[] cli = new string[6];
            
                // Consulta para obtener el descuento del cliente basado en el código numérico del cliente
                string query = "SELECT * FROM Cliente WHERE Codigo ='" + codigoCliente + "'";

                SqlCommand comando = new SqlCommand(query, Miconexion);

                 // Usar el valor numérico de codigoCliente

                SqlDataReader reader = comando.ExecuteReader();

                if (reader.Read())
                {
                    string Co = reader["Codigo"].ToString();
                    string Apellido = reader["Apellido"].ToString();
                    string Nombre = reader["Nombre"].ToString();
                    string Telefono = reader["Telefono"].ToString();
                    string FechaNac = reader["FechaNac"].ToString();
                    string Descuento = reader["Descuento"].ToString();
         
                    cli[0] = Co;
                    cli[1] = Apellido;
                    cli[2] = Nombre;
                    cli[3] = Telefono;
                    cli[4] = FechaNac;
                    cli[5] = Descuento;

                    return cli;
                }
                else
                {
                    Console.WriteLine("No se encontró ningún elemento con ese Codigo.");
                }

                reader.Close();
            }
            catch (Exception ex)
            {
                return null;
            }
            finally
            {
                if (Miconexion.State == ConnectionState.Open)
                {
                    Miconexion.Close();
                }
            }
            return null;
        }

    } 
 }


