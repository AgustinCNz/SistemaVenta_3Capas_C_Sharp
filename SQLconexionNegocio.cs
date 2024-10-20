using Datos;
using Microsoft.Win32;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
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
        public int AgregarUnProducto(int Codigo, string NombreProducto, string NombreCorto, float PrecioCosto, float Stock, float StockMinimo, int PorcentajeGanancias)
        {
            return cn.AgregarProducto(Codigo,  NombreProducto,  NombreCorto,  PrecioCosto,  Stock,  StockMinimo,  PorcentajeGanancias);
        }
        public DataTable EliminarUnproducto(int Codigo)
        {
            return cn.EliminarProducto(Codigo);
        }
        public void ModificarUnproducto(int Codigo, string NombreProducto, string NombreCorto, float precioCosto, float Stock, float StockMinimo, int PorcentajeGanancias)
        {
            cn.ModificarProducto(Codigo, NombreProducto, NombreCorto, precioCosto, Stock, StockMinimo, PorcentajeGanancias);
        }
        public Producto ObtenerProductoporCodigo(int Codigo)
        {
            string[] DatosProducto = cn.BuscarProductoporCodigo(Codigo);

            try
            {
                Producto producto2 = new Producto(
                    int.Parse(DatosProducto[0]),
                    DatosProducto[1],
                    DatosProducto[2],
                   float.Parse(DatosProducto[3]),
                   float.Parse(DatosProducto[4]),
                   float.Parse(DatosProducto[5]),
                    int.Parse(DatosProducto[6])
                );

                return producto2;
            }
            catch (Exception ex)
            {
                Console.WriteLine("Error al convertir los datos del empleado: " + ex.Message);
                return null;
            }
        }
        public DataTable CargarMovimiento()
        {
            return cn.ConsultarMovimientos();
        }
        public void AgregarUnmonto(int Tipo, int Numero, DateTime Fecha, int Empleado, int Cliente, float Monto)
        {
            cn.CargarComprobante(Tipo, Numero, Fecha, Empleado, Cliente, Monto);
        }

        public void AgregarComprobante(int numeroFactura, DateTime fecha, int idEmpleado, float montoTotal)
        {
            cn.AgregarComprobante(numeroFactura, fecha, idEmpleado, montoTotal);
        }







    }
}
