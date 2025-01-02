namespace _02_AbstractFactoryPattern;

public interface IUiFactory
{
    IButton CreateButton();
    ITextBox CreateTextBox();
}