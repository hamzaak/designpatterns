# Abstract Factory Pattern
## Definition
The abstract factory pattern provides a way to encapsulate a group of individual factories that have a common theme without specifying their concrete classes. In normal usage, the client software creates a concrete implementation of the abstract factory and then uses the generic interface of the factory to create the concrete objects that are part of the theme. The client doesn't know (or care) which concrete objects it gets from each of these internal factories, since it uses only the generic interfaces of their products. This pattern separates the details of implementation of a set of objects from their general usage and relies on object composition, as object creation is implemented in methods exposed in the factory interface.

## Problem
* How can an application be independent of how its objects are created?
* How can a class be independent of how the objects it requires are created?
* How can families of related or dependent objects be created?
Creating objects directly within the class that requires the objects is inflexible because it commits the class to particular objects and makes it impossible to change the instantiation later independently from (without having to change) the class. It stops the class from being reusable if other objects are required, and it makes the class hard to test because real objects can't be replaced with mock objects.

## Solution
* Encapsulate object creation in a separate (factory) object. That is, define an interface (AbstractFactory) for creating objects, and implement the interface.
* A class delegates object creation to a factory object instead of creating objects directly.
This makes a class independent of how its objects are created (which concrete classes are instantiated). A class can be configured with a factory object, which it uses to create objects, and even more, the factory object can be exchanged at run-time.

## Tutorial
1. **VehicleFactory** - AbstractFactory interface
2. **HondaFactory & HeroFactory** - Concrete Factories
3. **Bike & Scooter** - AbstractProduct interface
4. **Regular Bike, Sports Bike, Regular Scooter & Scooty** - Concrete Products
5. **VehicleClient** - Client

## References
1. [Wikipedia - Abstract Factory Pattern](https://en.wikipedia.org/wiki/Abstract_factory_pattern)
2. [dotnettricks.com - Abstract Factory Design Pattern - C#](https://www.dotnettricks.com/learn/designpatterns/abstract-factory-design-pattern-dotnet)
