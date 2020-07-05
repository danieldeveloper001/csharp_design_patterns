## The Request Pipeline Example

**The Request Pipeline Example** makes use of the **chain of responsibility design pattern** in order to sequentially
process a request for a user, passing through a request pipeline composed by a sequence of steps...

- **Logging Handler**, logs the request processing start and end.
- **Authorization Handler**. Validates the user role and determine if it should continue or break the pipeline execution
- **Request Handler**. Validates the request type and executes it

In this example, two attempts of processing the same request are performed with different users.