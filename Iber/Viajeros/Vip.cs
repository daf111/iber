using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Iber.Viajeros
{
    class Vip : Viajero
    {
        private static float BAJADA_BANDERA = 25;
        private static float VALOR_POR_KILOMETRO = 9;

        public Vip()
        {
            this.bajadaBandera = Vip.BAJADA_BANDERA;
            this.valorPorKilometro = Vip.VALOR_POR_KILOMETRO;
        }
        public Vip(string nombre, string apellido, string telefono)
        {
            this.nombre = nombre;
            this.apellido = apellido;
            this.telefono = telefono;
            this.bajadaBandera = Vip.BAJADA_BANDERA;
            this.valorPorKilometro = Vip.VALOR_POR_KILOMETRO;
        }
    }
}
