using System;
using System.Collections.Generic;
using System.Linq;
using Project.Model;

namespace Project.Repository
{
    public class BazRepository
    {
        private Repository _repository;

        public BazRepository()
        {
            _repository = new Repository();
        }

        public Baz Insert(Baz baz) => _repository.InsertBaz(baz);
        public Baz Update(Baz baz) => _repository.UpdateBaz(baz);
        public Baz Delete(Baz baz) => _repository.DeleteBaz(baz);
        public Baz FindById(Guid id) => _repository.FindByIdBaz(id);
        public Baz FindByName(string name) => _repository.FindByNameBaz(name);

    }
}