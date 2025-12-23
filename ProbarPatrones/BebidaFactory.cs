using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProbarPatrones
{
    public class BebidaFactory : ProductFactory
    {
        public override IProducto CrearProducto(string nombre, double precio) => new Bebida(nombre, precio);
    }
}
