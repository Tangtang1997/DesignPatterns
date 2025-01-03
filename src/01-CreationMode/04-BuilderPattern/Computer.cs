namespace _04_BuilderPattern;

public class Computer
{
    public string Cpu { get; set; } = string.Empty;
    public string Gpu { get; set; } = string.Empty;
    public string Ram { get; set; } = string.Empty;
    public string Storage { get; set; } = string.Empty;

    public override string ToString()
    {
        return $"CPU: {Cpu}, GPU: {Gpu}, RAM: {Ram}, Storage: {Storage}";
    }
}