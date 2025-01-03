# Overview

Mediator Pattern is a behavioral design pattern that encapsulates the interaction of a series of objects by introducing a mediator object, so that objects do not need to explicitly reference each other, so that they are loosely coupled. The mediator mode coordinates the communication between objects through the mediator object, simplifies the complex interaction between objects, and improves the maintainability and expansibility of the system.

# Structure

The mediator pattern includes the following roles:

1. Mediator: Define an interface for communicating with each colleague object.
2. ConcreteMediator: Implements a mediator interface to coordinate interactions between colleague objects.
3. Colleague: Defines an interface for communicating with mediator objects.
4. ConcreteColleague: Implements a colleague interface to communicate with mediator objects.

# Sample Code

Suppose we have an application that needs to coordinate communication between multiple users in a chat room.

**Mediator Interface**

```csharp
public interface IChatRoomMediator
{
    void SendMessage(string message, User user);
    void AddUser(User user);
}
```

**Specific Mediator**

```csharp
public class ChatRoom : IChatRoomMediator
{
    private List<User> _users = new List<User>();

    public void AddUser(User user)
    {
        _users.Add(user);
    }

    public void SendMessage(string message, User user)
    {
        foreach (var u in _users)
        {
            // 消息不应该发送给发送消息的用户
            if (u != user)
            {
                u.Receive(message);
            }
        }
    }
}
```

**Colleague Class**

```csharp
public abstract class User
{
    protected IChatRoomMediator _mediator;
    protected string _name;

    public User(IChatRoomMediator mediator, string name)
    {
        _mediator = mediator;
        _name = name;
    }

    public abstract void Send(string message);
    public abstract void Receive(string message);
}
```

**Specific Colleague**

```csharp
public class ChatUser : User
{
    public ChatUser(IChatRoomMediator mediator, string name) : base(mediator, name) { }

    public override void Send(string message)
    {
        Console.WriteLine($"{_name} sends: {message}");
        _mediator.SendMessage(message, this);
    }

    public override void Receive(string message)
    {
        Console.WriteLine($"{_name} receives: {message}");
    }
}
```

**Client Code**

```csharp
class Program
{
    static void Main(string[] args)
    {
        IChatRoomMediator chatRoom = new ChatRoom();

        User user1 = new ChatUser(chatRoom, "Alice");
        User user2 = new ChatUser(chatRoom, "Bob");
        User user3 = new ChatUser(chatRoom, "Charlie");

        chatRoom.AddUser(user1);
        chatRoom.AddUser(user2);
        chatRoom.AddUser(user3);

        user1.Send("Hello, everyone!");
        user2.Send("Hi, Alice!");
    }
}
```

# Application Scenarios

The mediator mode works in the following scenarios:

1. Complex object interaction: When the interaction relationship between objects is complex and presents a network structure, the intermediary mode can be used to simplify the interaction between objects.
2. Decouple objects: When you need to decouple the tight coupling between multiple objects, you can use the mediator mode.

# Advantages and disadvantages

**Advantages**

* Reduced coupling between objects: The mediator pattern reduces the coupling between objects by introducing mediator objects, making the interaction between objects more flexible.
* Simplify interactions between objects: The Broker pattern encapsulates complex object interaction logic in broker objects, simplifying interactions between objects.

**Disadvantages**

* Increased mediator complexity: Mediator objects take on more interaction logic, which can cause mediator objects to become complex and difficult to maintain.
* Can cause performance problems: If the interaction between objects is frequent, it can cause the mediator to become a performance bottleneck.