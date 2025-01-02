namespace _04_DecoratorPattern;

public class TextMessage(string content) : IMessage
{
    public string GetContent()
    {
        return content;
    }
}