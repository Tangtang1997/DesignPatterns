# Overview
The Builder Pattern is a creative design pattern that separates the construction process of a complex object from its representation so that the same construction process can create different representations. By using the Builder pattern, a complex object can be built step by step, and the internal representation of the object can be changed as needed.

# Structure
Builder mode contains the following roles:

1. Product: Represents the complex object being built.
2. Abstract Builder: Defines the interface for creating the various parts of the product.
3. ConcreteBuilder: Implements the Builder interface, builds and assembles the parts.
4. Director: Build an object that uses the Builder interface.

# Sample code
Let's say we have an application that needs to build different types of computers (such as gaming computers and office computers).

**Product**
```csharp
public class Computer
{
    public string CPU { get; set; }
    public string GPU { get; set; }
    public string RAM { get; set; }
    public string Storage { get; set; }

    public override string ToString()
    {
        return $"CPU: {CPU}, GPU: {GPU}, RAM: {RAM}, Storage: {Storage}";
    }
}
```

**Abstract Builder**
```csharp
public interface IComputerBuilder
{
    void BuildCPU();
    void BuildGPU();
    void BuildRAM();
    void BuildStorage();
    Computer GetComputer();
}
```

**Specific Builder**
```csharp
public class GamingComputerBuilder : IComputerBuilder
{
    private Computer _computer = new Computer();

    public void BuildCPU()
    {
        _computer.CPU = "High-end CPU";
    }

    public void BuildGPU()
    {
        _computer.GPU = "High-end GPU";
    }

    public void BuildRAM()
    {
        _computer.RAM = "16GB RAM";
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

public class OfficeComputerBuilder : IComputerBuilder
{
    private Computer _computer = new Computer();

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
```

**Director**
```csharp
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
```

**Client Code**
```csharp
class Program
{
    static void Main(string[] args)
    {
        ComputerDirector director = new ComputerDirector();

        // build gaming computer
        IComputerBuilder gamingBuilder = new GamingComputerBuilder();
        director.Construct(gamingBuilder);
        Computer gamingComputer = gamingBuilder.GetComputer();
        Console.WriteLine("Gaming Computer: " + gamingComputer);

        // build office computer
        IComputerBuilder officeBuilder = new OfficeComputerBuilder();
        director.Construct(officeBuilder);
        Computer officeComputer = officeBuilder.GetComputer();
        Console.WriteLine("Office Computer: " + officeComputer);
    }
}
```

# Application Scenarios
Builder mode works in the following scenarios:

1. When the algorithm for creating complex objects should be independent of the components of that object and how they are assembled.
3. When the construction process must allow different representations of the object being constructed.

# Advantages and disadvantages
**Advantages**
Better control: The Builder model makes the building process clearer and more controllable by building objects step by step.
* Flexibility: The internal representation of the object can be changed as needed to adapt to different needs.

**Disadvantages**
Increased code complexity: Each concrete builder needs to implement an abstract builder interface, resulting in increased code volume.
