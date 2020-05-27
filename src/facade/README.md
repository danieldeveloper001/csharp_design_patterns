# Facade

**Facade** is a **structural design pattern** design pattern whose goal is to provide means for creating easier to
consume contracts. In order to achieve such goal, it provides a concise and cohese set of operations that can consume
functionality either from large classes (in which case a subset of these operations will be consumed) or from multiple
small classes (in which case these operations will be aggregated into a single operation that by itself has a meaning).

## Components and Roles

- **Client**
  - Consumes the facade contract.
- **Facade**
  - Creates and exposes a new contract.
    - Option 1: a contract that exposes a subset of exposed operations from a large contract.
    - Option 2: a contract that aggregates and exposes functionality from a set of operations from small independent
      contracts.

## Benefits

- Allows refactoring large contracts into one or more concise and cohese set of operations for specific usage scenarios.
- Allows aggregating functionality from a set of operations from small independent contracts that together are a
  meaningful operation by itself and that would otherwise be called by one or more clients.

## Drawbacks

:construction: This section is under construction.

## Examples

- [Simplifying Contracts][1]
- [Simplifying Consumption][2]

[1]: ./001_simplifying_contracts/
[2]: ./002_simplifying_consumption/