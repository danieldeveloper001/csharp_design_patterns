# The Abstract Example

**The Abstract Example** makes use of the **mediator design pattern** to demonstrate how the **mediator** class handles
communication between multiple **colleague** classes. In order to achieve such goal, the colleagues receive the mediator
that will handle their communication and the mediator has references to each one of the colleagues interested in the
communication themselves and send notifications to each other through a send method on the mediator.
