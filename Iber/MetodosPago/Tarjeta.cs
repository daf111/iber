using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Iber.MetodosPago
{
    class Tarjeta : MetodoPago
    {
        private static float RECARGO_DESCUENTO = 5;

        public Tarjeta()
        {
            this.recargoDescuento = Tarjeta.RECARGO_DESCUENTO;
        }
    }
}
