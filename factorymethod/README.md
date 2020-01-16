# Factory Method Pattern
## Definition
Creating an object often requires complex processes not appropriate to include within a composing object. The object's creation may lead to a significant duplication of code, may require information not accessible to the composing object, may not provide a sufficient level of abstraction, or may otherwise not be part of the composing object's concerns. The factory method design pattern handles these problems by defining a separate method for creating the objects, which subclasses can then override to specify the derived type of product that will be created.

The factory method pattern relies on inheritance, as object creation is delegated to subclasses that implement the factory method to create objects.

> "Define an interface for creating an object, but let subclasses decide which class to instantiate. The Factory method lets a class defer instantiation it uses to subclasses." (Gang Of Four)

## Problem
Creating an object directly within the class that requires or uses the object is inflexible because it commits the class to a particular object and makes it impossible to change the instantiation independently of the class. A change to the instantiator would require a change to the class code which we would rather not touch. This is referred to as code coupling and the Factory method pattern assists in decoupling the code.

## Solution
The Factory Method design pattern is used by first defining a separate operation, a factory method, for creating an object, and then using this factory method by calling it to create the object. This enables writing of subclasses that decide how a parent object is created and what type of objects the parent contains.

## Tutorial
1. **CreditCard** - Abstract Class
2. **MoneyBackCreditCard, TitaniumCreditCard and PlatinumCreditCard** - Concreate Product classes
3. **CardFactory** - Creator
4. **MoneyBackFactory, TitaniumFactory and PlatinumFactory** - Concreate Creators
