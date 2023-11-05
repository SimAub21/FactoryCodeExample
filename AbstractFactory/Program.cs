using System;

namespace AbstractFactory
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Client client = new Client(OSType.Linux);
        }
    }
}
