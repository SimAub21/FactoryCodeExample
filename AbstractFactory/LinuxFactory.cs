using System;

namespace AbstractFactory
{
    public class LinuxFactory : IGUIFactory
    {
        IButton IGUIFactory.createButton()
        {
            return new LinuxButton();
        }

        ICheckbox IGUIFactory.createCheckbox()
        {
            return new LinuxCheckbox();
        }
    }
}
