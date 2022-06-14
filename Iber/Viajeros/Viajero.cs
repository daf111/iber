using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Iber.Viajeros
{
    public abstract class Viajero
    {
        protected string nombre;
        protected string apellido;
        protected string telefono;
        protected float bajadaBandera;
        protected float valorPorKilometro;

        public Viajero(
            string nombre,
            string apellido,
            string telefono,
            float bajadaBandera,
            float valorPorKilometro
        )
        {
            this.nombre = nombre;
            this.apellido = apellido;
            this.telefono = telefono;
            this.bajadaBandera = bajadaBandera;
            this.valorPorKilometro = valorPorKilometro;
        }

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
