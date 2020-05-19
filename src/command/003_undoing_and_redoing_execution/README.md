# The Text Editor

**The Text Editor** makes use of the **command design pattern** for keeping track of text editing actions in order to
achieve **undoable and redoable operations**. In this example, the **Program** client consumes the **TextEditor**
invoker by sending **Append**, **Prepend** and **Replace** commands which contains both the target **TextContent**
receiver and the data required to the command execution, so that...

- Actions can be perfomed by the **Do** method at the invoker.
- Actions can be undone by the **Undo** method at the invoker by removing actions from the **Undo** stack, adding to the
  **Redo** stack and executing the respective action at the command.
- Actions can be redone by the **Redo** method at the invoker by removing actions from the **Redo** stack, adding to the
  **Undo** stack and executing the respective action at the command.
