using Datos;
using Microsoft.Win32;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Linq;
using System.Security.Cryptography;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace PP3capas
{
    public class SQLconexionNegocio
    {
        
        SQLconexion cn = new SQLconexion();

        public int conSQLIniciarSesion(string user, string pass)
        {
            return cn.iniciarSesion(user, pass);
        }

        // AGREGAR FUNCION QUE DEVUELVA DATOS DEL EMPLEADO DE SQL Conexion en base a su usuario y contraseña
        /*public Empleado ObtenerUsuario(string Usuario, string Clave)
         {
             string[]  Datosempleado = cn.BuscarUsuario(Usuario, Clave);
             Console.WriteLine(Datosempleado);
             Empleado empleado = new Empleado(int.Parse(Datosempleado[0]), int.Parse(Datosempleado[1]), Datosempleado[2], Datosempleado[3], Datosempleado[4], DateTime.Parse(Datosempleado[5]), Datosempleado[6], Datosempleado[7], Datosempleado[8]);

             return empleado;

         }*/
        public Empleado ObtenerUsuario(string Usuario, string Clave)
        {
            string[] Datosempleado = cn.BuscarUsuario(Usuario, Clave);

            if (Datosempleado == null || Datosempleado.Length < 9)
            {
                Console.WriteLine("No se encontraron datos del empleado o los datos son incompletos.");
                return null;
            }

            try
            {
                Empleado empleado = new Empleado(
                    int.Parse(Datosempleado[0]),
                    int.Parse(Datosempleado[1]),
                    Datosempleado[2],
                    Datosempleado[3],
                    Datosempleado[4],
                    DateTime.Parse(Datosempleado[5]),
                    Datosempleado[6],
                    Datosempleado[7],
                    Datosempleado[8]
                );

                return empleado;
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error al convertir los datos del empleado: " + ex.Message);
                return null;
            }
        }

        public Empleado ObtenerUsuarioPorId(int id)
        {
            string[] Datosempleado = cn.BuscarUsuarioPorId(id);
            if (Datosempleado == null)
            {
                Console.WriteLine("Selecciona una ID");
                return null;
               /* try
                {
                    Empleado empleado2 = new Empleado(
                        int.Parse(Datosempleado[0]),
                        int.Parse(Datosempleado[1]),
                        Datosempleado[2],
                        Datosempleado[3],
                        Datosempleado[4],
                        DateTime.Parse(Datosempleado[5]),
                        Datosempleado[6],
                        Datosempleado[7],
                        Datosempleado[8]
                    );

                    return empleado2;
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Error al convertir los datos del empleado: " + ex.Message);
                    return null;
                }*/
            }
            else
            {
                try
                {
                    Empleado empleado2 = new Empleado(
                        int.Parse(Datosempleado[0]),
                        int.Parse(Datosempleado[1]),
                        Datosempleado[2],
                        Datosempleado[3],
                        Datosempleado[4],
                        DateTime.Parse(Datosempleado[5]),
                        Datosempleado[6],
                        Datosempleado[7],
                        Datosempleado[8]
                    );

                    return empleado2;
                }
                catch (Exception ex)
                {
                    Console.WriteLine("Error al convertir los datos del empleado: " + ex.Message);
                    return null;
                }
            }
        }

        public DataTable CargarTablaEmpleados()
        {
            return cn.ObtenerTablaEmpleados();
        } 
        public DataTable EliminarUnempleado(int ID)
        {
            return cn.EliminarEmpleado(ID);
        }
        public int AgregarUnempleado(int DNI, string Apellido, string Nombre, string Telefono, DateTime FechaNac, string Usuario, string Clave, string Puesto)
        {
             return cn.AgregarEmpleado(DNI,Apellido,Nombre,Telefono,FechaNac,Usuario,Clave,Puesto);
        }
        public void ModificarUnempleado (int DNI, string Apellido, string Nombre, string Telefono, DateTime FechaNac, string Usuario, string Clave, string Puesto)
        {
            cn.ModificarEmpleado(DNI, Apellido, Nombre, Telefono, FechaNac, Usuario, Clave, Puesto);
        }
        public DataTable CargarProducto()
        {
            return cn.Producto();
        }
        public int AgregarUnProducto(int Codigo, string NombreProducto, string NombreCorto, float PrecioCosto, float Stock, float StockMinimo, int PorcentajeGanancias, float PrecioVenta)
        {
            return cn.AgregarProducto(Codigo,  NombreProducto,  NombreCorto,  PrecioCosto,  Stock,  StockMinimo,  PorcentajeGanancias, PrecioVenta);
        }
        public DataTable EliminarUnproducto(int Codigo)
        {
            return cn.EliminarProducto(Codigo);
        }
        public void ModificarUnproducto(int Codigo, string NombreProducto, string NombreCorto, double PrecioCosto, float Stock, float StockMinimo, int PorcentajeGanancias, float PrecioVenta)
        {
            cn.ModificarProducto(Codigo, NombreProducto, NombreCorto, PrecioCosto, Stock, StockMinimo, PorcentajeGanancias, PrecioVenta);
        }
        public Producto ObtenerProductoporCodigo(int Codigo)
        {
            string[] DatosProducto = cn.BuscarProductoporCodigo(Codigo);

            try
            {
                if (DatosProducto != null && DatosProducto.Length >= 8)
                {
                    Producto producto2 = new Producto(
                        int.Parse(DatosProducto[0]), // Código
                        DatosProducto[1],             // NombreProducto
                        DatosProducto[2],             // NombreCorto
                        float.Parse(DatosProducto[3]), // PrecioCosto
                        float.Parse(DatosProducto[4]), // Stock
                        float.Parse(DatosProducto[5]), // StockMinimo
                        int.Parse(DatosProducto[6]),  // PorcentajeGanancias
                        float.Parse(DatosProducto[7])  // PrecioVenta
                    );
                    return producto2;
                }

                Console.WriteLine("Los datos del producto son incompletos.");
                return null;
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error al convertir los datos del producto: " + ex.Message);
                return null;
            }
        }

        /*public Producto ObtenerProductoporCodigo(int Codigo)
        {
            string[] DatosProducto = cn.BuscarProductoporCodigo(Codigo);

            try
            {
                if (DatosProducto != null && DatosProducto.Length >= 8) {
                    Producto producto2 = new Producto(
                        int.Parse(DatosProducto[0]), // codigo
                        DatosProducto[1], //NombrProducto
                        DatosProducto[2], // NombreCorto
                       float.Parse(DatosProducto[3]), //PrecioCosto
                       float.Parse(DatosProducto[4]), // Stock
                       float.Parse(DatosProducto[5]), // StockMinimo
                        int.Parse(DatosProducto[6])); // PorcentajeGanancias
                    float.Parse(DatosProducto[7]); //PrecioVenta
                    );
                    return producto2;
                }

                return null;
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error al convertir los datos del empleado: " + ex.Message);
                return null;
            }
        }*/
        public DataTable CargarMovimiento()
        {
            return cn.ConsultarMovimientos();
        }
        public void AgregarUnmonto(int Tipo, int Numero, DateTime Fecha, int Empleado, int Cliente, double Monto)
        {
            cn.CargarComprobante(Tipo, Numero, Fecha, Empleado, Cliente, Monto);
        }
        public Cliente BuscarCliente(int codigocliente)
        {
            string[] DatosCliente = cn.consultarCliente(codigocliente);

            try
            {
                if (DatosCliente != null)
                {
                    Cliente cliente = new Cliente(
                       int.Parse(DatosCliente[0]),
                        DatosCliente[1],
                        DatosCliente[2],
                        DatosCliente[3],
                        DateTime.Parse(DatosCliente[4]),
                       int.Parse(DatosCliente[5]));
                    return cliente;
                }


                return null;
                 
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error al convertir los datos del cliente: " + ex.Message);
                return null;
            }
        } 
    }

}

