using System;
using System.Collections.Generic;
using System.Linq;
using Project.Model;

namespace Project.Repository
{
    /*
    This class is a facade for the larger 'repository' class, it provides just
    the functionallity that is necessary for handling 'bar' class.
    */
    public class BarRepository
    {
        private Repository _repository;

        public BarRepository(Repository repository)
        {
            _repository = repository;
        }

        public Bar Insert(Bar bar) => _repository.InsertBar(bar);
        public Bar Update(Bar bar) => _repository.UpdateBar(bar);
        public Bar Delete(Bar bar) => _repository.DeleteBar(bar);
        public Bar FindById(int id) => _repository.FindByIdBar(id);
        public Bar FindByName(string name) => _repository.FindByNameBar(name);

    }
}