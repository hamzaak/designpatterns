# Composite Pattern
## Definition
The Composite design pattern is one of the twenty-three well-known GoF design patterns that describe how to solve recurring design problems to design flexible and reusable object-oriented software, that is, objects that are easier to implement, change, test, and reuse.

In software engineering, the composite pattern is a partitioning design pattern. The composite pattern describes a group of objects that are treated the same way as a single instance of the same type of object. The intent of a composite is to "compose" objects into tree structures to represent part-whole hierarchies. Implementing the composite pattern lets clients treat individual objects and compositions uniformly.

When dealing with Tree-structured data, programmers often have to discriminate between a leaf-node and a branch. This makes code more complex, and therefore, more error prone. The solution is an interface that allows treating complex and primitive objects uniformly. In object-oriented programming, a composite is an object designed as a composition of one-or-more similar objects, all exhibiting similar functionality. This is known as a "has-a" relationship between objects. The key concept is that you can manipulate a single instance of the object just as you would manipulate a group of them. The operations you can perform on all the composite objects often have a least common denominator relationship. For example, if defining a system to portray grouped shapes on a screen, it would be useful to define resizing a group of shapes to have the same effect (in some sense) as resizing a single shape.

Composite should be used when clients ignore the difference between compositions of objects and individual objects. If programmers find that they are using multiple objects in the same way, and often have nearly identical code to handle each of them, then composite is a good choice; it is less complex in this situation to treat primitives and composites as homogeneous.

## Problem
What problems can the Composite design pattern solve? 
* A part-whole hierarchy should be represented so that clients can treat part and whole objects uniformly.
* A part-whole hierarchy should be represented as tree structure.
When defining Part objects and Whole objects that act as containers for Part objects, clients must treat them separately, which complicates client code.

## Solution
What solution does the Composite design pattern describe?
* Define a unified Component interface for both part (Leaf) objects and whole (Composite) objects.
* Individual Leaf objects implement the Component interface directly, and Composite objects forward requests to their child components.
This enables clients to work through the Component interface to treat Leaf and Composite objects uniformly: Leaf objects perform a request directly, and Composite objects forward the request to their child components recursively downwards the tree structure. This makes client classes easier to implement, change, test, and reuse.

## Tutorial
1. **IEmployed** - Component Interface
2. **Employee** - Composite Class
3. **Contractor** - Leaf Class

## References
1. [Wikipedia - Composite pattern](https://en.wikipedia.org/wiki/Composite_pattern)
