// See https://aka.ms/new-console-template for more information
using _02_CommadPattern;

Console.WriteLine("Hello, World!");

TextEditor editor = new TextEditor();
TextEditorInvoker invoker = new TextEditorInvoker();

ICommand writeCommand1 = new WriteCommand(editor, "Hello, ");
ICommand writeCommand2 = new WriteCommand(editor, "World!");

invoker.ExecuteCommand(writeCommand1);
invoker.ExecuteCommand(writeCommand2);

Console.WriteLine("Text after write commands: " + editor.GetText());

invoker.Undo();
Console.WriteLine("Text after undo: " + editor.GetText());

invoker.Undo();
Console.WriteLine("Text after second undo: " + editor.GetText());