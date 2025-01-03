namespace _05_MediatorPattern;

public interface IChatRoomMediator
{
    void SendMessage(string message, User user);
    void AddUser(User user);
}