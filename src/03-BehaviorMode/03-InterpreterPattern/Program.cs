// See https://aka.ms/new-console-template for more information
using _03_InterpreterPattern;

Console.WriteLine("Hello, World!");

// 构建抽象语法树
Expression expression = new AddExpression(
    new NumberExpression(5),
    new SubtractExpression(
        new NumberExpression(10),
        new NumberExpression(3)
    )
);

// 解释并计算表达式
int result = expression.Interpret();
Console.WriteLine("Result: " + result); // 输出: Result: 12