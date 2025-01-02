namespace _05_PrototypePattern;

public interface IDocument
{
    IDocument Clone();
    void Print();
}