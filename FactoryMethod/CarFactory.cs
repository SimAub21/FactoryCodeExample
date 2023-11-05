using System;

namespace FactoryMethod
{
    public class CarFactory: VehicleFactory
    {
        public override IVehicle GetVehicle()
        {
            return new Car();
        }
    }
}
