namespace _04_DecoratorPattern;

public abstract class MessageDecorator(IMessage message) : IMessage
{
    protected IMessage Message = message;

    public abstract string GetContent();
}