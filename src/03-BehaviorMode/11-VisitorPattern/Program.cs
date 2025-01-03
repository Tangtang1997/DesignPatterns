// See https://aka.ms/new-console-template for more information

using _11_VisitorPattern;

Console.WriteLine("Hello, World!");

List<IShape> shapes =
[
    new Circle(5),
    new Rectangle(4, 6)
];

IVisitor areaVisitor = new AreaVisitor();
IVisitor drawVisitor = new DrawVisitor();

foreach (var shape in shapes)
{
    shape.Accept(areaVisitor);
    shape.Accept(drawVisitor);
}
