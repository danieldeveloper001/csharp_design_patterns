# Facade

The **facade** design pattern is a refactoring pattern whose goal is to provide
means for creating easier to consume contracts. In order to achieve such goal,
it provides a concise and cohese set of operations that can consume
functionality either from large classes (in which case a subset of these
operations will be consumed) or from multiple small classes (in which case these
operations will be aggregated into a single operation that by itself has a
meaning).

## Examples

- [Simplifying Contracts][1]

[1]: ./001_simplifying_contracts/