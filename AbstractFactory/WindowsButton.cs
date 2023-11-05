using System;

namespace AbstractFactory
{
    public  class WindowsButton: IButton
    {
        public WindowsButton()
        {
            Console.WriteLine("A windows button was created");
        }
    }
}
