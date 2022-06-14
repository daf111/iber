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

        public Vip(
            string nombre,
            string apellido,
            string telefono
        ) : base(
            nombre,
            apellido,
            telefono,
            Vip.BAJADA_BANDERA,
            Vip.VALOR_POR_KILOMETRO
        )
        {
        }
    }
}
