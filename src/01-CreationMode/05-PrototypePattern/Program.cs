// See https://aka.ms/new-console-template for more information
using _05_PrototypePattern;

Console.WriteLine("Hello, World!");

// 创建原型文档
WordDocument wordDoc = new WordDocument { Content = "This is a Word document." };
PdfDocument pdfDoc = new PdfDocument { Content = "This is a PDF document." };

// 通过克隆创建新文档
IDocument clonedWordDoc = wordDoc.Clone();
IDocument clonedPdfDoc = pdfDoc.Clone();

// 打印原型文档和克隆文档
wordDoc.Print();
clonedWordDoc.Print();
pdfDoc.Print();
clonedPdfDoc.Print();