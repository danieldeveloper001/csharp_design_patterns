# Composite

**Composite** is a **structural design pattern** whose goal is to create hierarchical structures in a way that allows
clients to consume its elements uniformly, making no distinction between **composites** (nodes that contain children)
or **leafs** (nodes that contains no children). In order to achieve this goal, a base **component** is used as the
contract for both node kinds, so that the **client** is unaware if it is consuming a **root** node, a **composite** node
or a **leaf** node.

## Components and Roles

- **Component**
  - Creates the contract for composite nodes and leaf nodes, containing operations that make sense for both node kinds
- **Composite**
  - Implements the contract from the component
  - Implements one or more operations for manipulating children
  - Represents a component that contains children
  - Holds reference to children nodes that can be either composite or leaf nodes
- **Leaf**
  - Implements the contract from the component
  - Represents a component that contains no children

- **Client**
  deals with the composite at any level of the hierachy in the same manner

## Benefits

- Makes hierarchical structures representation and consumption easier and uniform

## Drawbacks

- Makes hierarchical structures constraint enforcement harder
  - Compile time checks allows for both composite and leaf nodes being added or removed in any point of the hierarchy
  - Execution time checks must be implemented if the hierarchical structure has any rule or restriction

## Examples

- [Abstract][1]
- [Concrete][2]

[1]: ./001_abstract/
[2]: ./002_concrete/
