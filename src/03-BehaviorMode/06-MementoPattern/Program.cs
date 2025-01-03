// See https://aka.ms/new-console-template for more information
using _06_MementoPattern;

Console.WriteLine("Hello, World!");

TextEditor editor = new TextEditor();
TextEditorCaretaker caretaker = new TextEditorCaretaker();

editor.Text = "Hello, World!";
caretaker.SaveState(editor);

editor.Text = "Hello, Design Patterns!";
caretaker.SaveState(editor);

Console.WriteLine("Current Text: " + editor.Text);

caretaker.RestoreState(editor);
Console.WriteLine("Restored Text: " + editor.Text);

caretaker.RestoreState(editor);
Console.WriteLine("Restored Text: " + editor.Text);
