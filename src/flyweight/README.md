# Flyweight

**Flyweight** is a **structural design pattern** design pattern whose goal is to allow multiple object instances with
changing data (extrinsic state) to refer to a single shared object instance that holds unchanging data (intrinsic state)
so that resources can be used more efficiently.

## Components and Roles

:construction: This section is under construction.

- **Flyweight (abstract)**
  -
- **Flyweight (concrete)**
  - holds the intrinsic state
  - implements operations that receives extrinsic state and perform some action with the intrinsic and extrinsic state
- **FlyweightFactory**
  - creates and manages a cache of object instances containing intrinsic state
- **Client**
  - consumes the flyweights through the flyweight factory

## Benefits

:construction: This section is under construction.

## Drawbacks

:construction: This section is under construction.

## Examples

- [Abstract][1]
- [Concrete][2]

[1]: ./001_abstract/
[2]: ./002_concrete/