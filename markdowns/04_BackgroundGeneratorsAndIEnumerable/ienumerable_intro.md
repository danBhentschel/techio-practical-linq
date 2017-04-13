[//]: # (GENERATED FILE -- DO NOT EDIT)
# Background: IEnumerable&lt;T&gt;

### Why learn about generators and IEnumerable&lt;T&gt;?
LINQ methods are extension methods to the `IEnumerable<T>` interface. It is important to understand how `IEnumerable<T>` works to fully understand how LINQ works.

### Collections as IEnumerable&lt;T&gt;
A method returning an object that implements the `IEnumerable<T>` interface can be enumerated via a `foreach` block. For example:

```csharp
private IEnumerable<int> GetInts()
{
    return new List<int> { 2, 4, 5, 7 };
}
```

Since `List<T>` implements `IEnumerable<T>`, you can iterate the return value from `GetInts()` like so:

```csharp
// Will print:
// Value: 2
// Value: 4
// Value: 5
// Value: 7
foreach (int val in GetInts())
{
    Console.WriteLine($"Value: {val}");
}
```

Not all that surprising or impressive, is it? Well, let's take a look at generators next. That's where the true value of `IEnumerable<T>` lies.
