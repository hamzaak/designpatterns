# Decorator Pattern
## Definition
In object-oriented programming, the decorator pattern is a design pattern that allows behavior to be added to an individual object, dynamically, without affecting the behavior of other objects from the same class. The decorator pattern is often useful for adhering to the Single Responsibility Principle, as it allows functionality to be divided between classes with unique areas of concern. The decorator pattern is structurally nearly identical to the chain of responsibility pattern, the difference being that in a chain of responsibility, exactly one of the classes handles the request, while for the decorator, all classes handle the request.

## Problem
* Responsibilities should be added to (and removed from) an object dynamically at run-time.[4]
* A flexible alternative to subclassing for extending functionality should be provided.
When using subclassing, different subclasses extend a class in different ways. But an extension is bound to the class at compile-time and can't be changed at run-time.

## Solution
* implement the interface of the extended (decorated) object (Component) transparently by forwarding all requests to it
* perform additional functionality before/after forwarding a request.
This allows working with different Decorator objects to extend the functionality of an object dynamically at run-time.

## Tutorial
1. **Component** - The base Component interface defines operations that can be altered by decorators.
2. **ConcreteComponent** - Concrete Components provide default implementations of the operations.
3. **Decorator** - The base Decorator class follows the same interface as the other components. The primary purpose of this class is to define the wrapping interface for all concrete decorators. The default implementation of the wrapping code might include a field for storing a wrapped component and the means to initialize it.
4. **ConcreteDecoratorA - ConcreteDecoratorB** - Concrete Decorators call the wrapped object and alter its result in some way.
5. **Client** - The client code works with all objects using the Component interface. This way it can stay independent of the concrete classes of components it works with.

## References
1. [Wikipedia - Decorator Pattern](https://en.wikipedia.org/wiki/Decorator_pattern)
2. [Refactoring Guru - Decorator in C#](https://refactoring.guru/design-patterns/decorator/csharp/example)
