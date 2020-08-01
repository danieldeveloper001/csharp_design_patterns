# Decorator

**Decorator** is a **structural design pattern** whose goal is to allow extending a component functionality by
encapsulating it within a decorator object that can itself be enscapsulated within another decorator object. In order to
achieve such goal, one or more decorators implement the same contract as the component, allowing them to invoke one or
more operations from the component using the same contract, allowing clients to consume any combination of the component
and its decorators without distinction.

## Components and Roles

- **Component (abstract)**
  - Creates the contract for concrete components.
- **Component (concrete)**
  - Implements the contract from the abstract component.
  - Implements one or more operations targeted by the decorators.
- **Decorator (abstract)**
  - Creates the contract for concrete decorators.
  - Implements the contract from the abstract component.
- **Decorator (concrete)**
  - Implements the contract from the abstract decorator.
  - Implements one or more operations that adds functionality to one or more operations from the concrete component.

## Benefits

- Flexibilizes logic structuration through a layered structure without affecting other layers of logic
  - Allows adding new functionality by including a decorator
  - Allows removing functionality by excluding a decorator
  - Allows reorganizing functionality by changing a decorator
- Segregates responsibility

## Drawbacks

:construction: This section is under construction

## Examples

- [Abstract][1]
- [Concrete][2]

[1]: ./001_abstract/
[2]: ./002_concrete/
