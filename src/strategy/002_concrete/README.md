## The Sale Report Example

**The Sale Report Example** makes use of the **strategy design pattern** in order to demonstrate how to change display
logic behaviour for a **context** of sale report by using different sorting **strategies** without using conditional
statements, by abstracting them to semantic and independent classes such as **sort by amount**, **sort by price** and
**sort by product**.

```csharp
var reportByAmount = new SaleReport(new SortByAmount());
var reportByPrice = new SaleReport(new SortByPrice());
var reportByProduct = new SaleReport(new SortByProduct());
```

Notice that since this is a simple example, such behaviour in csharp could also be implemented by using expressions but,
even though the sorting conditions were extrated from the report itself, they would reside in the client and it would
also be less semantic.

```csharp
var report = new SaleReport((x) => x.Amount);
var report = new SaleReport((x) => x.Price);
var report = new SaleReport((x) => x.Product);
```