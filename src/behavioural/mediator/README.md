# Mediator

**Mediator** is a **behavioural design pattern** whose goal is to provide **communication** among multiple decoupled
**colleagues**  that may send and receive notifications to each other through a communication **mediator**. In order to
achieve such goal, the mediator holds instances for the colleagues interested in the communication, so that the
colleagues themselves are completely unaware of each other, while still being able to send notifications through the
mediator. In its turn, the mediator contains the logic for sending and receivng message between them.

## Components and Roles

- **Mediator (abstract)**
  - Creates a contract for concrete mediators
- **Mediator (concrete)**
  - Implements the contract from the abstract mediator
  - Contains the communication logic
    - Receives communication requests from one colleague
    - Sends communication requests to one or more colleagues
- **Colleague (abstract)**
  - Creates a contract for concrete colleagues
- **Colleague (concrete)**
  - Implements the contract from the abstract colleague
    - Receives communication requests from other colleagues through the mediator
    - Sends communication requests to other colleagues through the mediator

## Benefits

- Allows communication and respective rules being implemented in a single and centralized place
  - Communication may be implemented in as a message broadcast fashion
  - Communication may be implemented in as a message sender and receiver fashion
- Promotes decoupling between colleagues, making the code base more maintainable

## Drawbacks

- Makes debugging harder, since once a message is sent through the mediator, multiple colleagues could be notified

## Examples

- [Abstract][1]
- [Concrete][2]

[1]: ./001_abstract/
[2]: ./002_concrete/
