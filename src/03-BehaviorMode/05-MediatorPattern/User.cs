namespace _05_MediatorPattern;

public abstract class User(IChatRoomMediator mediator, string name)
{
    protected IChatRoomMediator Mediator = mediator;
    protected string Name = name;

    public abstract void Send(string message);
    public abstract void Receive(string message);
}