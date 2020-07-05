# Prototype

**Prototype** is a **creational design pattern** whose goal is to reduce object creation cost, either for expensive to
create objects or for large collections of objects, while still producing unique instances that shares values for its
properties, either by creating **shallow copies** or **deep copies**. In order to achieve such goal, objects are
created with a predefined state that is shared among multiple instances of the same type and are optionally managed in
a registry.

## Components and Roles

- **Client**
  - Consumes instances created from prototypes
- **Prototype (abstract)**
  - Creates the contract for concrete prototypes
    - Cloning method contract
- **Prototype (concrete)**
  - Implements the contract from the abstract prototype
    - Cloning method implementation (shallow copy or deep copy)
- **Registry**
  - Manages a collection of commonly used prototypes

## Benefits

- Segregates object creation logic from clients
- Avoids subclassing by creating object templates with predefined state
- Manages object templates in a registry so that they are created only once during the application lifecycle

## Drawbacks

:construction: This section is under construction

## Examples

- [Abstract (with shallow copy)][1]
- [Abstract (with deep copy)][2]
- [Abstract (with registry)][3]
- [Concrete][4]

[1]: ./001_abstract_shallow_copy/
[2]: ./002_abstract_deep_copy/
[3]: ./003_abstract_registry/
[4]: ./004_concrete/
