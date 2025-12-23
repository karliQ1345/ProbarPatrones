using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProbarPatrones
{
    public class Bebida : IProducto
    {
        private string nombre;
        private double precio;

        public Bebida(string nombre, double precio)
        {
            this.nombre = nombre;
            this.precio = precio;
        }

        public string GetNombre() => nombre;
        public double GetPrecio() => precio;
    }
}
