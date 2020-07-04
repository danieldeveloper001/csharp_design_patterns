# Adapter

**Adapter** is a **structural design pattern** whose goal is to allow clients to interact with internal or external
existing code bases that are somehow incompatible with the current implementation, by implementing a compatibility layer
whose only responsibility is handling the conversion process without adding any additional functionality. It may be
used for adapting **requests**, **responses** and **types** for interoperability with incompatible existing internal and
external services that cannot be modified.

## Components and Roles

- **Client**
  - Consumes one or more adapters in order to interoperate with one or more adaptees.
- **Adapter (abstract)**
  - Creates the contract for concrete adapters
  - Represents the contract of the compatibility layer which makes possibile the interoperability between the
    client and the adaptee.
- **Adapter (concrete)**
  - Implements the contract from the abstract adapter
  - Represents the implementation of the compatibility layer which makes possibile the interoperability between the
    client and the adaptee.
- **Adaptee**
  - Represents the existing internal or external service that cannot be modified.

## Benefits

- Makes communication between incompatible services possible
- Segregates the adaptation process from clients, improving code reuse

## Drawbacks

:construction: This section is under construction

## Examples

- [Abstract][1]
- [Concrete (adapting existing internal services)][2]
- [Concrete (adapting existing external services)][3]

[1]: ./001_abstract/
[2]: ./002_concrete_internal_services/
[3]: ./003_concrete_external_services/
