## Creational

### Abstract Factory

[Abstract Factory][factory] focuses on creating families of related objects, decoupling clients from the creation logic.

:heavy_check_mark: Documentation
:heavy_check_mark: Example (abstract)
:heavy_check_mark: Example (concrete)

### Builder

[Builder][builder] facilitates the process of creating complex objects by using a step by step approach that decompose
the creation into smaller steps that can be invoked through a director with one or more creation options for reusability
or directly by clients for flexibility.

:heavy_check_mark: Documentation
:heavy_check_mark: Example (abstract)
:heavy_check_mark: Example (concrete)

### Factory Method

[Factory Method][factory_method] defines a parametrized reusable interface for creating one or more object derived from
the same contract, decoupling clients from the creation logic.

:heavy_check_mark: Documentation
:heavy_check_mark: Example (abstract)
:heavy_check_mark: Example (concrete)

### Prototype

[Prototype][prototype] allows creating unique object instances from existing blueprints with predefined state through
shallow or deep cloning instances that represent variations of the same object, without the need of subclassing.

:heavy_check_mark: Documentation
:heavy_check_mark: Example (abstract)
:heavy_check_mark: Example (concrete)

### Singleton

[Singleton][singleton] prevents an object from being created multiple times during the aplication lifecycle by making it
responsible for creating and providing for clients the single instance.

:heavy_check_mark: Documentation
:heavy_check_mark: Example (abstract)
:heavy_check_mark: Example (concrete)



[abstract_factory]: ./abstract_factory/
[builder]: ./builder/
[factory_method]: ./factory_method/
[prototype]: ./prototype/
[singleton]: ./singleton/