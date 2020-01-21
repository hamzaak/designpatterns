# Interpreter Pattern
## Definition
Interpreter Design pattern evaluates/ interprets the instructions written in a language grammar or notations. This pattern involves implementing an expression interface which tells to interpret a particular context. This pattern is used in the compilers or parsers or Macro expansions.

## Problem
* A grammar for a simple language should be defined
* so that sentences in the language can be interpreted.
When a problem occurs very often, it could be considered to represent it as a sentence in a simple language (Domain Specific Languages) so that an interpreter can solve the problem by interpreting the sentence.

For example, when many different or complex search expressions must be specified. Implementing (hard-wiring) them directly into a class is inflexible because it commits the class to particular expressions and makes it impossible to specify new expressions or change existing ones independently from (without having to change) the class.

## Solution
* Define a grammar for a simple language by defining an Expression class hierarchy and implementing an interpret() operation.
* Represent a sentence in the language by an abstract syntax tree (AST) made up of Expression instances.
* Interpret a sentence by calling interpret() on the AST.
The expression objects are composed recursively into a composite/tree structure that is called abstract syntax tree (see Composite pattern).
The Interpreter pattern doesn't describe how to build an abstract syntax tree. This can be done either manually by a client or automatically by a parser.

## Tutorial
1. **Context** - This is a class that contains information (input and output), which is used by the Interpreter.
2. **AbstractExpression** - This is an interface that defines the Interpret operation, which must be implemented by each subclass.
3. **NonterminalExpression** - This is a class that implements the Expression. This can have other instances of Expression.
4. **TerminalExpression** - This is a class that implements the Expression.

## References
1. [dotnettricks.com - Interpreter Design Pattern - C#](https://www.dotnettricks.com/learn/designpatterns/interpreter-design-pattern-c-sharp)
2. [Wikipedia - Interpreter Pattern](https://en.wikipedia.org/wiki/Interpreter_pattern)
