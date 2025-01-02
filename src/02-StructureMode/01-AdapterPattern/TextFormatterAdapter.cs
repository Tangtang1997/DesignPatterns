namespace _01_AdapterPattern;

public class TextFormatterAdapter(LegacyTextFormatter legacyTextFormatter) : ITextFormatter
{
    public string FormatText(string text)
    {
        // 调用适配者的方法
        return legacyTextFormatter.FormatString(text);
    }
}