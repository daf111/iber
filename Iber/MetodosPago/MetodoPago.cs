using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Iber.MetodosPago
{
    abstract class MetodoPago
    {
        protected float recargoDescuento;

        public float CalculoCosto(float costoViaje)
        {
            return costoViaje + (costoViaje * (this.recargoDescuento / 100));
        }
    }
}
