// See https://aka.ms/new-console-template for more information
using _04_BuilderPattern;

Console.WriteLine("Hello, World!");

ComputerDirector director = new ComputerDirector();

// 构建游戏电脑
IComputerBuilder gamingBuilder = new GamingComputerBuilder();
director.Construct(gamingBuilder);
Computer gamingComputer = gamingBuilder.GetComputer();
Console.WriteLine("Gaming Computer: " + gamingComputer);

// 构建办公电脑
IComputerBuilder officeBuilder = new OfficeComputerBuilder();
director.Construct(officeBuilder);
Computer officeComputer = officeBuilder.GetComputer();
Console.WriteLine("Office Computer: " + officeComputer);
