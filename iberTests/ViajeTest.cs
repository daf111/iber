using Iber.Conductores;
using Iber.MetodosPago;
using Iber.Vehiculos;
using Iber.Viajeros;
using Iber.Viajes;
using System;
using Xunit;

namespace iberTests
{
    public class ViajeTest
    {
        [Fact]
        public void CalcularCosto_ViajeroVip_CalculoCorrecto()
        {
            //Arrange
            float costoEstimado = 925;
            Efectivo efectivo = new Efectivo();
            Viajero viajero = new Vip("Juan", "Perez", "1157845875");
            Vehiculo vehiculo = new IberX();
            Conductor conductor = new Conductor(vehiculo);
            Viaje viaje = new Viaje(100, 2, conductor, efectivo, viajero);

            //Act
            float costoCalculado = viaje.CalcularCosto();

            //Assert
            Assert.Equal(costoEstimado, costoCalculado);
        }
    }
}
