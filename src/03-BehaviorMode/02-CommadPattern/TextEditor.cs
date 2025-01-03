using System.Text;

namespace _02_CommadPattern;

public class TextEditor
{
    private readonly StringBuilder _text = new();

    public void Write(string text)
    {
        _text.Append(text);
    }

    public void Erase(int length)
    {
        if (length <= _text.Length)
        {
            _text.Remove(_text.Length - length, length);
        }
    }

    public string GetText()
    {
        return _text.ToString();
    }
}