namespace _08_StatePattern;

public class OffState : IState
{
    public void Handle(LightSwitch context)
    {
        Console.WriteLine("Light is OFF. Turning it ON now.");
        context.SetState(new OnState());
    }
}