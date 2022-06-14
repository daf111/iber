using Iber.Conductores;
using Iber.MetodosPago;
using Iber.Vehiculos;
using Iber.Viajeros;
using Iber.Viajes;
using System;

namespace Iber
{
    class Program
    {
        static void Main(string[] args)
        {
            Efectivo efectivo = new Efectivo();
            Viajero viajero = new Comun("Juan", "Perez", "1157845875");
            Vehiculo vehiculo = new IberX();
            Conductor conductor = new Conductor(vehiculo);

            Viaje viaje = new Viaje(100, 2, conductor, efectivo, viajero);
            viaje.CalcularCosto();

            viajero = new Vip("Juan", "Perez", "1157845875");
            viaje.CambiarViajero(viajero);
            Console.WriteLine(viaje.CalcularCosto());
        }
    }
}
