namespace _04_IteratorPattern;

public interface IIterator<out T>
{
    bool HasNext();
    T Next();
}