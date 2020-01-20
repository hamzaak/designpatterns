# Chain of Responsibility Pattern
## Definition
The chain-of-responsibility pattern is a design pattern consisting of a source of command objects and a series of processing objects. Each processing object contains logic that defines the types of command objects that it can handle; the rest are passed to the next processing object in the chain. A mechanism also exists for adding new processing objects to the end of this chain. Thus, the chain of responsibility is an object oriented version of the if ... else if ... else if ....... else ... endif idiom, with the benefit that the condition–action blocks can be dynamically rearranged and reconfigured at runtime.

## Problem
* Coupling the sender of a request to its receiver should be avoided.
* It should be possible that more than one receiver can handle a request.
Implementing a request directly within the class that sends the request is inflexible because it couples the class to a particular receiver and makes it impossible to support multiple receivers.

## Solution
* Define a chain of receiver objects having the responsibility, depending on run-time conditions, to either handle a request or forward it to the next receiver on the chain (if any).
This enables to send a request to a chain of receivers without having to know which one handles the request. The request gets passed along the chain until a receiver handles the request. The sender of a request is no longer coupled to a particular receiver.

## Tutorial
1. **Approver** - Handler abstract class.
2. **Clerk, Assistant Manager & Manager** - ConcreteHandler classes.
3. **Loan & LoanEventArgs** - These classes are used for internal processing and hold request details

## References
1. [Wikipedia - Chain of Responsibility Pattern](https://en.wikipedia.org/wiki/Chain-of-responsibility_pattern)
2. [Dotnet Tricks - Chain of Responsibility Design Pattern - C#](https://www.dotnettricks.com/learn/designpatterns/chain-of-responsibility-design-pattern-dotnet)
