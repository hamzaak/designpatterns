# Design Patterns (GoF)
The four authors Erich Gamma, Richard Helm, Ralph Johnson and John Vlissides are collectively introduced Gang of Four Design Patterns in Software development. In 1994, they published a book (Design Patterns: Elements of Reusable Object-Oriented Software) for explaining the concept of Design Patterns

The 23 Design patterns are defined by the Gang of Four programmers. These 23 patterns are divided into three groups depending on the nature of the design problem they intend to solve.

This repo implements design patterns in .NET Core with real world applications.

## 1. Creational Design Patterns
These patterns deal with the process of objects creation in such a way that they can be decoupled from their implementing system. This provides more flexibility in deciding which objects need to be created for a given use case/ scenario. There are as follows:
1. **[Factory Method](factorymethod/):** Create instances of derived classes
2. **Abstract Factory:** Create instances of several classes belonging to different families
3. **[Builder](builder/):** Separates an object construction from its representation
4. **[Prototype](prototype/):** Create a duplicate object or clone of the object
5. **Singleton:** Ensures that a class can has only one instance

## 2. Structural Design Patterns
These patterns deal with the composition of objects structures. The concept of inheritance is used to compose interfaces and define various ways to compose objects for obtaining new functionalities. There are as follows:
1. **Adapter:** Match interfaces of different classes
2. **Bridge:** Separates an object’s abstraction from its implementation
3. **Composite:** A tree structure of simple and composite objects
4. **Decorator:** Add responsibilities to objects dynamically
5. **Facade:** A single class that represents an entire complex system
6. **Flyweight:** Minimize memory usage by sharing as much data as possible with similar objects
7. **Proxy:** Provides a surrogate object, which references to other object

## 3. Behavioral Design Patterns
These patterns deal with the process of communication, managing relationships, and responsibilities between objects. There are as follows:
1. **Chain of Responsibility:** Passes a request among a list or chain of objects.
2. **Command:** Wraps a request under an object as a command and passed to invoker object.
3. **Interpreter:** Implements an expression interface to interpret a particular context.
4. **Iterator:** Provides a way to access the elements of a collection object in sequential manner without knowing its underlying structure.
5. **Mediator:** Allows multiple objects to communicate with each other’s without knowing each other’s structure.
6. **Memento:** Capture the current state of an object and store it in such a manner that it can be restored at a later time without breaking the rules of encapsulation.
7. **Observer:** Allows an object (subject) to publish changes to its state and other objects (observer) that depend upon that object are automatically notified of any changes to the subject's state.
8. **State:** Alters the behavior of an object when it’s internal state changes.
9. **Strategy:** Allows a client to choose an algorithm from a family of algorithms at run-time and gives it a simple way to access it.
10. **Visitor:** Creates and performs new operations onto a set of objects without changing the object structure or classes.
11. **Template Method:** Defines the basic steps of an algorithm and allow the implementation of the individual steps to be changed.

License
----

MIT