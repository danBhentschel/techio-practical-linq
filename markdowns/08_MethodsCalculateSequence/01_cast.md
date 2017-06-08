[//]: # (GENERATED FILE -- DO NOT EDIT)
# Methods: Calculate a new sequence

These LINQ methods can be used to create a new `IEnumerable<T>` result sequence based on the values in the source sequence.

> **NOTE:** Same comment as before. If I state that a method "returns a sequence," this is not technically true. The methods in this chapter return an `IEnumerable<T>`, which is a generator (or an iterator) that can provide a sequence on demand.

### [Cast&lt;U&gt;()](https://msdn.microsoft.com/en-us/library/bb341406%28v=vs.110%29.aspx) method
The `Cast<U>()` method casts each element of a source `IEnumerable<T>` sequence, individually, to a base or derived type `U` and returns a sequence containing all of the resultant elements.

> **NOTE:** If the source type `T` can't be cast to the result type `U` then the cast will fail with an `InvalidCastException`.

```csharp
IEnumerable<IComparable> values = new List<IComparable> { 2, 3, 4 };
// Will return { 2, 3, 4 }
// The elements in the collection are the same,
// but the collection type is different
IEnumerable<int> result = values.Cast<int>();
```

```csharp
IEnumerable<string> strings = new List<string> { "one", "two", "three" };
// Will throw InvalidCastException
IEnumerable<int> result = strings.Cast<int>();
Console.WriteLine(result.First());
```

> **NOTE:** Casting to a more-derived type is always a dubious activity, and typically indicates a failure in polymorphic design. `Cast<U>` should more likely be used to cast to a less-derived, base type.
