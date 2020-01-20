# Visitor Pattern
## Definition
In object-oriented programming and software engineering, the visitor design pattern is a way of separating an algorithm from an object structure on which it operates. A practical result of this separation is the ability to add new operations to existing object structures without modifying the structures. It is one way to follow the open/closed principle.

In essence, the visitor allows adding new virtual functions to a family of classes, without modifying the classes. Instead, a visitor class is created that implements all of the appropriate specializations of the virtual function. The visitor takes the instance reference as input, and implements the goal through double dispatch.

## Problem
* It should be possible to define a new operation for (some) classes of an object structure without changing the classes.
When new operations are needed frequently and the object structure consists of many unrelated classes, it's inflexible to add new subclasses each time a new operation is required because "[..] distributing all these operations across the various node classes leads to a system that's hard to understand, maintain, and change."

## Solution
* Define a separate (visitor) object that implements an operation to be performed on elements of an object structure.
* Clients traverse the object structure and call a dispatching operation accept(visitor) on an element — that "dispatches" (delegates) the request to the "accepted visitor object". The visitor object then performs the operation on the element ("visits the element").
This makes it possible to create new operations independently from the classes of an object structure by adding new visitor objects.

## Tutorial
1. **IExpressionVisitor** - Visitor Interface.
2. **IExpression** - Element Class.
3. **Literal and Addition** - Concrete Elements
4. **ExpressionPrinter** - Concrete Visitor

## References
1. [Wikipedia - Visitor Pattern](https://en.wikipedia.org/wiki/Visitor_pattern)
