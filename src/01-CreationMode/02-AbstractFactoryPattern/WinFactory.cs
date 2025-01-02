namespace _02_AbstractFactoryPattern;

public class WinFactory : IUiFactory
{
    public IButton CreateButton()
    {
        return new WinButton();
    }

    public ITextBox CreateTextBox()
    {
        return new WinTextBox();
    }
}