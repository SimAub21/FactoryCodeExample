using System;

namespace AbstractFactory
{
    public class LinuxButton: IButton
    {
        public LinuxButton()
        {
            Console.WriteLine("A linux button was created");
        }
    }
}
