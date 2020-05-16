# The Turn Based Strategy Game

**The Turn Based Strategy Game** makes use of the **command design pattern** for keeping track of player actions within
a game turn in order to achieve **delayed execution**. In this example, the **Program** client consumes the **GameTurn**
invoker by sending **GameAction** commands which contains both the target **GameElement** receiver and the data required
to the command execution, so that...

- Game actions can be parametrized;
- Game actions can be created but not executed during the turn planning;

...and then the **GameElement** receiver is invoked by the **GameTurn** invoker, so that...

- Game actions can be applied to the target game element during the turn execution;
- Game turn can be finished;
