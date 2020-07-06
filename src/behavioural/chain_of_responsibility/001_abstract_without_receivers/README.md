## The Abstract Without Receivers Example

**The Abstract Without Receivers Example** makes use of the **chain of responsibility design pattern** in order to
demonstrate how to process a request with multiple chained handlers that acts both as **handlers** and
**receivers**. In this example, the **client** passes multiple request to the **sender**, that assembles the chain of
responsibility in order to sequentially process the request and each handler decides if it should handle the request or
pass the request to the next handler.