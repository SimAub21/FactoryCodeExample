using System;

namespace AbstractFactory
{
    public class LinuxCheckbox: ICheckbox
    {
        public LinuxCheckbox()
        {
            Console.WriteLine("A linux checkbox was created");
        }
    }
}
