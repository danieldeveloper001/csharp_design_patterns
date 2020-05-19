# The Account Transaction

**The Account Transaction** makes use of the **command design pattern** for executing movement actions in a bank account
in order to achieve **trackable execution of succesful and unsuccessful operations**. In this example, the **Program**
client consumes the **Transaction** invoker by sending **Deposit**, **Withdrawal** and **Interest** commands which
contains both the target **Account** receiver and the data required to the command execution, so that...

- Actions can be tracked by the invoker and validated by the receiver prior to execution.
- Successfully and unsucessfully actions can be tracked by the invoker.
- Reports can be generated from the tracked actions.