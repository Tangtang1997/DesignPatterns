namespace _03_InterpreterPattern;

public class SubtractExpression(Expression leftExpression, Expression rightExpression) : Expression
{
    public override int Interpret()
    {
        return leftExpression.Interpret() - rightExpression.Interpret();
    }
}