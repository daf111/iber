using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Iber.Viajeros
{
    class Comun : Viajero
    {
        public static float BAJADA_BANDERA = 100;
        public static float VALOR_POR_KILOMETRO = 10;

        public Comun(
            string nombre,
            string apellido,
            string telefono
        ) : base(
            nombre,
            apellido,
            telefono,
            Comun.BAJADA_BANDERA,
            Comun.VALOR_POR_KILOMETRO
        )
        {
        }
    }
}
