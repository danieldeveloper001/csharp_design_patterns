using System;
using System.Collections.Generic;
using Project.Model;
using Project.Repository;

namespace Project
{
    class Program
    {
        static void ConsumeFooFacade()
        {
            var fooRepository = new FooRepository();

            fooRepository.Insert(new Foo() { Name = "foo1" });
            fooRepository.Insert(new Foo() { Name = "foo2" });
            fooRepository.Insert(new Foo() { Name = "foo3" });

            var foundInsertedFoo = fooRepository.FindByName("foo3");

            var updatedFoo = fooRepository.Update(
                new Foo()
                {
                    Id = foundInsertedFoo.Id,
                    Name = "foo333"
                });

            var deletedFoo = fooRepository.Delete(updatedFoo);
        }

        static void ConsumeBarFacade()
        {
            var barRepository = new BarRepository();

            barRepository.Insert(new Bar() { Name = "bar1" });
            barRepository.Insert(new Bar() { Name = "bar2" });
            barRepository.Insert(new Bar() { Name = "bar3" });

            var foundInsertedBar = barRepository.FindByName("bar3");

            var updatedBar = barRepository.Update(
                new Bar()
                {
                    Id = foundInsertedBar.Id,
                    Name = "bar333"
                });

            var deletedBar = barRepository.Delete(updatedBar);
        }

        static void ConsumeBazFacade()
        {
            var bazRepository = new BazRepository();

            bazRepository.Insert(new Baz() { Name = "baz1" });
            bazRepository.Insert(new Baz() { Name = "baz2" });
            bazRepository.Insert(new Baz() { Name = "baz3" });

            var foundInsertedBaz = bazRepository.FindByName("baz3");

            var updatedBaz = bazRepository.Update(
                new Baz()
                {
                    Id = foundInsertedBaz.Id,
                    Name = "baz333"
                });

            var deletedBaz = bazRepository.Delete(updatedBaz);
        }

        static void Main(string[] args)
        {
            ConsumeFooFacade();
            ConsumeBarFacade();
            ConsumeBazFacade();
        }
    }
}
