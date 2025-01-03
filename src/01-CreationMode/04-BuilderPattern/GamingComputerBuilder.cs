namespace _04_BuilderPattern;

public class GamingComputerBuilder : IComputerBuilder
{
    private readonly Computer _computer = new();

    public void BuildCPU()
    {
        _computer.Cpu = "High-end CPU";
    }

    public void BuildGPU()
    {
        _computer.Gpu = "High-end GPU";
    }

    public void BuildRAM()
    {
        _computer.Ram = "16GB RAM";
    }

    public void BuildStorage()
    {
        _computer.Storage = "1TB SSD";
    }

    public Computer GetComputer()
    {
        return _computer;
    }
}