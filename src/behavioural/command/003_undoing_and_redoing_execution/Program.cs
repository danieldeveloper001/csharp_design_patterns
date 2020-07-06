using System;

namespace Project
{
    class Program
    {
        static void Main(string[] args)
        {
            var content = new TextContent();
            var editor = new TextEditor();

            editor.Do(new Append(content, "Text #1!", true));
            editor.Do(new Append(content, "Text #2!", true));
            editor.Do(new Append(content, "Text #3!", true));
            Console.WriteLine($"\nContent: \n{content.Value}\n");

            editor.Do(new Replace(content, "Text", "Paragraph"));
            Console.WriteLine($"\nContent: \n{content.Value}\n");

            editor.Undo();
            Console.WriteLine($"\nContent: \n{content.Value}\n");

            editor.Do(new Prepend(content, "Text to be removed '#1'!", true));
            editor.Do(new Prepend(content, "Text to be removed '#2'!", true));
            editor.Do(new Prepend(content, "Text to be removed '#3'!", true));
            Console.WriteLine($"\nContent: \n{content.Value}\n");

            editor.Undo();
            editor.Undo();
            editor.Undo();
            Console.WriteLine($"\nContent: \n{content.Value}\n");

            editor.Redo();
            editor.Redo();
            editor.Redo();
            Console.WriteLine($"\nContent: \n{content.Value}\n");

            editor.Undo();
            editor.Undo();
            editor.Undo();
            Console.WriteLine($"\nContent: \n{content.Value}\n");
        }
    }
}
