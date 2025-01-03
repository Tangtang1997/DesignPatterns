# Overview

A Template Method Pattern is a behavioral design pattern that defines the skeleton of an algorithm in an operation while deferring some steps to subclasses. The template method pattern allows subclasses to redefine certain steps in an algorithm without changing the algorithm structure. By using the template method pattern, you can improve code reusability and flexibility.

# Structure

The template method pattern contains the following roles:

1. AbstractClass: Defines the skeleton of an algorithm and contains a template method that defines the steps of the algorithm.
2. ConcreteClass: Implements abstract methods in an abstract class to complete concrete steps in an algorithm.

# Sample Code

Let's say we have an application that needs to make different types of drinks (like tea and coffee).

**AbstractClass**

```csharp
public abstract class Beverage
{
    // template method
    public void PrepareRecipe()
    {
        BoilWater();
        Brew();
        PourInCup();
        AddCondiments();
    }

    protected void BoilWater()
    {
        Console.WriteLine("Boiling water");
    }

    protected abstract void Brew();

    protected void PourInCup()
    {
        Console.WriteLine("Pouring into cup");
    }

    protected abstract void AddCondiments();
}
```

**SpecificClass**

```csharp
public class Tea : Beverage
{
    protected override void Brew()
    {
        Console.WriteLine("Steeping the tea");
    }

    protected override void AddCondiments()
    {
        Console.WriteLine("Adding lemon");
    }
}

public class Coffee : Beverage
{
    protected override void Brew()
    {
        Console.WriteLine("Dripping coffee through filter");
    }

    protected override void AddCondiments()
    {
        Console.WriteLine("Adding sugar and milk");
    }
}
```

**Client Code**

```csharp
class Program
{
    static void Main(string[] args)
    {
        Beverage tea = new Tea();
        tea.PrepareRecipe();

        Console.WriteLine();

        Beverage coffee = new Coffee();
        coffee.PrepareRecipe();
    }
}
```

# Application Scenarios

The template method pattern is applicable to the following scenarios:

1. Algorithm steps fixed: When the overall steps of an algorithm are fixed, but some specific steps can be implemented by subclasses, you can use the template method pattern.
2. Code reuse: When multiple subclasses have the same behavior logic but differ in some steps, the template method pattern can be used to improve the reusability of the code.
3. Control the extension of subclasses: When you need to control the extension of subclasses, but do not want to affect the overall structure of the algorithm, you can use the template method pattern.

# Advantages and disadvantages

**Advantages**

* Improve code reusability: The template method pattern improves code reusability by extracting the common part of an algorithm into an abstract class.
* High flexibility: The template method pattern allows subclasses to redefine certain steps in an algorithm without changing the overall structure of the algorithm.
* Comply with the open-close principle: The template method mode allows the structure of the algorithm to be extended without modifying the existing code, which conforms to the open-close principle.

**Disadvantages**

* Increase code complexity: The template method pattern introduces abstract and concrete classes, which may increase the code complexity of the system.
* Subclass implementation is difficult: Subclasses need to implement abstract methods in abstract classes, which may increase the implementation difficulty of subclasses.