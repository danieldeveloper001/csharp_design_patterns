using System;
using System.Collections.Generic;

namespace Project
{
    public interface ITextContent
    {
        string Value { get; }

        void Append(string content, bool withNewLine);
        void Replace(string oldValue, string newValue);
        void Prepend(string content, bool withNewLine);
    }

    public class TextContent : ITextContent
    {
        public string Value { get; private set; }

        public TextContent()
        {
            Value = String.Empty;
        }

        public void Append(string content, bool withNewLine) =>
            Value = $"{Value}{(withNewLine && Value != String.Empty ? "\n" : "")}{content}";

        public void Replace(string oldValue, string newValue) =>
            Value = Value.Replace(oldValue, newValue);

        public void Prepend(string content, bool withNewLine) =>
            Value = $"{content}{(withNewLine && Value != String.Empty ? "\n" : "")}{Value}";
    }
}
