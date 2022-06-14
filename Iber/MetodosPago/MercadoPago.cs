using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Iber.MetodosPago
{
    public class MercadoPago : MetodoPago
    {
        private static float RECARGO_DESCUENTO = -10;

        public MercadoPago()
        {
            this.recargoDescuento = MercadoPago.RECARGO_DESCUENTO;
        }
    }
}
