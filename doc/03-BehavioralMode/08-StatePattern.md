# Overview

A State Pattern is a behavioral design pattern that allows an object to change its behavior when its internal state changes. By encapsulating state-related behavior into a separate state class, the state pattern allows an object's behavior to change as the state changes. State mode makes state transitions more explicit and controllable, improving the flexibility and maintainability of the system.

# Structure

The status mode contains the following roles:

1. Context: Defines the interface that the customer is interested in and maintains an instance of a specific state class that defines the current state.
2. State: Defines an interface that encapsulates the behavior associated with a particular state of the context.
3. ConcreteState: Implements state interfaces to concretely implement behaviors in different states.

# Sample Code

Suppose we have an application that needs to simulate the state of a simple light switch (on and off).

**State Interface**

```csharp
public interface IState
{
    void Handle(LightSwitch context);
}
```

**Specific State**

```csharp
public class OnState : IState
{
    public void Handle(LightSwitch context)
    {
        Console.WriteLine("Light is already ON. Turning it OFF now.");
        context.SetState(new OffState());
    }
}

public class OffState : IState
{
    public void Handle(LightSwitch context)
    {
        Console.WriteLine("Light is OFF. Turning it ON now.");
        context.SetState(new OnState());
    }
}
```

**Context**

```csharp
public class LightSwitch
{
    private IState _state;

    public LightSwitch()
    {
        _state = new OffState(); // initial state is off
    }

    public void SetState(IState state)
    {
        _state = state;
    }

    public void PressSwitch()
    {
        _state.Handle(this);
    }
}
```

**Client Code**

```csharp
class Program
{
    static void Main(string[] args)
    {
        LightSwitch lightSwitch = new LightSwitch();

        lightSwitch.PressSwitch(); // Light is OFF. Turning it ON now.
        lightSwitch.PressSwitch(); // Light is already ON. Turning it OFF now.
        lightSwitch.PressSwitch(); // Light is OFF. Turning it ON now.
    }
}
```

# Application Scenarios

The status mode applies to the following scenarios:

1. The behavior of an object depends on its state: The state mode can be used when the behavior of an object depends on its state and it must change its behavior at runtime based on that state.
2. Complex state transition logic: When the logic of state transition is complex, the state mode can be used to encapsulate state-related behaviors into independent state classes.

# Advantages and disadvantages

**Advantages**

* Simplify state transitions: State patterns simplify the logic of state transitions by encapsulating state-related behaviors into separate state classes.
* Improved maintainability: State mode makes state transitions more explicit and controllable, improving the maintainability of the system.
* Follow the open closed principle: The state mode makes it easy to add new states, in accordance with the open closed principle.

**Disadvantages**

* Increase the number of classes: The state pattern introduces a large number of state classes, which may increase the complexity of the system.
* State switching overhead: Frequent state switching may incur a performance overhead.