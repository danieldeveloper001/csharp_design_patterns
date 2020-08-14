# Abstract Factory

**Abstract Factory** is a **creational design pattern** whose goal is to provide means for creating families of related
objects and delivering them to a client. In order to achieve such goal, an **abstract factory** provides the contract
for one or more **concrete factories** that contains methods that encapsulate the creation logic for related families of
**products**.

## Components and Roles

- **Client**
  - Consumes one or more factories through the abstract factory contract.
- **Factory (abstract)**
  - Stabilishes a contract for one or more concrete factories.
- **Factory (concrete)**
  - Implements the contract from the abstract factory.
  - Implements methods for creating multiple related products.
- **Product (abstract)**
  - Stabilishes the contract for one or more concrete products.
  - Multiple abstract products may exist.
- **Product (concrete)**
  - Implements the contract from the abstract product.
  - Multiple concrete products may exist derived from each of the abstract product contracts.

## Benefits

- Aggregates creation logic of related objects in a factory.
- Decouples client from concrete products.
- Encapsulates creation logic, making it reusable.

## Drawbacks

:construction: This section is under construction.

## Examples

- [Abstract][1]
- [Concrete][2]

[1]: ./001_abstract/
[2]: ./002_concrete/
