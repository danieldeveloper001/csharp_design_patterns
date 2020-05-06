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
        private IList<Foo> _foo;
        private IList<Bar> _bar;
        private IList<Baz> _baz;

        public Foo InsertFoo(Foo foo)
        {
            _foo.Add(foo);
            foo.Id = _foo.IndexOf(foo);

            return foo;
        }

        public Bar InsertBar(Bar bar)
        {
            _bar.Add(bar);
            bar.Id = _bar.IndexOf(bar);

            return bar;
        }

        public Baz InsertBaz(Baz baz)
        {
            _baz.Add(baz);
            baz.Id = _baz.IndexOf(baz);

            return baz;
        }

        public Foo UpdateFoo(Foo foo)
        {
            var foundFoo = _foo.FirstOrDefault(x => x.Id == foo.Id);

            foo.Id = foundFoo.Id;
            foundFoo = foo;

            return foundFoo;
        }

        public Bar UpdateBar(Bar bar)
        {
            var foundBar = _bar.FirstOrDefault(x => x.Id == bar.Id);

            bar.Id = foundBar.Id;
            foundBar = bar;

            return foundBar;
        }

        public Baz UpdateBaz(Baz baz)
        {
            var foundBaz = _baz.FirstOrDefault(x => x.Id == baz.Id);

            baz.Id = foundBaz.Id;
            foundBaz = baz;

            return foundBaz;
        }

        public Foo DeleteFoo(Foo foo)
        {
            var foundFoo = _foo.FirstOrDefault(x => x.Id == foo.Id);
            _foo.Remove(foundFoo);

            return foundFoo;
        }

        public Bar DeleteBar(Bar bar)
        {
            var foundBar = _bar.FirstOrDefault(x => x.Id == bar.Id);
            _bar.Remove(foundBar);

            return foundBar;
        }

        public Baz DeleteBaz(Baz baz)
        {
            var foundBaz = _baz.FirstOrDefault(x => x.Id == baz.Id);
            _baz.Remove(foundBaz);

            return foundBaz;
        }

        public Foo FindByIdFoo(int id)
        {
            return _foo.FirstOrDefault(x => x.Id == id);
        }

        public Bar FindByIdBar(int id)
        {
            return _bar.FirstOrDefault(x => x.Id == id);
        }

        public Baz FindByIdBaz(int id)
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