namespace _03_InterpreterPattern;

public class NumberExpression(int number) : Expression
{
    public override int Interpret()
    {
        return number;
    }
}