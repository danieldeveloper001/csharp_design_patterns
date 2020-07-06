# Strategy

**Strategy** is a **behavioural design pattern** whose goal is to allow dynamically changing the behaviour of a context
class and to reduce the amount of conditional statements required to do so, by making the context independent from one
or more behaviours it could assume. In order to achieve such goal, the possible behaviours of the context class are
segregated into independent classes, each of them representing one behaviour and then, the context class is parametrized
with one of those classes, to which actions issued on the context are delegated.

## Components and Roles

- **Strategy (abstract)**
  - Creates the contract for concrete strategies
- **Strategy (concrete)**
  - Implements the contract from the abstract strategy
  - Contains the behaviour that will be consumed by the context
- **Context**
  - Holds a reference to a strategy
  - Delegates its actions behaviour to the strategy in order to switch behaviour

## Benefits

- Allows dynamically changing behaviour of a context class
- Segregates behaviours into indepentent classes
- Decouples context from one or more behaviours it can assume on given conditions
- Reduces usage of conditional statements for switching behaviour
- Strategies can be added or removed without breaking the context, since it depends on the strategy abstraction

## Drawbacks

- Client must know the existing strategies in order to switch the context behaviour

## Examples

- [Abstract][1]
- [Concrete][2]

[1]: ./001_abstract/
[2]: ./002_concrete/
