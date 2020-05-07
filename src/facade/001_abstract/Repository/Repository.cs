using System;
using System.Collections.Generic;
using System.Linq;
using Project.Model;

namespace Project.Repository
{
    /*
    This class is neither concise nor cohese, it provides the functionallity
    that is necessary for handling 'foo', bar' and 'baz' classes and is a target
    for facade classes, as such.

    - FooRepository facade, for handling only Foo class.
    - BarRepository facade, for handling only Bar class.
    - BazRepository facade, for handling only Baz class.
    */
    public class Repository
    {
        private static IList<Foo> _foo = new List<Foo>();
        private static IList<Bar> _bar = new List<Bar>();
        private static IList<Baz> _baz = new List<Baz>();

        public Foo InsertFoo(Foo foo)
        {
            foo.Id = Guid.NewGuid();
            _foo.Add(foo);

            return foo;
        }

        public Bar InsertBar(Bar bar)
        {
            bar.Id = Guid.NewGuid();
            _bar.Add(bar);

            return bar;
        }

        public Baz InsertBaz(Baz baz)
        {
            baz.Id = Guid.NewGuid();
            _baz.Add(baz);

            return baz;
        }

        public Foo UpdateFoo(Foo foo)
        {
            var foundFoo = _foo.FirstOrDefault(x => x.Id == foo.Id);
            if (foundFoo is null)
                return null;

            foundFoo.Name = foo.Name;
            return foundFoo;
        }

        public Bar UpdateBar(Bar bar)
        {
            var foundBar = _bar.FirstOrDefault(x => x.Id == bar.Id);
            if (foundBar is null)
                return null;

            foundBar.Name = bar.Name;
            return foundBar;
        }

        public Baz UpdateBaz(Baz baz)
        {
            var foundBaz = _baz.FirstOrDefault(x => x.Id == baz.Id);
            if (foundBaz is null)
                return null;

            foundBaz.Name = baz.Name;
            return foundBaz;
        }

        public Foo DeleteFoo(Foo foo)
        {
            var foundFoo = _foo.FirstOrDefault(x => x.Id == foo.Id);
            if (foundFoo is null)
                return null;

            _foo.Remove(foundFoo);
            return foundFoo;
        }

        public Bar DeleteBar(Bar bar)
        {
            var foundBar = _bar.FirstOrDefault(x => x.Id == bar.Id);
            if (foundBar is null)
                return null;

            _bar.Remove(foundBar);
            return foundBar;
        }

        public Baz DeleteBaz(Baz baz)
        {
            var foundBaz = _baz.FirstOrDefault(x => x.Id == baz.Id);
            if (foundBaz is null)
                return null;

            _baz.Remove(foundBaz);
            return foundBaz;
        }

        public Foo FindByIdFoo(Guid id)
        {
            return _foo.FirstOrDefault(x => x.Id == id);
        }

        public Bar FindByIdBar(Guid id)
        {
            return _bar.FirstOrDefault(x => x.Id == id);
        }

        public Baz FindByIdBaz(Guid id)
        {
            return _baz.FirstOrDefault(x => x.Id == id);
        }

        public Foo FindByNameFoo(string name)
        {
            return _foo.FirstOrDefault(x => x.Name == name);
        }

        public Bar FindByNameBar(string name)
        {
            return _bar.FirstOrDefault(x => x.Name == name);
        }

        public Baz FindByNameBaz(string name)
        {
            return _baz.FirstOrDefault(x => x.Name == name);
        }

    }
}