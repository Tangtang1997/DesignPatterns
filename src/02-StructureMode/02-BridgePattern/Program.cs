// See https://aka.ms/new-console-template for more information
using _02_BridgePattern;

Console.WriteLine("Hello, World!");

IColor red = new RedColor();
IColor blue = new BlueColor();

Shape circle = new Circle(red);
Shape rectangle = new Rectangle(blue);

circle.Draw();
rectangle.Draw();