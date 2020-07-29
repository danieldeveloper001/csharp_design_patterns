# Visitor

**Visitor** is a **behavioural design pattern** whose goal is to allow extending functionality of existing classes that
may be related or unrelated at first, without tying the additional behaviour into their existing implementations. In
order to achieve such goal, **concrete visitable implementations** must share a **visitable contract** that allows
**concrete visitors** to interact with them and perform the desired additional feature.

## Components and Roles

- **Visitor (abstract)**
  - Creates a contract for concrete visitors
- **Visitor (concrete)**
  - Implements the contract from the abstract visitor
    - One or more 'visit' methods may be implemented in order to interact with one or more **visitables**
- **Visitable (abstract)**
  - Creates a contract for concrete visitables
- **Visitable (concrete)**
  - Implements the contract from the abstract visitable
    - One 'accept' method must be implemented in order to allow interaction from one or more **visitors**

## Benefits

- Allows extending behaviour of both related or unrelated classes
  - One or more behaviours can be added by implementing multiple visitors
- Decouples additional behaviour
  - When adding the feature to new implementations, allowing decoupled behaviour implementation of new classes.
  - When adding the feature to existing implementations, allowing decoupled behaviour extension of existing classes.

## Drawbacks

- The visitable encapsulation may be broken in order to allow visitors to interact with visitables.
  - Accessor methods may be used to preserve encapsulation.
- The visitor classes are highly coupled with concrete visitables in order to perform visitable specific visiting logic.

## Examples

- [Abstract][1]
- [Concrete][2]

[1]: ./001_abstract/
[2]: ./002_concrete/
