using System;

namespace Project
{
    class Program
    {
        static void Main(string[] args)
        {
            var observer1 = new Observer();
            var observer2 = new Observer();
            var observer3 = new Observer();

            var subject = new Subject();
            subject.Attach(observer1);
            subject.Attach(observer2);
            subject.Attach(observer3);

            subject.Update("value 1", 1, true);
            subject.Notify();

            subject.Update("value 2", 2, false);
            subject.Notify();

            subject.Update("value 3", 3, true);
            subject.Update("value 4", 4, false);
            subject.Notify();

            subject.Detach(observer2);
            subject.Detach(observer3);

            subject.Update("value 5", 5, true);
            subject.Notify();
        }
    }
}
