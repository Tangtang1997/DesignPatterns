namespace _05_MediatorPattern;

public class ChatUser(IChatRoomMediator mediator, string name) : User(mediator, name)
{
    public override void Send(string message)
    {
        Console.WriteLine($"{Name} sends: {message}");
        Mediator.SendMessage(message, this);
    }

    public override void Receive(string message)
    {
        Console.WriteLine($"{Name} receives: {message}");
    }
}