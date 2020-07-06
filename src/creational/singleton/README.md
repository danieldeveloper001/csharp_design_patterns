# Singleton

**Singleton** is a **creational design pattern** whose goal is to allow a single instance of a given type being created
during the application lifecycle. In order to achieve this goal, the **singleton** manages its own creation by defining
a private parameterless constructor which prevent **clients** from instantiating it and defines a method for obtaining
the singleton instance.

## Components and Roles

- **Sigleton**
  - Defines a private parameterless constructor
  - Defines a method for creating the instance
    - Can be eagerly loaded
    - Can be lazily loaded
    - Can be thread safe

## Benefits

- Manages the creation of an object that must be created only once during the application lifecycle

## Drawbacks

- Hard to unit test, since it is static and has no interface

## Examples

- [Eagerly Loaded][1]
- [Lazily Loaded][2]
- [Thread Safe][3]

[1]: ./001_eagerly_loaded/
[2]: ./002_lazily_loaded/
[3]: ./003_thread_safe/

