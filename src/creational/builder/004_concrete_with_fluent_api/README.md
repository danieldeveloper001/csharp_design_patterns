# The Computer Factory With Fluent Api and Chained Builders

**The Computer Factory With Fluent Api and Chained Builders** is a ridiculously long named example that makes
use of the **builder design pattern** to demonstrate how to create a fluent api that chains builders for each part of
the product creation process for semantic improvements while creating products with multiple complex parameters in its
constructor. In this example, the complexity doesn't reside in the number of parameters on the product and product parts
constructors, but on the lack of semantics that would otherwise be somewhat acomplished by naming the parameters at each
constructor or by creating independent variables with appropriate semantics, so that instead of something like ...

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
    });
```

... something like this can be done ...

```csharp
var computer = new ComputerBuilder()
  .BuildProcessor()
      .WithName("O7")
      .WithClock(2.7m)
      .WithCache(4m)
      .Add()
  .BuildMemory()
      .WithCapacity(8, MemoryUnit.GB)
      .WithType(MemoryType.PCR4)
      .Add()
  .BuildMemory()
      .WithCapacity(8, MemoryUnit.GB)
      .WithType(MemoryType.PCR4)
      .Add()
  .BuildStorage()
      .WithCapacity(256, StorageUnit.GB)
      .WithType(StorageType.SolidDrive)
      .Add()
  .BuildStorage()
      .WithCapacity(1, StorageUnit.TB)
      .WithType(StorageType.HardDrive)
      .Add()
  .Build();
```
