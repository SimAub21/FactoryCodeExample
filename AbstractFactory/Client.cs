using System;

namespace AbstractFactory
{
    public class Client
    {
        private IGUIFactory _factory;
        private IButton _button;
        private ICheckbox _checkbox;

        public Client(OSType osType)
        {
            // depending on the os, a windows or linux factory is initialized
            switch (osType)
            {
                case OSType.Windows:
                    _factory = new WindowsFactory();
                    break;
                case OSType.Linux:
                    _factory = new LinuxFactory();
                    break;
                default:
                    throw new Exception("GUI Factory init failed");
            }

            // Create the button and checkbox object
            _button = _factory.createButton();
            _checkbox = _factory.createCheckbox();
        }
    }
}
