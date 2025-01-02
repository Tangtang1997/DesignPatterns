namespace _01_AdapterPattern;

public class LegacyTextFormatter
{
    public string FormatString(string str)
    {
        // 旧的文本格式化逻辑
        return $"[Legacy] {str}";
    }
}