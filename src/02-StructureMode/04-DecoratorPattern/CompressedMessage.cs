namespace _04_DecoratorPattern;

public class CompressedMessage(IMessage message) : MessageDecorator(message)
{
    public override string GetContent()
    {
        return Compress(Message.GetContent());
    }

    private string Compress(string content)
    {
        // 简单的压缩逻辑（仅示例）
        return $"Compressed({content})";
    }
}