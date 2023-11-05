using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FactoryMethod
{
    public class VehicleSimpleFactory
    {
        public static IVehicle createVehicle(VehicleType type)
        {
            switch(type)
            {
                case VehicleType.Car:
                    return new Car();
                case VehicleType.Bus:   
                    return new Bus();
                case VehicleType.Ship:
                    return new Ship();
                default:
                    return null;
            }
        }
    }
}
