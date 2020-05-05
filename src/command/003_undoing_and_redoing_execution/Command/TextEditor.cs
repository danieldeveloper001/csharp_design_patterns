using System;
using System.Collections.Generic;

namespace Project
{
    interface ITextEditor
    {
        Stack<ITextOperation> UndoStack { get; }
        Stack<ITextOperation> RedoStack { get; }

        void Do(ITextOperation operation);
        void Undo();
        void Redo();
    }

    class TextEditor : ITextEditor
    {
        public Stack<ITextOperation> UndoStack { get; private set; }
        public Stack<ITextOperation> RedoStack { get; private set; }

        public TextEditor()
        {
            UndoStack = new Stack<ITextOperation>();
            RedoStack = new Stack<ITextOperation>();
        }

        public void Do(ITextOperation operation)
        {
            operation.Do();
            UndoStack.Push(operation);
            RedoStack.Clear();
        }

        public void Undo()
        {
            if (UndoStack.Count == 0)
                return;

            var operation = UndoStack.Pop();
            operation.Undo();
            RedoStack.Push(operation);
        }

        public void Redo()
        {
            if (RedoStack.Count == 0)
                return;

            var operation = RedoStack.Pop();
            operation.Do();
            UndoStack.Push(operation);
        }

    }
}
