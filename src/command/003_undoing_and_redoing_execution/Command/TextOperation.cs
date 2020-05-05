using System;

namespace Project
{
    public interface ITextOperation
    {
        ITextContent Target { get; }

        void Do();
        void Undo();
    }

    public class Append : ITextOperation
    {
        public ITextContent Target { get; private set; }
        public string Value { get; private set; }
        public bool WithNewLine { get; private set; }
        private string _originalValue;

        public Append(ITextContent target, string value, bool withNewLine)
        {
            Target = target;
            Value = value;
            WithNewLine = withNewLine;

            _originalValue = target.Value;
        }

        public void Do() => Target.Append(Value, WithNewLine);

        public void Undo() => Target.Replace(Target.Value, _originalValue);
    }

    public class Replace : ITextOperation
    {
        public ITextContent Target { get; private set; }
        public string OldValue { get; private set; }
        public string NewValue { get; private set; }

        public Replace(ITextContent target, string oldValue, string newValue)
        {
            Target = target;
            OldValue = oldValue;
            NewValue = newValue;
        }

        public void Do() => Target.Replace(OldValue, NewValue);

        public void Undo() => Target.Replace(NewValue, OldValue);
    }

    public class Prepend : ITextOperation
    {
        public ITextContent Target { get; private set; }
        public string Value { get; private set; }
        public bool WithNewLine { get; private set; }
        private string _originalValue;

        public Prepend(ITextContent target, string value, bool withNewLine)
        {
            Target = target;
            Value = value;
            WithNewLine = withNewLine;

            _originalValue = target.Value;
        }

        public void Do() => Target.Prepend(Value, WithNewLine);

        public void Undo() => Target.Replace(Target.Value, _originalValue);
    }
}
