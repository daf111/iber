using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Iber.MetodosPago
{
    class Efectivo : MetodoPago
    {
        private static float RECARGO_DESCUENTO = 0;

        public Efectivo()
        {
            this.recargoDescuento = Efectivo.RECARGO_DESCUENTO;
        }
    }
}
