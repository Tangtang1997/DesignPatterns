// See https://aka.ms/new-console-template for more information
using _02_AbstractFactoryPattern;

Console.WriteLine("Hello, World!");

IUiFactory factory;
IButton button;
ITextBox textBox;

// 创建Windows风格的UI组件
factory = new WinFactory();
button = factory.CreateButton();
textBox = factory.CreateTextBox();
button.Render();
textBox.Render();

// 创建Mac风格的UI组件
factory = new MacFactory();
button = factory.CreateButton();
textBox = factory.CreateTextBox();
button.Render();
textBox.Render();
