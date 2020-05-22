# Factory Method

**Factory Method** is a **creational design pattern** whose goal is to hide instatiation logic by defining a
parametrized interface for creating different types of objects derived from the same contract so that clients can
consume these object, but are decoupled from the creation logic itself. In order to achieve such goal, the factory
method delegates the object creation responsibility to the subclasses that implements this contract.

## Components and Roles

- **Client**
  - Creates concrete products by invoking concrete creators.
  - Consumes the concrete products.
- **Creator (abstract)**
  - Stabilishes an abstract contract for the concrete creators so that abstract products can be created.
- **Creator (concrete)**
  - Handles the concrete product creation logic.
  - Each concrete creator is responsible for creating its concrete product.
- **Product (abstract)**
  - Stabilishes an abstract contract for the the concrete products.
- **Product (concrete)**
  - Handles the concrete product logic.
  - Each concrete product is created by its concrete creator.

## Benefits

- Creates a single common contract for related products creation.
- Decouples clients from products so that products can be consumed without tying the client to the creation logic.
- Encapsulates the products creation logic within product creators, so that product creation logic changes affect the
  factory method but not the clients themselves.

## Drawbacks

:construction: This section is under construction.

## Examples

- [Abstract][1]

[1]: ./001_abstract/
