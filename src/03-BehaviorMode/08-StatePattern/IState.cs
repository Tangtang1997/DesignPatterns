namespace _08_StatePattern;

public interface IState
{
    void Handle(LightSwitch context);
}