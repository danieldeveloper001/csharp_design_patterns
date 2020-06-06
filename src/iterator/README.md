# Iterator

**Iterator** is a **behavioural design pattern** whose goal is to provide **navigation** in objects that represents
collections of data without exposing its underlying logic. In order to achieve such goal, the **iterator** encapsulates
the navigation logic and fetching data from the underlying collection logic, so that navigation strategies can be added
or removed with no changes to the **client** or to the **iterable**.

## Components and Roles

- **Client**
  - Consumes the iterable
  - Consumes the iterator (by getting it from the iterable).
- **Iterator (abstract)**
  - Creates a contract for concrete iterators
  - Provides elements fetching methods contract
  - Provides navigation methods contract
- **Iterator (concrete)**
  - Implements the contract from the abstract iterator
  - Provides elements fetching methods logic
  - Provides navigation methods logic
  - Tracks iteration progress
- **Iterable (abstract)**
  - Creates a contract for concrete iterables
  - Provides one or more method contracts for getting iterators
    - Uses an abstract iterator as return type
- **Iterable (concrete)**
  - Implements the contract from the abstract iterable
  - Provides one or more method implementation for getting iterators
    - Uses a concrete iterator as return result

## Benefits

- Allows multiple iterators to navigate through the same collection.
- Segregates navigation logic from the collection logic.
- Segregates navigation logic from the client logic.

## Drawbacks

:construction: This section is under construction.

## Examples

- [Abstract][1]
- [Practical][2]

[1]: ./001_abstract/
[2]: ./002_practical/
