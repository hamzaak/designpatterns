# Bridge Pattern
## Definition
This pattern involves an interface which acts as a bridge between the abstraction class and implementer classes and also makes the functionality of implementer class independent from the abstraction class. Both types of classes can be modified without affecting to each other.

> Decouple an abstraction from its implementation so that the two can vary independently.
> ~ **Gang Of Four**

This pattern looks like **[Adapter](./adapter/):** design pattern. The difference between them according to GoF is: 
> Adapter makes things work after they're designed; Bridge makes them work before they are.
> ~ **Gang Of Four (p219)**

Effectively, the **[Adapter](./adapter/):** design pattern is useful when you have existing code, be it third party, or in-house, but out of your control, or otherwise not changeable to quite meet the interface you need it to.

## Problem
* An abstraction and its implementation should be defined and extended independently from each other.
* A compile-time binding between an abstraction and its implementation should be avoided so that an implementation can be selected at run-time.
When using subclassing, different subclasses implement an abstract class in different ways. But an implementation is bound to the abstraction at compile-time and can't be changed at run-time.

## Solution
* Separate an abstraction (Abstraction) from its implementation (Implementor) by putting them in separate class hierarchies.
* Implement the Abstraction in terms of (by delegating to) an Implementor object.
This enables to configure an Abstraction with an Implementor object at run-time.

## Tutorial
1. **Message** - Abstraction Class
2. **SystemMessage and UserMessage** - Redefined Abstraction Classes
3. **IMessageSender** - Bridge Interface
4. **EmailSender, WebServiceSender & MSMQ Sender** - ConcreteImplementation class which implements the IMessageSender interface
