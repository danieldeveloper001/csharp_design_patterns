## The Thread Safe Singleton Example

**The Thread Safe Singleton Example** makes use of the **singleton design pattern** in order to demonstrate how to
manage the creation of a single instance of an object by using the doubly checked thread safe approach, which creates
the object at the moment the first request to the object is performed, performs a lock in order to prevent concurrent
access to the singleton instance and finally doubly checks the singleton instance in order to prevent bottlenecking
clients when the instance has already been previously created. This approach prevents a performance impact on the
application startup if many singletons are used and multiple calls for the singleton constructor in a multithreaded
application.