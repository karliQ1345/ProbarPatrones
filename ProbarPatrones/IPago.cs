using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProbarPatrones
{
    public interface IPago
    {
        void ProcesarPago(double monto);
    }
}
