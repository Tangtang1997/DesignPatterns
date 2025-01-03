# Introduction

[![MIT licensed](https://img.shields.io/badge/license-MIT-blue.svg)]([https://gitlab.aiursoft.cn/aiursoft/tracer/-/blob/master/](https://github.com/Tangtang1997/DesignPatterns/edit/master/)LICENSE)
[![GitHub Actions](https://github.com/Tangtang1997/DesignPatterns/workflows/.NET/badge.svg)](https://github.com/Tangtang1997/DesignPatterns/actions)

In the world of software development, design patterns are a proven solution to common design problems. They not only improve the maintainability and extensibility of the code, but also enable developers to do their development work more efficiently. Design patterns provide a standardized approach to solving the problem of duplication in software design, allowing developers to focus more on the implementation of business logic rather than reinventing the wheel.

The concept of design patterns was first proposed by Erich Gamma, Richard Helm, Ralph Johnson, and John Vlissides in their book Design Patterns: The Foundations of Reusable Object-Oriented Software. This book summarizes 23 classic design patterns and classifies them into three broad categories: creative, structural, and behavioral patterns.

In this blog post, we will give an overview of these 23 classic design patterns, and introduce their classification and application scenarios. Each design pattern has its own unique uses and benefits, and mastering these patterns can significantly improve your programming skills and code quality.

# Classification of design patterns
Design patterns generally fall into three broad categories:

## Creational pattern
The creation pattern focuses on the creation process of objects and aims to separate the creation and use of objects, thereby improving the flexibility and scalability of the system. These patterns include:

1. [Factory Method](./doc/01-CreationMode/01-FactoryMethodPattern.md): Define an interface for creating objects, but let subclasses decide which class to instantiate.
2. [Abstract Factory](./doc/01-CreationMode/02-AbstractFactoryPattern.md): Provides an interface for creating a series of related or interdependent objects without specifying their concrete classes.
3. [Singleton](./doc/01-CreationMode/03-SingletonPattern.md): Ensure that a class has only one instance and provides a global access point.
4. [Builder](./doc/01-CreationMode/04-BuilderPattern.md): Separate the building process of a complex object from its representation, so that the same building process can create different representations.
5. [Prototype](./doc/01-CreationMode/05-ProtoTypePattern.md): Create new objects by copying existing instances, rather than by instantiating classes.

## Structural pattern
The structural pattern focuses on the combination of classes and objects, and aims to realize new functionality by combining objects. These patterns include:

1. [Adapter](./doc/02-StructureMode/01-AdapterPattern.md): The interface of a class is converted into another interface desired by the customer, so that the classes that cannot work together due to incompatible interfaces can work together.
2. [Bridge](./doc/02-StructureMode/02-BridgePattern.md): Separate the abstract part from its implementation part so that they can both vary independently.
3. [Composite](./doc/02-StructureMode/03-CompositePattern.md): The object is combined into a tree structure to represent the "part-whole" hierarchy, so that customers can uniformly deal with individual objects and combined objects.
4. [Decorator](./doc/02-StructureMode/04-DecoratorPattern.md): Dynamically add some additional responsibilities to an object. Decorators are more flexible than subclasses in terms of adding functionality.
5. [Facade](./doc/02-StructureMode/05-FacadePattern.md): Provides a consistent interface to a set of interfaces within the subsystem, making the subsystem easier to use.
6. [Flyweight](./doc/02-StructureMode/06-FlyweightPattern.md): Using sharing technology to effectively support a large number of fine-grained objects.
7. [Proxy](./doc/02-StructureMode/07-ProxyPattern.md): Provides a proxy for other objects to control access to this object.

## Behavioral pattern
The behavioral pattern focuses on communication and assignment of responsibilities between objects and aims to make interactions between objects more flexible and extensible. These patterns include:

1. [Chain of Responsibility](./doc/03-BehavioralMode/01-ChainOfResponsibilityPattern.md): A chain of recipient objects is created for a request so that multiple objects have the opportunity to process the request.
2. [Command](./doc/03-BehavioralMode/02-CommandPattern.md): Encapsulates requests into objects, allowing you to parameterize clients with different requests.
3. Interpreter: Given a language, define a representation of its grammar and define an interpreter that uses that representation to interpret sentences in the language.
4. [Iterator](./doc/03-BehavioralMode/04-IteratorPattern.md): Provides a way to access the elements of an aggregate object sequentially without exposing the internal representation of the object.
5. [Mediator](./doc/03-BehavioralMode/05-MediatorPattern.md): A mediator object is used to encapsulate the interaction of a series of objects, and the mediator makes the objects do not need to explicitly reference each other, so that the coupling is loose, and the interaction between them can be changed independently.
6. [Memento](./doc/03-BehavioralMode/06-MementoPattern.md): Captures the internal state of an object without breaking the encapsulation, and saves this state outside the object.
7. [Observer](./doc/03-BehavioralMode/07-ObserverPattern.md): Define a one-to-many dependency relationship between objects, when an object's state changes, all the objects that depend on it are notified and automatically updated.
8. [State](./doc/03-BehavioralMode/08-StatePattern.md): Allows an object to change its behavior when its internal state changes, and the object appears to modify its class.
9. [Strategy](./doc/03-BehavioralMode/09-StrategyPattern.md): Define a series of algorithms, encapsulate them one by one, and make them interchangeable.
10. [Template Method](./doc/03-BehavioralMode/10-TemplateMethodPattern.md): Define the skeleton of an algorithm in an operation, and defer some steps to the subclass, so that the subclass can redefine some specific steps of the algorithm without changing the structure of the algorithm.
11. [Visitor](./doc/03-BehavioralMode/11-VisitorPattern.md): Represents an operation on elements of an object structure that allows you to define new operations on those elements without changing their class.
