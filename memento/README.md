# Memento Pattern
## Definition
Memento pattern allows you to store the internal state of an object and you can restore the object later using stored state. Let’s consider the design of a game in which you want to store the state of a given object over different check points/ levels and later the player will be able to restore the object using the stored states. Memento design pattern will be helpful in that kind of scenario.

**Gang of Four(GoF) Definition:**
> Without violating encapsulation, capture and externalize an object’s internal state so that the object can be restored to this state later.

## Problem
* The internal state of an object should be saved externally so that the object can be restored to this state later.
* The object's encapsulation must not be violated.
The problem is that a well designed object is encapsulated so that its representation (data structure) is hidden inside the object and can't be accessed from outside the object.

## Solution
Make an object (originator) itself responsible for
* saving its internal state to a (memento) object and
* restoring to a previous state from a (memento) object.
Only the originator that created a memento is allowed to access it.
A client (caretaker) can request a memento from the originator (to save the internal state of the originator) and pass a memento back to the originator (to restore to a previous state).
This enables to save and restore the internal state of an originator without violating its encapsulation.

## Tutorial
The memento pattern allows one to capture the internal state of an object without violating encapsulation such that later one can undo/revert the changes if required. Here one can see that the memento object is actually used to revert the changes made in the object.
1. **Player** - Originator Class.
2. **Memento** - Memento Class.
3. **CareTaker** - Caretaker Class.

## References
1. [gyanendushekhar.com - Memento Design Pattern in C#](http://gyanendushekhar.com/2017/02/01/memento-design-pattern-c/)
2. [Wikipedia - Memento Pattern](https://en.wikipedia.org/wiki/Memento_pattern)
