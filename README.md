![Image of Design Patterns](https://github.com/hamzaak/designpatterns/blob/master/assets/peacock.jpg)
# Design Patterns (GoF)
The four authors Erich Gamma, Richard Helm, Ralph Johnson and John Vlissides are collectively introduced Gang of Four Design Patterns in Software development. In 1994, they published a book (Design Patterns: Elements of Reusable Object-Oriented Software) for explaining the concept of Design Patterns

The 23 Design patterns are defined by the Gang of Four programmers. These 23 patterns are divided into three groups depending on the nature of the design problem they intend to solve.

This repo implements design patterns in .NET Core with real life examples.

## 1. Creational Design Patterns
These patterns deal with the process of objects creation in such a way that they can be decoupled from their implementing system. This provides more flexibility in deciding which objects need to be created for a given use case/ scenario. There are as follows:
1. **[Factory Method](factorymethod/):** Create instances of derived classes :heavy_check_mark:
2. **[Abstract Factory](abstractfactory/):** Create instances of several classes belonging to different families :heavy_check_mark:
3. **[Builder](builder/):** Separates an object construction from its representation :heavy_check_mark:
4. **[Prototype](prototype/):** Create a duplicate object or clone of the object :heavy_check_mark:
5. **[Singleton](singleton/):** Ensures that a class can has only one instance :heavy_check_mark:

## 2. Structural Design Patterns
These patterns deal with the composition of objects structures. The concept of inheritance is used to compose interfaces and define various ways to compose objects for obtaining new functionalities. There are as follows:
1. **[Adapter](adapter/):** Match interfaces of different classes :heavy_check_mark:
2. **[Bridge](bridge/):** Separates an object’s abstraction from its implementation 
3. **[Composite](composite/):** A tree structure of simple and composite objects :heavy_check_mark:
4. **Decorator:** Add responsibilities to objects dynamically
5. **[Facade](facade/):** A single class that represents an entire complex system :heavy_check_mark:
6. **Flyweight:** Minimize memory usage by sharing as much data as possible with similar objects
7. **[Proxy](proxy/):** Provides a surrogate object, which references to other object :heavy_check_mark:

## 3. Behavioral Design Patterns
These patterns deal with the process of communication, managing relationships, and responsibilities between objects. There are as follows:
1. **[Chain of Responsibility](chainofresponsibility/):** Passes a request among a list or chain of objects. :heavy_check_mark:
2. **Command:** Wraps a request under an object as a command and passed to invoker object.
3. **Interpreter:** Implements an expression interface to interpret a particular context.
4. **[Iterator](iterator/):** Provides a way to access the elements of a collection object in sequential manner without knowing its underlying structure. :heavy_check_mark:
5. **Mediator:** Allows multiple objects to communicate with each other’s without knowing each other’s structure. :soon:
6. **Memento:** Capture the current state of an object and store it in such a manner that it can be restored at a later time without breaking the rules of encapsulation.
7. **[Observer](observer/):** Allows an object (subject) to publish changes to its state and other objects (observer) that depend upon that object are automatically notified of any changes to the subject's state. :heavy_check_mark:
8. **State:** Alters the behavior of an object when it’s internal state changes.
9. **[Strategy](strategy/):** Allows a client to choose an algorithm from a family of algorithms at run-time and gives it a simple way to access it. :heavy_check_mark:
10. **[Visitor](visitor/):** Creates and performs new operations onto a set of objects without changing the object structure or classes. :heavy_check_mark:
11. **[Template Method](templatemethod/):** Defines the basic steps of an algorithm and allow the implementation of the individual steps to be changed. :heavy_check_mark:

License
----

MIT