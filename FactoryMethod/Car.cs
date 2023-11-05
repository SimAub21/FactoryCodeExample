using System;
using System.Collections.Generic;
using System.Linq;
using System;

namespace FactoryMethod
{
    public class Car: IVehicle
    {
        public void ShowInformation()
        {
            Console.WriteLine("I am a Car");
        }
    }
}
