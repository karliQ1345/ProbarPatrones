using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProbarPatrones
{
    public class Pedido
    {
        private List<IProducto> listaProductos = new List<IProducto>();
        private IPago metodoPago;
        public string Estado { get; private set; } = "Creado";

        public void AgregarProducto(IProducto p) => listaProductos.Add(p);

        public void SetMetodoPago(IPago metodo) => this.metodoPago = metodo;

        public void CambiarEstado(string nuevoEstado)
        {
            this.Estado = nuevoEstado;
            Console.WriteLine($"[Notificación] El pedido ha cambiado a: {this.Estado}");
        }
        public void ProcesarPedido()
        {
            double total = 0;
            Console.WriteLine("\n--- RESUMEN DEL PEDIDO ---");
            foreach (var p in listaProductos)
            {
                Console.WriteLine($"- {p.GetNombre()}: ${p.GetPrecio():F2}");
                total += p.GetPrecio();
            }
            Console.WriteLine($"TOTAL: ${total:F2}");
            metodoPago.ProcesarPago(total);
            CambiarEstado("Preparado");
        }
    }
    }
