# Template Method

**Template Method** is a **behavioural design pattern** whose goal is to allow implementing an algorithm in a way that
makes possible for it being shared among multiple concrete implementations from a given abstraction, while still being
able to change parts of its behaviour within the concrete implementations.

## Components and Roles

- **Class (abstract)**
  - Creates the contract for concrete class
    - Template method skeleton
    - Abstract methods for contract of specific behaviours
- **Class (concrete)**
  - Implements the contract from the abstract class
    - Overriden methods for implementation of specific behaviours
- **Client**
  - Consumes the concrete classes resulting behaviour

## Benefits

- Prevents source code duplication on multiple contract classes

## Drawbacks

- Requires additional effort at designing the solution to ensure that abstract and concrete classes really have a
  relationship and really share behaviour
  - Poorly implemented template methods could lead to unimplemented overrides on the concrete classes.
- Changes to the abstract class behaviour affect multiple concrete classes behaviour
  - Poor implemented template methods could lead to breaking concrete classes when shared behaviour changes on the
    abstract class

## Examples

- [Abstract][1]
- [Concrete][2]

[1]: ./001_abstract/
[2]: ./002_concrete/