using System;
using System.Collections.Generic;
using System.Linq;
using Project.Model;

namespace Project.Repository
{
    public class BarRepository
    {
        private Repository _repository;

        public BarRepository()
        {
            _repository = new Repository();
        }

        public Bar Insert(Bar bar) => _repository.InsertBar(bar);
        public Bar Update(Bar bar) => _repository.UpdateBar(bar);
        public Bar Delete(Bar bar) => _repository.DeleteBar(bar);
        public Bar FindById(Guid id) => _repository.FindByIdBar(id);
        public Bar FindByName(string name) => _repository.FindByNameBar(name);

    }
}