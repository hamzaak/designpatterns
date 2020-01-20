# Facade Pattern
## Definition
The facade pattern (also spelled façade) is a software-design pattern commonly used in object-oriented programming. Analogous to a facade in architecture, a facade is an object that serves as a front-facing interface masking more complex underlying or structural code. A facade can:
* improve the readability and usability of a software library by masking interaction with more complex components behind a single (and often simplified) API
* provide a context-specific interface to more generic functionality (complete with context-specific input validation)
* serve as a launching point for a broader refactor of monolithic or tightly-coupled systems in favor of more loosely-coupled code
Developers often use the facade design pattern when a system is very complex or difficult to understand because the system has many interdependent classes or because its source code is unavailable. This pattern hides the complexities of the larger system and provides a simpler interface to the client. It typically involves a single wrapper class that contains a set of members required by the client. These members access the system on behalf of the facade client and hide the implementation details.

## Problem
* To make a complex subsystem easier to use, a simple interface should be provided for a set of interfaces in the subsystem.
* The dependencies on a subsystem should be minimized.
Clients that access a complex subsystem directly refer to (depend on) many different objects having different interfaces (tight coupling), which makes the clients hard to implement, change, test, and reuse.

Tightly coupled objects are hard to implement, change, test, and reuse because they refer to and know about many different objects.

## Solution
* implements a simple interface in terms of (by delegating to) the interfaces in the subsystem and
* may perform additional functionality before/after forwarding a request.
This enables to work through a Facade object to minimize the dependencies on a subsystem.

## Tutorial
1. **CarModel, CarEngine, CarBody, CarAccessories** - These are subsystems
2. **CarFacade** - Facade class

## References
1. [Wikipedia - Facade Pattern](https://en.wikipedia.org/wiki/Facade_pattern)
2. [Dotnet Tricks - Facade Design Pattern - C#](https://www.dotnettricks.com/learn/designpatterns/facade-design-pattern-dotnet)
