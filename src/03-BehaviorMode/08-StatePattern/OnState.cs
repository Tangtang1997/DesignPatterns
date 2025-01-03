namespace _08_StatePattern;

public class OnState : IState
{
    public void Handle(LightSwitch context)
    {
        Console.WriteLine("Light is already ON. Turning it OFF now.");
        context.SetState(new OffState());
    }
}