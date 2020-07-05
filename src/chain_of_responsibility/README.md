# Chain of Responsibility

**Chain of Responsibility** is a **behavioural design pattern** whose goal is to sequentially process a request by one
or more linked handlers that make the decision if the request should be processed by the current handler or sent to the
next one until the end of the execution pipeline is reached. In order to achieve such goal, each step of the processing
logic is implemented in indepent **handlers** that are linked in a **sender** that invokes the first handler in the
execution pipeline.

## Components and Roles

- **Sender**
 - Creates the handler execution pipeline by linking handler instances
 - Invokes the handler execution pipeline
- **Handler (abstract)**
  - Creates the contract for concrete handlers
    - Defines a handling method
    - Defines a next setter
- **Handler (concrete)**
  - Implements the contract from the abstract handler
    - Implements a handling method
      - Decides if the request should be processed by the current handler
      - Decides if the request should be sent to the next handler
      - May have return values
      - May terminate the request pipeline

## Benefits

- Object oriented programming approach for sequentially processing a request (if...else if...else)
  - Complex scenarios may benefit from the object oriented approach by adding and removing steps from the chain of
    responsibility easily without breaking existing code
- Reduces multiple conditional logic from a single method
  - Makes code easier to add or remove handling functionality
  - Makes code easier to test
  - Promotes segregation of responsibilities
- Decouples the client from the concrete request processing logic

## Drawbacks

- Structured programming approach requires less code (if...else if...else)
  - Simple scenarios may benefit from the simplicity of using simple conditional statements that are easier to implement

## Examples

- [Abstract (handlers use linked approach, without receivers)][1]
- [Abstract (handlers use collection approach, with receivers)][2]
- [Concrete][3]

[1]: ./001_abstract_without_receivers/
[2]: ./002_abstract_with_receivers/
[3]: ./003_concrete/
