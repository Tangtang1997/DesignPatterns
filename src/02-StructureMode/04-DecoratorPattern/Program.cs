// See https://aka.ms/new-console-template for more information
using _04_DecoratorPattern;

Console.WriteLine("Hello, World!");

IMessage message = new TextMessage("Hello, World!");

// 添加加密装饰
IMessage encryptedMessage = new EncryptedMessage(message);
Console.WriteLine(encryptedMessage.GetContent());

// 添加压缩装饰
IMessage compressedMessage = new CompressedMessage(message);
Console.WriteLine(compressedMessage.GetContent());

// 添加加密和压缩装饰
IMessage encryptedAndCompressedMessage = new CompressedMessage(encryptedMessage);
Console.WriteLine(encryptedAndCompressedMessage.GetContent());
