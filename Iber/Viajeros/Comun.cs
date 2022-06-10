using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Iber.Viajeros
{
    class Comun : Viajero
    {
        private static float BAJADA_BANDERA = 100;
        private static float VALOR_POR_KILOMETRO = 10;

        public Comun()
        {
            this.bajadaBandera = Comun.BAJADA_BANDERA;
            this.valorPorKilometro = Comun.VALOR_POR_KILOMETRO;
        }

        public Comun(string nombre, string apellido, string telefono)
        {
            this.nombre = nombre;
            this.apellido = apellido;
            this.telefono = telefono;
            this.bajadaBandera = Comun.BAJADA_BANDERA;
            this.valorPorKilometro = Comun.VALOR_POR_KILOMETRO;
        }
    }
}
