using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProbarPatrones
{
    public abstract class ProductoDecorator : IProducto
    {
        protected IProducto productobase; // Rol configurado en el diagrama

        protected ProductoDecorator(IProducto producto)
        {
            this.productobase = producto;
        }

        public virtual string GetNombre() => productobase.GetNombre();
        public virtual double GetPrecio() => productobase.GetPrecio();
    }
}
