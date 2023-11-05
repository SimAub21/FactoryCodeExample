using System;

namespace FactoryMethod
{
    class Program
    {
        static void Main(string[] args)
        {
            IVehicle car = VehicleSimpleFactory.createVehicle(VehicleType.Car);
            IVehicle bus = VehicleSimpleFactory.createVehicle(VehicleType.Bus);
            IVehicle ship = VehicleSimpleFactory.createVehicle(VehicleType.Ship);

            IVehicle car2 = new CarFactory().GetVehicle();
            IVehicle bus2 = new BusFactory().GetVehicle();
            IVehicle ship2 = new ShipFactory().GetVehicle();

            car2.ShowInformation();
            bus2.ShowInformation();
            ship2.ShowInformation();
        }
    }
}