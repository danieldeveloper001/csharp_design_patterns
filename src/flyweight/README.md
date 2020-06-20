# Flyweight

**Flyweight** is a **structural design pattern** whose goal is to allow multiple object instances to share unchanging
data (intrinsic state) while still being able to perform operations involving changing data (extrinsic state) so that
computing resources can be used more efficiently. Such instances that contain only intrinsic state are created on demand
and managed within a cache so that their creation process happen only once during the application's lifecycle.

## Components and Roles

- **Flyweight (abstract)**
  - Creates the contract for concrete flyweights
    - Contract may include intrinsic state that is write once, read many
    - Contract may include operations that deal with intrinsic and extrinsic state
- **Flyweight (concrete)**
  - Implements the contract from abstract flyweight
    - Implementation may include intrinsic state that is write once, read many
    - Implementation may include operations that deal with intrinsic and extrinsic state
- **FlyweightFactory**
  - Creates concrete flyweight instances
    - Creation may be on demand
    - Creation may be cached
- **Client**
  - Consumes concrete flyweights through the flyweight factory

## Benefits

- Reduces computing resources usage, since instances are created on demand and only once

## Drawbacks

:construction: This section is under construction.


## Examples

- [Abstract][1]
- [Concrete][2]

[1]: ./001_abstract/
[2]: ./002_concrete/