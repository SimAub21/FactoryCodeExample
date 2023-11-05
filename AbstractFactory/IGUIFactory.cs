using System;

namespace AbstractFactory
{
    public interface IGUIFactory
    {
        IButton createButton();
        ICheckbox createCheckbox();
    }
}
