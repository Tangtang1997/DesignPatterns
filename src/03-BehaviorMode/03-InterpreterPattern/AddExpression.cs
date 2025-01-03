namespace _03_InterpreterPattern;

public class AddExpression(Expression leftExpression, Expression rightExpression) : Expression
{
    public override int Interpret()
    {
        return leftExpression.Interpret() + rightExpression.Interpret();
    }
}