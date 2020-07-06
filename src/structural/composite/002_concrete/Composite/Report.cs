using System;
using System.Collections.Generic;

namespace Project
{
    class Report : ReportComponent
    {
        private IList<ReportComponent> _children;
        private string _period;

        public Report(string period)
        {
            _children = new List<ReportComponent>();
            _period = period;
        }

        public void Add(ReportComponent component) =>
            _children.Add(component);

        public void Remove(ReportComponent component) =>
            _children.Remove(component);

        public override void Display()
        {
            Console.WriteLine($"===== {_period}");
            foreach(var child in _children)
                child.Display();
        }
    }
}
