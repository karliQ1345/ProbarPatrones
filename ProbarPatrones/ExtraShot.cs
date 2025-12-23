using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProbarPatrones
{
    public class ExtraShot : ProductoDecorator
    {
        private double precioExtra = 0.75;

        public ExtraShot(IProducto producto) : base(producto) { }

        public override string GetNombre() => productobase.GetNombre() + " + Shot Extra";
        public override double GetPrecio() => productobase.GetPrecio() + precioExtra;
    }
}
