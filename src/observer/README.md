# Observer

**Observer** is a **behavioural design pattern** whose goal is to implement a relationship between a **subject**
instance and one or more **observer** instances, that can be **attached** and **detached**, keeping them decoupled, in a
way that changes to the subject **state** are **notified** to the observers, whose state is then **updated**. It is
tipically used in event driven applications where notifications are issued from a source to one or more listeners.

## Components and Roles

- **Subject (abstract)**
  - Creates a contract for concrete subjects
  - Provides attaching method contract targeting an abstract observer
  - Provides detaching method contract targeting an abstract observer
  - Provides notify method contract
- **Subject (concrete)**
  - Implements the contract from the abstract subject
  - Implements accessor methods for the encapsulated subject state
  - Implements attaching method logic targeting an abstract observer
  - Implements detaching method logic targeting an abstract observer
  - Implements notify method logic
- **Observer (abstract)**
  - Creates a contract for concrete observers
  - Provides update state method contract
- **Observer (concrete)**
  - Implements the contract from the abstract observer
  - Implements accessor methods for the encapsulated observer state
  - Implements update state method logic

## Benefits

:construction: This section is under construction.

## Drawbacks

:construction: This section is under construction.

## Examples

- [Abstract][1]
- [Practical][2]

[1]: ./001_abstract/
[2]: ./002_practical/
