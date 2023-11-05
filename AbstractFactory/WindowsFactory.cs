using System;

namespace AbstractFactory
{
    public  class WindowsFactory : IGUIFactory
    {
        public IButton createButton()
        {
            return new WindowsButton();
        }

        public ICheckbox createCheckbox()
        {
            return new WindowsCheckbox();
        }
    }
}
