namespace _04_BuilderPattern;

public class OfficeComputerBuilder : IComputerBuilder
{
    private readonly Computer _computer = new();

    public void BuildCPU()
    {
        _computer.Cpu = "Mid-range CPU";
    }

    public void BuildGPU()
    {
        _computer.Gpu = "Integrated GPU";
    }

    public void BuildRAM()
    {
        _computer.Ram = "8GB RAM";
    }

    public void BuildStorage()
    {
        _computer.Storage = "512GB SSD";
    }

    public Computer GetComputer()
    {
        return _computer;
    }
}