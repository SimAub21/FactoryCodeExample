using System;

namespace FactoryMethod
{
    internal class Ship : IVehicle
    {
        public void ShowInformation()
        {
            Console.WriteLine("Ich bin ein Ship");
        }
    }
}
