using Iber.Vehiculos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Iber.Conductores
{
    public class Conductor
    {
        private Vehiculo vehiculo;

        public Conductor(Vehiculo vehiculo)
        {
            this.vehiculo = vehiculo;
        }
    }
}
