namespace _05_PrototypePattern;

public class WordDocument : IDocument
{
    public string Content { get; set; } = string.Empty;

    public IDocument Clone()
    {
        return (IDocument)MemberwiseClone();
    }

    public void Print()
    {
        Console.WriteLine($"Word Document Content: {Content}");
    }
}