using Iber.Conductores;
using Iber.MetodosPago;
using Iber.Viajeros;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Iber.Viajes
{
    public class Viaje
    {
        private float cantidadKilometros;
        private int numeroPasajeros;
        private Conductor conductor;
        private MetodoPago metodoPago;
        private Viajero viajero;

        public Viaje(float cantidadKilometros, int numeroPasajeros, Conductor conductor, MetodoPago metodoPago, Viajero viajero)
        {
            this.cantidadKilometros = cantidadKilometros;
            this.numeroPasajeros = numeroPasajeros;
            this.conductor = conductor;
            this.metodoPago = metodoPago;
            this.viajero = viajero;
        }

        public void CambiarViajero(Viajero viajero)
        {
            this.viajero = viajero;
        }

        public float CalcularCosto()
        {
            float costoBajadaBandera = this.viajero.CostoBajadaBandera();
            float costoValorPorKilometro = this.viajero.CostoPorKilometro();
            float costoViaje = costoBajadaBandera + (this.cantidadKilometros * costoValorPorKilometro);

            return this.metodoPago.CalculoCosto(costoViaje);
        }
    }
}
