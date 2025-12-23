using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProbarPatrones
{
    public class LecheDeslactosada : ProductoDecorator
    {
        private double precioExtra = 0.50;

        public LecheDeslactosada(IProducto producto) : base(producto) { }

        public override string GetNombre() => productobase.GetNombre() + " + Leche Deslactosada";
        public override double GetPrecio() => productobase.GetPrecio() + precioExtra;
    }
}
