namespace _04_BuilderPattern;

public interface IComputerBuilder
{
    void BuildCPU();
    void BuildGPU();
    void BuildRAM();
    void BuildStorage();
    Computer GetComputer();
}