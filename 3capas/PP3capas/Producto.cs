using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PP3capas
{
    public class Producto
    {
        public int codigo {  get; set; }
        public string NombreProducto { get; set; }
        public string NombreCorto { get; set; }
        public float PrecioCosto { get; set; }
        public float Stock {  get; set; }
        public float StockMinimo { get; set; }
        public int PorcentajeGanancia { get; set; }

        public Producto(int codigo, string nombreProducto, string nombreCorto, float precioCosto, float stock, float stockMinimo, int porcentajeGanancia)
        {
            this.codigo = codigo;
            this.NombreProducto = nombreProducto;
            this.NombreCorto = nombreCorto;
            this.PrecioCosto = precioCosto;
            this.Stock = stock;
            this.StockMinimo = stockMinimo;
            this.PorcentajeGanancia = porcentajeGanancia;
        }
    }
}
