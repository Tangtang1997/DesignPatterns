using System.Text;

namespace _04_DecoratorPattern;

public class EncryptedMessage(IMessage message) : MessageDecorator(message)
{
    public override string GetContent()
    {
        return Encrypt(Message.GetContent());
    }

    private string Encrypt(string content)
    {
        // 简单的加密逻辑（仅示例）
        return Convert.ToBase64String(Encoding.UTF8.GetBytes(content));
    }
}