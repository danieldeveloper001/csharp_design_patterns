# Proxy

**Proxy** is a **structural design pattern** whose goal is to manage client access to a service in a way that clients
are unaware of which one is currently being consumed, the real service or the proxy service. In order to achieve this
goal, both the real service and the proxy service implement the same contract and the proxy service stores a reference
to the real service and may consume its public interface in order to fullfill the client request. Proxy pattern four
common usage scenarios are **smart proxy**, **remote proxy**, **protective proxy** and **virtual proxy**.

## Common Scenarios

### Protective Proxy

A remote proxy acts as an access control to a service, by implementing authorization rules that will be validated prior
to invoking the real service.

### Remote Proxy

:construction: This section is under construction.
A remote proxy acts as a...
- access to remote resources as if they are local resources

### Smart Proxy

A remote proxy acts as a complement of functionality to a service, by adding functionality such as logging or value
aggregation (ex.: avg, sum or count) either before or after invoking the real service.

### Virtual Proxy

:construction: This section is under construction.
A virtual proxy acts as a...
- handling expensive object creation
- caching
- lazy loading

## Components and Roles

- **service (abstract)**
  - Defines a contract to one or more real services and proxy services
- **service (concrete)**
  - Implements the contract from the abstract service
- **proxy**
  - Implements the contract from the abstract service
  - Performs additional steps in order to manage access to the real service
  - Decides whether the real service must or mustn't be invoked

## Benefits

:construction: This section is under construction.
- Allows performing additional logic without breaking existing clients.

## Drawbacks

:construction: This section is under construction.

## Examples

- [Abstract][1]
- [Practical][2]

[1]: ./001_abstract/
[2]: ./002_practical/


