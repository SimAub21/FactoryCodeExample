using System;

namespace AbstractFactory
{
    public class WindowsCheckbox: ICheckbox
    {
        public WindowsCheckbox()
        {
            Console.WriteLine("A windows checkbox was created");
        }
    }
}
