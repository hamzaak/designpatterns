# Command Pattern
## Definition
In this pattern, a request is wrapped under an object as a command and passed to invoker object. Invoker object pass the command to the appropriate object which can handle it and that object executes the command. This handles the request in traditional ways like as queuing and callbacks.

This pattern is commonly used in the menu systems of many applications such as Editor, IDE etc.

## Problem
* Coupling the invoker of a request to a particular request should be avoided. That is, hard-wired requests should be avoided.
* It should be possible to configure an object (that invokes a request) with a request.
Implementing (hard-wiring) a request directly into a class is inflexible because it couples the class to a particular request at compile-time, which makes it impossible to specify a request at run-time.

## Solution
* Define separate (command) objects that encapsulate a request.
* A class delegates a request to a command object instead of implementing a particular request directly.
This enables one to configure a class with a command object that is used to perform a request. The class is no longer coupled to a particular request and has no knowledge (is independent) of how the request is carried out.

## Tutorial
1. **Switch** - Invoker class.
2. **ICommand** - Command interface.
3. **FlipUpCommand and FlipDownCommand** - Concrete Command classes.
4. **Light** - Receiver class.

## References
1. [dotnettricks.com - Command Design Pattern - C#](https://www.dotnettricks.com/learn/designpatterns/command-design-pattern-dotnet)
2. [Wikipedia - Command Pattern](https://en.wikipedia.org/wiki/Command_pattern)
