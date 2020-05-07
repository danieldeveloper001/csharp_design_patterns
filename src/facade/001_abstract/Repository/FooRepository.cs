using System;
using System.Collections.Generic;
using System.Linq;
using Project.Model;

namespace Project.Repository
{
    /*
    This class is a facade for the larger 'repository' class, it provides just
    the functionallity that is necessary for handling 'foo' class.
    */
    public class FooRepository
    {
        private Repository _repository;

        public FooRepository()
        {
            _repository = new Repository();
        }

        public Foo Insert(Foo foo) => _repository.InsertFoo(foo);
        public Foo Update(Foo foo) => _repository.UpdateFoo(foo);
        public Foo Delete(Foo foo) => _repository.DeleteFoo(foo);
        public Foo FindById(Guid id) => _repository.FindByIdFoo(id);
        public Foo FindByName(string name) => _repository.FindByNameFoo(name);

    }
}