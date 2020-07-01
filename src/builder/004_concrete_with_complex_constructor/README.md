# The Computer Factory With Complex Constructors and Chained Builders

**The Computer Factory With Complex Constructors and Chained Builders** is a ridiculously long named example that makes
use of the **builder design pattern** to demonstrate how to create a fluent api that chains builders for each part of
the product for semantic improvements while creating products with multiple complex parameters in its constructor. In
this example, the constructor complexity doesn't reside in the number of parameters, but on the lack of semantics that
would otherwise be somewhat acomplished by naming the parameters at each constructor or by creating independent
variables with appropriate semantics.

```csharp
var computer = new Computer(
    processor: new Processor(
      name: "07",
      clock: 2.7m,
      cache: 4m),
    memory: new List<Memory>()
    {
      new Memory(
        capacity: 8,
        unit: MemoryUnit.GB,
        type: MemoryType.PCR4),
      new Memory(
        capacity: 8,
        unit: MemoryUnit.GB,
        type: MemoryType.PCR4)
    },
    storage: new List<Storage>()
    {
      new Storage(
        capacity: 256,
        unit: StorageUnit.GB,
        type: StorageType.SolidDrive),
      new Storage(
        capacity: 1,
        unit: StorageUnit.TB,
        type: StorageType.HardDrive)
    },
)
```
