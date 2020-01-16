# Prototype Pattern
## Definition
Prototype design pattern is used to create a duplicate object or clone of the current object to enhance performance. This pattern is used when the creation of an object is costly or complex.

**For Example**, An object is to be created after a costly database operation. We can cache the object, returns its clone on next request and update the database as and when needed thus reducing database calls.

## Problem
Prototype design pattern is used when the Object creation is a costly affair and requires a lot of time and resources and you have a similar object already existing.

## Solution
Prototype pattern provides a mechanism to copy the original object to a new object and then modify it according to our needs. Prototype design pattern uses object **Clone()** method to copy the object.

## Tutorial
1. **EmployeePrototype** - Abstract Prototype
2. **Developer & Typist** - Concrete Prototype