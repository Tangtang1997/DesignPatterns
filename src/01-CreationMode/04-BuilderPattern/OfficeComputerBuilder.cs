namespace _04_BuilderPattern;

public class OfficeComputerBuilder : IComputerBuilder
{
    private readonly Computer _computer = new();

    public void BuildCPU()
    {
        _computer.CPU = "Mid-range CPU";
    }

    public void BuildGPU()
    {
        _computer.GPU = "Integrated GPU";
    }

    public void BuildRAM()
    {
        _computer.RAM = "8GB RAM";
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