# Strategy Pattern
## Definition
The strategy pattern (also known as the policy pattern) is a behavioral software design pattern that enables selecting an algorithm at runtime. Instead of implementing a single algorithm directly, code receives run-time instructions as to which in a family of algorithms to use.

For instance, a class that performs validation on incoming data may use the strategy pattern to select a validation algorithm depending on the type of data, the source of the data, user choice, or other discriminating factors. These factors are not known until run-time and may require radically different validation to be performed. The validation algorithms (strategies), encapsulated separately from the validating object, may be used by other validating objects in different areas of the system (or even different systems) without code duplication.

Typically the strategy pattern stores a reference to some code in a data structure and retrieves it. This can be achieved by mechanisms such as the native function pointer, the first-class function, classes or class instances in object-oriented programming languages, or accessing the language implementation's internal storage of code via reflection.

## Problem
The strategy pattern is used to solve problems that might (or is foreseen they might) be implemented or solved by different strategies and that possess a clearly defined interface for such cases. Each strategy is perfectly valid on its own with some of the strategies being preferable in certain situations that allow the application to switch between them during runtime.

## Solution
Strategy Pattern prevents hard-wiring of all the algorithms into the program. This makes our program complex and much more bogus and hard to refactor/maintain and understand.

## Tutorial
1. **Customer** - This is a class that contains a property to hold the reference of a Strategy object. This property will be set at run-time according to the algorithm that is required.
2. **IBillingStrategy** - This is an interface that is used by the Customer object to call the algorithm defined by a ConcreteStrategy.
3. **NormalStrategy and HappyHourStrategy** - These are classes that implement the IBillingStrategy interface.

## References
1. [Wikipedia - Strategy pattern](https://en.wikipedia.org/wiki/Strategy_pattern)
