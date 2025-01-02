// See https://aka.ms/new-console-template for more information
using _01_AdapterPattern;

Console.WriteLine("Hello, World!");

LegacyTextFormatter legacyFormatter = new LegacyTextFormatter();
ITextFormatter formatter = new TextFormatterAdapter(legacyFormatter);

string formattedText = formatter.FormatText("Hello, World!");
Console.WriteLine(formattedText);
