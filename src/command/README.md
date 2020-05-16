# Command

[C# Design Patterns][1] > Command

**Command** is a **behavioural design pattern** whose goal is to provide means for creating requests that may be
trackable, undoable, redoable and delayed. In order to achieve such goal, requests are encapsulade in **Command**
classes containing all the required data to process that request, such as the **Receiver** of the request and input
parameters.

## Benefits

- Allows keeping track of successfully and unsuccessfully executed requests, since the invoker may store the requests
  and categorize them by execution results.
- Allows undoable and redoable operations, since the invoker may store them and provide logic for undoing or redoing
  actions on the target receiver.
- Allows delaying execution, since the invoker may store the requests for later execution rather than executing them
  directly.
- Decouples the client from the receiver by delegating commands through the invoker.
- Improves code semantics and reuse, since command classes express easy to understand and parametrizable actions that
  will be applied on receivers.

## Drawbacks

:construction: This section is under construction.

- Increases complexity, since in simple scenarios a client could call and parametrize a receiver directly rather than
  through the invoker.


## Examples

- [Abstract][2]
- [Tracking Execution][3]
- [Undoing and Redoing Execution][4]
- [Delayed Execution][5]

[1]: ../../
[2]: ./001_abstract/
[3]: ./002_tracking_executed_operations/
[4]: ./003_undoing_and_redoing_execution/
[5]: ./004_delayed_execution/