using System;

namespace FactoryMethod
{
    internal class Bus : IVehicle
    {
        public void ShowInformation()
        {
            Console.WriteLine("Ich bin ein Bus");
        }
    }
}
