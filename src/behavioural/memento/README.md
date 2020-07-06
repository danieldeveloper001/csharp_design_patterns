# Memento

**Memento** is a **behavioural design pattern** whose goal is to capture **state** of an object, to provide means for
managing the state history and to allow undoing such changes without violating the object encapsulation.

## Components and Roles

- **Originator**
  - Contains the state.
  - Provides a method for saving state to the memento.
  - Provides a method for reverting state from the memento.
- **Memento**
  - Contains a copy of the state from the originator.
- **Caretaker**
  - Keeps track of the created mementos.
  - Provides a method for saving state to the history.
  - Provides a method for reverting state from the history.

## Benefits

- Preserves encapsulation, since state can be captured and restored through methods within it.
- Provides state capturing and restoring functionality that can be invoked at any time.

## Drawbacks

:construction: This section is under construction.
- Resource usage can be increased if no mechanism for controlling the amount of copied instances is provided.

## Examples

- [Abstract][1]
- [Practical][2]

[1]: ./001_abstract/
[2]: ./002_practical/
