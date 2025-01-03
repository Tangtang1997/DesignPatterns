// See https://aka.ms/new-console-template for more information

using _01_ChainOfResponsibilityPattern;

Console.WriteLine("Hello, World!");

Logger infoLogger = new InfoLogger();
Logger warningLogger = new WarningLogger();
Logger errorLogger = new ErrorLogger();

infoLogger.SetNextLogger(warningLogger);
warningLogger.SetNextLogger(errorLogger);

infoLogger.LogMessage(1, "This is an information.");
infoLogger.LogMessage(2, "This is a warning.");
infoLogger.LogMessage(3, "This is an error.");