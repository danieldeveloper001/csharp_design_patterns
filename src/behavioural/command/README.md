# Command

**Command** is a **behavioural design pattern** whose goal is to capture **requests** that changes the state of an
object and to provide means for creating requests that may be trackable, undoable, redoable and delayed. In order to
achieve such goal, requests are encapsulade in **Command** classes containing all the required data to process that
request, such as the **Receiver** of the request and input parameters.

## Components and Roles

- **Client**
  - Creates and parametrizes commands.
  - Sends commands to the invoker.
- **Command**
  - Encapsulates the target receiver.
  - Encapsulates the required data for processing the request at the target receiver.
- **Invoker**
  - Receives commands from the client.
  - Keeps track of the execution.
  - Sends commands to the target receiver.
- **Receiver**
  - Receives a request from the invoker.
  - Processes a request.

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

- [Abstract][1]
- [The Account Transaction (Tracking Execution)][2]
- [The Text Editor (Undoing and Redoing Execution)][3]
- [The Turn Based Game (Delayed Execution)][4]

[1]: ./001_abstract/
[2]: ./002_tracking_executed_operations/
[3]: ./003_undoing_and_redoing_execution/
[4]: ./004_delayed_execution/