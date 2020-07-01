# The Abstract Example With Complex Constructor

**The Abstract Example With Complex Constructor** makes use of the **builder design pattern** to demonstrate a possible
approach to implement step by step creation of existing complex products with properties with no public setters. In this
example, rather than segregating the construction logic from the representation, the product builder stores data from
each invoked step, so that on the build method the constructor parameters can be fullfilled.