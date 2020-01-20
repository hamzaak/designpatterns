# Observer Pattern
## Definition
The observer pattern is a software design pattern in which an object, called the subject, maintains a list of its dependents, called observers, and notifies them automatically of any state changes, usually by calling one of their methods.

It is mainly used to implement distributed event handling systems, in "event driven" software. In those systems, the subject is usually called a "stream of events" or "stream source of events", while the observers are called "sink of events". The stream nomenclature simulates or adapts to a physical setup where the observers are physically separated and have no control over the emitted events of the subject/stream-source. This pattern then perfectly suits any process where data arrives through I/O, that is, where data is not available to the CPU at startup, but can arrive "randomly" (HTTP requests, GPIO data, user input from keyboard/mouse/..., distributed databases and blockchains, ...). Most modern languages have built-in "event" constructs which implement the observer pattern components. While not mandatory most 'observers' implementations will use background threads listening for subject events and other support mechanism from the kernel (Linux epoll, ...)

## Problem
* A one-to-many dependency between objects should be defined without making the objects tightly coupled.
* It should be ensured that when one object changes state an open-ended number of dependent objects are updated automatically.
* It should be possible that one object can notify an open-ended number of other objects.
Defining a one-to-many dependency between objects by defining one object (subject) that updates the state of dependent objects directly is inflexible because it couples the subject to particular dependent objects. Still it can make sense from a performance point of view or if the object implementation is tightly coupled (think of low level kernel structures that execute thousands of times a second). Tightly coupled objects can be hard to implement in some scenarios, and reuse because they refer to and know about (how to update) many different objects with different interfaces. In other scenarios tightly coupled objects can be a better option since the compiler will be able to detect errors at compile time and optimize the code at CPU instruction level.

## Solution
* Define Subject and Observer objects.
* So that when a subject changes state, all registered observers are notified and updated automatically (and probably asynchronously).
The sole responsibility of a subject is to maintain a list of observers and to notify them of state changes by calling their update() operation.
The responsibility of observers is to register (and unregister) themselves on a subject (to get notified of state changes) and to update their state (synchronize their state with subject's state) when they are notified.
This makes subject and observers loosely coupled. Subject and observers have no explicit knowledge of each other. Observers can be added and removed independently at run-time.
This notification-registration interaction is also known as publish-subscribe.

## Tutorial
1. **Veggies** - The Subject abstract class
2. **Carrots** - The ConcreteSubject class
3. **IRestaurant** - The Observer interface
4. **Restaurant** - The ConcreteObserver class

## References
1. [Wikipedia - Observer Pattern](https://en.wikipedia.org/wiki/Observer_pattern)
2. [exceptionnotfound.net - The Observer Design Pattern in C#](https://exceptionnotfound.net/observer-pattern-in-csharp/)
