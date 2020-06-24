# State

**State** is a **behavioural design pattern** whose goal is to allow context objects to have different behaviours
depending using on its current state, using a class based approach rather than a flag based approach, in order to
achieve more maintainable and resilient implementations. States can be added or removed from the state machine without
affecting transition logic of already implemented states (unless required by changes on the business rules). In order to
achieve this goal, the context object subject of the state transition is created with an initial state, that can be then
transitioned to other states and manipulated by them in order to complete the transition. In addition to that, the list
of possible states must be mapped, as though conditions for transitioning from and to them, such as...

- What are the changes that the state must perform on the subject for the state transition?
- What are the behaviours that should be encapsulated within the state?
- Which states can the current state be transitioned to?
- Which states can't the current state be transitioned to?

## Components and Roles

- **Context**
  - Subject of state transitions
  - Implements a method for setting the current state
  - Stores an instance for the current state
    - It is created with one initial state
    - It can be transitioned from the current state to another state, which will in turn become the current state
- **State (abstract)**
  - Defines a contract to one or more concrete state implementations
  - Defines one or more behaviour methods contract
- **State (concrete)**
  - Implements the contract from the abstract state
  - Implements one or more behaviour methods logic
    - Handles the context instance transitions from another state the current state

## Benefits

- Minimizes the usage of conditional logic managing state transition implications
  - Simplifies implementation
  - Simplifies debugging
- States are semantically represented with classes
  - Makes code easier to understand
- Prevents the usage of multiple flags for controlling context object state
- Prevents interdependent logic between states

## Drawbacks

- Complexity for simpler scenarios, such as an 'enabled-disabled' state change

## Examples

- [Abstract][1]
- [Concrete][2]

[1]: ./001_abstract/
[2]: ./002_concrete/
