# Adapter Pattern
## Definition
An adapter allows two incompatible interfaces to work together. This is the real-world definition for an adapter. Interfaces may be incompatible, but the inner functionality should suit the need. The adapter design pattern allows otherwise incompatible classes to work together by converting the interface of one class into an interface expected by the clients.

In software engineering, the adapter pattern is a software design pattern (also known as wrapper, an alternative naming shared with the decorator pattern) that allows the interface of an existing class to be used as another interface. It is often used to make existing classes work with others without modifying their source code.

## Problem
The adapter design pattern solves problems like:
* How can a class be reused that does not have an interface that a client requires?
* How can classes that have incompatible interfaces work together?
* How can an alternative interface be provided for a class?
Often an (already existing) class can't be reused only because its interface doesn't conform to the interface clients require.

## Solution
The adapter design pattern describes how to solve such problems:
* Define a separate adapter class that converts the (incompatible) interface of a class (adaptee) into another interface (target) clients require.
* Work through an adapter to work with (reuse) classes that do not have the required interface.
The key idea in this pattern is to work through a separate adapter that adapts the interface of an (already existing) class without changing it.
Clients don't know whether they work with a target class directly or through an adapter with a class that does not have the target interface.

## Tutorial
1. **ITraget** - Target interface
2. **Employee Adapter** - Adapter Class
3. **HR System** - Adaptee Class
4. **ThirdPartyBillingSystem** - Client
