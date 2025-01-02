// See https://aka.ms/new-console-template for more information
using _03_CompositePattern;
using Directory = _03_CompositePattern.Directory;
using File = _03_CompositePattern.File;

Console.WriteLine("Hello, World!");

IFileSystemComponent file1 = new File("File1.txt");
IFileSystemComponent file2 = new File("File2.txt");
IFileSystemComponent file3 = new File("File3.txt");

Directory folder1 = new Directory("Folder1");
folder1.Add(file1);

Directory folder2 = new Directory("Folder2");
folder2.Add(file2);
folder2.Add(file3);

Directory root = new Directory("Root");
root.Add(folder1);
root.Add(folder2);

root.Display("");
