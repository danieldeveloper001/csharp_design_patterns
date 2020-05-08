# Simplifying Contracts with Facade

In this example, the facade pattern is used to refactor a contract with a large
number of unrelated functionality into a more concise and cohese contract. For
the sake of keeping things simple, bear in mind that...

- Data is stored in lists rather than a real database;
- Client functionality is implemented as three static methods that invokes
  methods from the facades;

## Repository

This class represents a poorly implemented contract with a large number of
unrelated functionality, acting as the target for the facade classes detailed in
the following sections. It provides the functionality necessary for handling
`Foo`, `Bar` and `Baz` model classes, as enumerated below.

- Insert
  - InsertFoo
  - InsertBar
  - InsertBaz
- Update
  - UpdateFoo
  - UpdateBar
  - UpdateBaz
- Delete
  - DeleteFoo
  - DeleteBar
  - DeleteBaz
- FindById
  - FindbyIdFoo
  - FindbyIdBar
  - FindbyIdBaz
- FindByName
  - FindbyNameFoo
  - FindbyNameBar
  - FindbyNameBaz

## FooRepository

This class is a facade for the larger `Repository` class that provides the
functionality necessary exclusively for handling `Foo` model class, as
enumerated below.

- Insert
- Update
- Delete
- FindById
- FindByName

## BarRepository

This class is a facade for the larger `Repository` class that provides the
functionality necessary exclusively for handling `Bar` model class, as
enumerated below.

- Insert
- Update
- Delete
- FindById
- FindByName

## BazRepository

This class is a facade for the larger `Repository` class that provides the
functionality necessary exclusively for handling `Baz` model class, as
enumerated below.

- Insert
- Update
- Delete
- FindById
- FindByName
