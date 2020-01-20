# Iterator Pattern
## Definition
The iterator pattern is a design pattern in which an iterator is used to traverse a container and access the container's elements. The iterator pattern decouples algorithms from containers; in some cases, algorithms are necessarily container-specific and thus cannot be decoupled.

For example, the hypothetical algorithm SearchForElement can be implemented generally using a specified type of iterator rather than implementing it as a container-specific algorithm. This allows SearchForElement to be used on any container that supports the required type of iterator.

## Problem
* The elements of an aggregate object should be accessed and traversed without exposing its representation (data structures).
* New traversal operations should be defined for an aggregate object without changing its interface.
Defining access and traversal operations in the aggregate interface is inflexible because it commits the aggregate to particular access and traversal operations and makes it impossible to add new operations later without having to change the aggregate interface.

## Solution
* Define a separate (iterator) object that encapsulates accessing and traversing an aggregate object.
* Clients use an iterator to access and traverse an aggregate without knowing its representation (data structures).
Different iterators can be used to access and traverse an aggregate in different ways.
New access and traversal operations can be defined independently by defining new iterators

## Tutorial
1. **AbsIterator** - defines an interface for accessing and traversing elements.
2. **ConcreteIterator** - implements the Iterator interface and keeps track of the current position in the traversal of the aggregate.
3. **Aggregate** - defines an interface for creating an Iterator object.
4. **ConcreteAggregate** - implements the Iterator creation interface to return an instance of the proper ConcreteIterator.

## References
1. [Wikipedia - Iterator Pattern](https://en.wikipedia.org/wiki/Iterator_pattern)
2. [dofactory.com - Iterator Design Pattern in C#](https://www.dofactory.com/net/iterator-design-pattern)
