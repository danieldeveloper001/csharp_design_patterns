# Memento

**Memento** is a **behavioural design pattern** whose goal is to capture **state** of an object while preserving its
encapsulation and to provide means for managing the state history and undoing such changes. In order to achieve such
goal, the [...] :construction:

## Components and Roles

- **Originator**
  - Contains the state.
  - Provides a method for saving state to the memento.
  - Provides a method for reverting state from the memento.
- **Memento**
  - Contains a copy of the state from the originator.
- **Caretaker**
  - Keeps track of the created mementos.
  [...]
  - Provides a method for saving state to the memento.
  - Provides a method for reverting state from the memento.

## Benefits

:construction: This section is under construction.
- Captures and restores object state while preserving encapsulation.
-

## Drawbacks

:construction: This section is under construction.
- Resource usage can be increased if no mechanism for controlling the amount of copied instances is provided.
-

## Examples

:construction: This section is under construction.
- [Abstract][1]
- [Practical][2]

[1]: ./001_abstract/
[2]: ./002_practical/
