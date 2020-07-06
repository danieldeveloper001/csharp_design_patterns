# Builder

**Builder** is a **creational design pattern** whose goal is to allow a complex object creation using a step by step
approach, segregating its creation logic from its representation in one or more builders that can generate variations of
the same object.

## Components and Roles

- **Director (concrete)**
  - Consumes the builder interface in order to create an object
  - Exposes one or more reusable methods that encapsulate a product creation logic
    - Invokes steps from the builder interface.
    - Defines sequence for steps invokation.
- **Builder (abstract)**
  - Creates the contract for concrete builders
  - Contains one or more abstract methods representing the steps involved in the product creation.
- **Builder (concrete)**
  - Implements the contract from the abstract builder
  - Contains one or more concrete methods implementing the steps involved in the product creation.
  - Tracks the progress of the object parts creation
  - Contains a method implementing the creation of the product
- **Product**
  - Complex object targeted by the building process
- **Client**
  - Consumes the builders (optionally using the director) in order to create a product.

*The director component is optional, but it is recommended for code reusability when the application recurrently invokes
the builder interface executing the same steps for creating the product.

## Benefits

- Allows different representations of the same product being created
- Segregates product creation from product representation
  - Creation logic and steps may be made reusable by implementing a director
  - Creation logic and steps may be made fluent by returning the builder in each step
- Improves product creation semantics

## Drawbacks

:construction: This section is under construction

## Examples

- [Abstract (with reusable creation logic on director)][1]
- [Concrete (with reusable creation logic on director)][2]
- [Abstract (with fluent api)][3]
- [Concrete (with fluent api)][4]

[1]: ./001_abstract_with_director/
[2]: ./002_concrete_with_director/
[3]: ./003_abstract_with_fluent_api/
[4]: ./004_concrete_with_fluent_api/