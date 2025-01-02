namespace _05_PrototypePattern;

public class PdfDocument : IDocument
{
    public string Content { get; set; } = string.Empty;

    public IDocument Clone()
    {
        return (IDocument)MemberwiseClone();
    }

    public void Print()
    {
        Console.WriteLine($"PDF Document Content: {Content}");
    }
}