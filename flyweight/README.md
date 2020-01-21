# Flyweight Pattern
## Definition
Flyweight pattern is used to reduce the number of objects created, to decrease memory and resource usage. As a result, it increases performance.
Flyweight pattern tries to reuse already existing similar kind objects by storing them and creates a new object when no matching object is found.
The flyweight pattern uses the concepts of intrinsic and extrinsic data.
Intrinsic data is held in the properties of the shared flyweight objects. This information is stateless and generally remains unchanged, if any change occurs it would be reflected among all of the objects that reference the flyweight.
Extrinsic data is computed on the fly means at runtime and it is held outside of a flyweight object. Hence it can be stateful.

## Problem
* Large numbers of objects should be supported efficiently.
* Creating large numbers of objects should be avoided.
When representing large text documents, for example, creating an object for each character in the document would result in a huge number of objects that could not be processed efficiently.

## Solution
* store intrinsic (invariant) state that can be shared and
* provide an interface through which extrinsic (variant) state can be passed in.

## Tutorial
1. **ShapeObjectFactory** - FlyweightFactory class.
2. **IShape** - Flyweight interface.
3. **Circle & Rectangle** - ConcreteFlyweight class.

## References
1. [dotnettricks.com - Flyweight Design Pattern - C#](https://www.dotnettricks.com/learn/designpatterns/flyweight-design-pattern-dotnet)
2. [Wikipedia - Flyweight Pattern](https://en.wikipedia.org/wiki/Flyweight_pattern)
