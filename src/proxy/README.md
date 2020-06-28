# Proxy

**Proxy** is a **structural design pattern** whose goal is to manage client access to a service in a way that clients
are unaware of which one is currently being consumed, the real service or the proxy service. In order to achieve this
goal, both the real service and the proxy service implement the same contract and the proxy service stores a reference
to the real service and may consume its public interface in order to fullfill the client request. Proxy pattern four
common usage scenarios are **smart proxy**, **remote proxy**, **protective proxy** and **virtual proxy**.

- **Protective Proxy**: a protective proxy acts as an access control to a service, by implementing authorization logic
  that will be validated prior to invoking the real service.
- **Remote Proxy**: a remote proxy acts as an access point for a service, by implementing communication logic that will
  be used to communicate with a remotely available real service, making it available for the application as if it is a
  local resource.
- **Smart Proxy**: a smart proxy acts as an aggregator of functionality to a service, by implementing logic that will be
  executed before or after invoking the real service.
- **Virtual Proxy**: a virtual proxy acts as an [...], by implementing features such as lazy loading logic that will
  provide on demand object creation when consuming the real service or caching that will prevent the same resource from
  being repeatedly requested when consuming the real service.

## Components and Roles

- **Service (abstract)**
  - Defines a contract to one or more real services and proxy services
- **Service (concrete)**
  - Implements the contract from the abstract service
- **Proxy**
  - Implements the contract from the abstract service
  - Performs additional steps in order to manage access to the real service
  - Decides whether the real service must or mustn't be invoked

## Benefits

- Allows additional logic execution without breaking existing clients when consuming existing services.
- Allows increasing application security by implementing authentication or authorization logic between the internal
  clients and the real service (protective proxy).
- Allows facilitating application access to external resources by implementing communication logic between the internal
  clients and the real service (remote proxy).
- Allows providing additional functionality by implementing additional logic between the internal clients and the real
  service (smart proxy).
- Allows increasing application performance by implementing caching logic or lazy loading logic between the internal
  clients and the real service (virtual proxy).

## Drawbacks

:construction: This section is under construction.
- Doesn't allow "stacking" multiple proxies.
- [TODO: FURTHER ELABORATE] Resembles other design patterns.
  - Decorator for the smart proxy;
  - Flyweight for the virtual proxy used as a cache;

## Examples

- [Protective Proxy (abstract)][1]
- [Remote Proxy (abstract)][2]
- [Smart Proxy (abstract)][3]
- [Virtual Proxy (abstract)][4]
- :construction: [Protective Proxy (concrete)][5]
- :construction: [Remote Proxy (concrete)][6]
- :construction: [Smart Proxy (concrete)][7]
- :construction: [Virtual Proxy (concrete)][8]

[1]: ./001_abstract_protective_proxy/
[2]: ./002_abstract_remote_proxy/
[3]: ./003_abstract_smart_proxy/
[4]: ./004_abstract_virtual_proxy/
[5]: ./005_concrete_protective_proxy/
[6]: ./006_concrete_remote_proxy/
[7]: ./007_concrete_smart_proxy/
[8]: ./008_concrete_virtual_proxy/
