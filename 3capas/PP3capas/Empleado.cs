using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PP3capas
{
    public class Empleado
    {
        public int ID {  get; set; }
        public int DNI {  get; set; }
        public string Apellido { get; set; }
        public string Nombre { get; set; }
        public string Telefono { get; set; }
        public DateTime FechaNac { get; set; }
        public string Usuario {  get; set; }
        public string Clave { get; set; }
        public string Puesto { get; set; }

        public Empleado(int ID, int DNI, string apellido, string nombre, string telefono, DateTime fechaNac, string usuario, string clave, string puesto)
        {
            this.ID = ID;
            this.DNI = DNI;
            this.Apellido = apellido;
            this.Nombre = nombre;
            this.Telefono = telefono;
            this.FechaNac = fechaNac;
            this.Usuario = usuario;
            this.Clave = clave;
            this.Puesto = puesto;
        }
    }
}
