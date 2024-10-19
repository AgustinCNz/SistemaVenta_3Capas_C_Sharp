using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PP3capas
{
    public class Cliente
    {
        public int codigo {  get; set; }
        public string Apellido { get; set; }
        public string Nombre { get; set; }
        public string Telefono { get; set; }
        public DateTime FechaNac {  get; set; }
        public int Descuento { get; set; }

        public Cliente(int codigo, string apellido, string nombre, string telefono, DateTime fechaNac, int descuento)
        {
            this.codigo = codigo;
            this.Apellido = apellido;
            this.Nombre = nombre;
            this.Telefono = telefono;
            this.FechaNac = fechaNac;
            this.Descuento = descuento;
        }
    }
}
