using System;

namespace PP3capas
{
    public class Comprobante
    {
        public int Tipo { get; set; }
        public int Numero { get; set; }
        public DateTime Fecha { get; set; }
        public int Empleado { get; set; }
        public int Cliente { get; set; }
        public float Monto { get; set; }

        public Comprobante(int tipo, int numero, DateTime fecha, int empleado, int cliente, float monto)
        {
            this.Tipo = tipo;
            this.Numero = numero;
            this.Fecha = fecha;
            this.Empleado = empleado;
            this.Cliente = cliente;
            this.Monto = monto;
        }
    }

}
