// See https://aka.ms/new-console-template for more information
using _05_MediatorPattern;

Console.WriteLine("Hello, World!");

IChatRoomMediator chatRoom = new ChatRoom();

User user1 = new ChatUser(chatRoom, "Alice");
User user2 = new ChatUser(chatRoom, "Bob");
User user3 = new ChatUser(chatRoom, "Charlie");

chatRoom.AddUser(user1);
chatRoom.AddUser(user2);
chatRoom.AddUser(user3);

user1.Send("Hello, everyone!");
user2.Send("Hi, Alice!");