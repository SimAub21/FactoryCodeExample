using System;

namespace FactoryMethod
{
    public class BusFactory : VehicleFactory
    {
        public override IVehicle GetVehicle()
        {
            return new Bus();
        }
    }
}
