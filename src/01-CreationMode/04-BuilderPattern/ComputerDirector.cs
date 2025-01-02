namespace _04_BuilderPattern;

public class ComputerDirector
{
    public void Construct(IComputerBuilder builder)
    {
        builder.BuildCPU();
        builder.BuildGPU();
        builder.BuildRAM();
        builder.BuildStorage();
    }
}