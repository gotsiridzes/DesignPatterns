# Design Patterns
Design patterns implementation in C# programming language.

# SOLID Design Principles

## Single Responsibility Principle
A Class should have only one reason to change.
Separation of concerns - different classes handle different, independent tasks/problems.

## Open-Closed Principle
States that parts of application should be open for extension and closed for modification. 
For example add more filters without going back to filter class.

## Liskov Substitution Principle
Should be able to substitute a base type for a subtype.

## Interface Segregation Principle
Don't put too much into an interface. Split into separate interfaces.

## Dependency Inversion Principle

High level modules shouldn't depend on low level parts of application.
They should depend on some kind of abstraction.

# Creational Design Patterns
Creational patterns provide various object creation mechanisms, which increase flexibility and reuse of existing code.

## Builder
When you are constructing string from different pieces, you dont want to have multiple '+' signs for concatenating one string or have dozens of constructor arguments for doing the same.
Instead, we should use piecewise construction, by allowing user to construct object piece by piece and provide good API for doing it.

Fluent Builder - (fluent interface) an interface which allows you to chain several calls by returning a reference to the object.
Fluent Builder Inheritance with recursive generics
Faceted Builder

