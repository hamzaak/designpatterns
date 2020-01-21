# State Pattern
## Definition
State pattern is useful when we want to maintain various states for a scenario in our program. State pattern allows an object to change its behavior when it’s internal state changes.

**Gang of Four(GoF) Definition:**
> Allow an object to alter its behavior when its internal state changes. The object will appear to change its class.

## Problem
* An object should change its behavior when its internal state changes.
* State-specific behavior should be defined independently. That is, adding new states should not affect the behavior of existing states.

## Solution
Implementing state-specific behavior directly within a class is inflexible because it commits the class to a particular behavior and makes it impossible to add a new state or change the behavior of an existing state later independently from (without changing) the class. In this, the pattern describes two solutions:
* Define separate (state) objects that encapsulate state-specific behavior for each state. That is, define an interface (state) for performing state-specific behavior, and define classes that implement the interface for each state.
* A class delegates state-specific behavior to its current state object instead of implementing state-specific behavior directly.
This makes a class independent of how state-specific behavior is implemented. New states can be added by defining new state classes. A class can change its behavior at run-time by changing its current state object.

## Tutorial
The memento pattern allows one to capture the internal state of an object without violating encapsulation such that later one can undo/revert the changes if required. Here one can see that the memento object is actually used to revert the changes made in the object.
1. **Player** - Context Class.
2. **IState** - State Interface.
3. **HealthyState, HurtState and DeadState** - Concrete state class.

## References
1. [gyanendushekhar.com - State Design Pattern in C#](http://gyanendushekhar.com/2016/11/05/state-design-pattern-c/)
2. [Wikipedia - State Pattern](https://en.wikipedia.org/wiki/State_pattern)
