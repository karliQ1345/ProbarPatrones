using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProbarPatrones
{
    public class PagoTarjeta : IPago
    {
        public void ProcesarPago(double monto) => Console.WriteLine($"[Pago] Pagando ${monto} con tarjeta de crédito.");
    }
}
