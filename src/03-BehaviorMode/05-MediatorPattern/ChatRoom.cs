namespace _05_MediatorPattern;

public class ChatRoom : IChatRoomMediator
{
    private readonly List<User> _users = [];

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