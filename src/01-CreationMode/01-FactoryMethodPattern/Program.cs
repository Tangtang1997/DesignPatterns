// See https://aka.ms/new-console-template for more information
using _01_FactoryMethodPattern;

Console.WriteLine("Hello, World!");

LoggerFactory factory;
ILogger logger;

// 创建文件日志记录器
factory = new FileLoggerFactory();
logger = factory.CreateLogger();
logger.Log("This is a file log message.");

// 创建数据库日志记录器
factory = new DatabaseLoggerFactory();
logger = factory.CreateLogger();
logger.Log("This is a database log message.");