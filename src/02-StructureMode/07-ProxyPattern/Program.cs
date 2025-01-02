// See https://aka.ms/new-console-template for more information
using _07_ProxyPattern;

Console.WriteLine("Hello, World!");

IService authorizedProxy = new ServiceProxy(true);
authorizedProxy.Request();

IService unauthorizedProxy = new ServiceProxy(false);
unauthorizedProxy.Request();