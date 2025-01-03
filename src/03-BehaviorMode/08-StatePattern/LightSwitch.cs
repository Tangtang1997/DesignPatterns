namespace _08_StatePattern;

public class LightSwitch
{
    private IState _state = new OffState(); // 初始状态为关闭

    public void SetState(IState state)
    {
        _state = state;
    }

    public void PressSwitch()
    {
        _state.Handle(this);
    }
}