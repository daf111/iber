using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Iber.Viajeros
{
    abstract class Viajero
    {
        protected string nombre;
        protected string apellido;
        protected string telefono;
        protected float bajadaBandera;
        protected float valorPorKilometro;

        public float CostoBajadaBandera()
        {
            return this.bajadaBandera;
        }
        public float CostoPorKilometro()
        {
            return this.valorPorKilometro;
        }
    }
}
