## The Abstract With Receivers Example

**The Abstract With Receivers Example** makes use of the **chain of responsibility design pattern** in order to
demonstrate how to sequentially process a request with multiple **receivers**. In this example, the **client** passes
multiple **requests** to the **sender**, that assembles the chain of responsibility by passing multiple **receivers**
to the **handler**, responsible for their execution and for deciding if the execution should or shouldn't be interrupted
based on the received result. In this approach, the receivers are unaware of being executed by a chain of
responsibility.