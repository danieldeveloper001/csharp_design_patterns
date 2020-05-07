using System;
using System.Collections.Generic;
using Project.Model;
using Project.Repository;

namespace Project
{
    class Program
    {
        /*
        This class is a client that could benefit from the simpler api provided
        by each of the facades. It deals with multiple smaller classes with less
        functionallity and simpler and consistent contracts...

        +----------------+-----------------+-----------------+
        | FooRepository  | BarRepository   | BazRepository   |
        +----------------+-----------------+-----------------+
        | - Insert       | - Insert        | - Insert        |
        | - Update       | - Update        | - Update        |
        | - Delete       | - Delete        | - Delete        |
        | - FindById     | - FindById      | - FindById      |
        | - FindByName   | - FindByName    | - FindByName    |
        +----------------+-----------------+-----------------+

        ...rather than a single bigger class with more functionallity.

        +----------------------------------------------------+
        | Repository                                         |
        +----------------------------------------------------+
        | - InsertFoo      - InsertBar       - InsertBaz     |
        | - UpdateFoo      - UpdateBar       - UpdateBaz     |
        | - DeleteFoo      - DeleteBar       - DeleteBaz     |
        | - FindByIdFoo    - FindByIdBar     - FindByIdBaz   |
        | - FindByNameFoo  - FindByNameBar   - FindByNameBaz |
        +----------------------------------------------------+
        */
        static void Main(string[] args)
        {
            var fooRepository = new FooRepository();

            var insertedFoo = fooRepository.Insert(
                new Foo()
                {
                    Name = "foo1"
                });

            var foundInsertedFoo = fooRepository.FindById(insertedFoo.Id);

            var updatedFoo = fooRepository.Update(
                new Foo()
                {
                    Id = insertedFoo.Id,
                    Name = "foo2"
                });

            var foundUpdatedFoo = fooRepository.FindByName(updatedFoo.Name);

            var deletedFoo = fooRepository.Delete(updatedFoo);
        }
    }
}
