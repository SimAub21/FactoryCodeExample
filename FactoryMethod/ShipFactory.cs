using System;

namespace FactoryMethod
{
    public class ShipFactory : VehicleFactory
    {
        public override IVehicle GetVehicle()
        {
            return new Ship();
        }
    }
}
