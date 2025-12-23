using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProbarPatrones
{
    public abstract class ProductFactory
    {
        public abstract IProducto CrearProducto(string nombre, double precio);
    }
}
