using System;

namespace Project
{
    class Program
    {
        static void Main(string[] args)
        {
            var originator = new Originator();
            var caretaker = new Caretaker();

            originator.Property1 = "a";
            originator.Property2 = 1;
            originator.Property3 = true;
            var memento1 = originator.Capture();
            caretaker.Capture(memento1);

            originator.Property1 = "b";
            originator.Property2 = 2;
            originator.Property3 = false;
            var memento2 = originator.Capture();
            caretaker.Capture(memento2);

            originator.Property1 = "b";
            originator.Property2 = 2;
            originator.Property3 = true;
            var memento3 = originator.Capture();
            caretaker.Capture(memento3);
        }
    }
}
