## The Lazily Loaded Singleton Example

**The Lazily Loaded Singleton Example** makes use of the **singleton design pattern** in order to demonstrate how to
manage the creation of a single instance of an object by using the lazy loading approach, which creates the object at
the moment the first request to the object is performed. This approach prevents a performance impact on the application
startup if many singletons are used.