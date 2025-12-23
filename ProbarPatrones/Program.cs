using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProbarPatrones
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // 1. Usar Fábricas para crear productos base
            ProductFactory fabricaBebidas = new BebidaFactory();
            IProducto miCafe = fabricaBebidas.CrearProducto("Café Americano", 2.00);

            // 2. Decorar el producto (Agregar extras)
            miCafe = new LecheDeslactosada(miCafe);
            miCafe = new ExtraShot(miCafe);

            // 3. Gestionar el pedido
            Pedido pedido1 = new Pedido();
            pedido1.AgregarProducto(miCafe);

            // 4. Elegir estrategia de pago y procesar
            pedido1.SetMetodoPago(new PagoTarjeta());
            pedido1.ProcesarPedido();

            pedido1.CambiarEstado("Entregado");
        }
    }
}
