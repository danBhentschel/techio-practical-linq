# Methods: Calculate a new sequence

These LINQ methods can be used to create a new result sequence based on the values in a source `IEnumerable<T>` sequence.

> **NOTE:** Same comment as before. If I state that a method "returns a sequence," this is not technically true. The methods in this chapter return an `IEnumerable<T>`, which is a generator method (or an iterator) that can provide a sequence on demand.

### Cast&lt;U&gt;() method
The `Cast<U>()` method casts each element of a source `IEnumerable<T>` sequence, individually, to a base or derived type `U` and returns a sequence containing all of the resultant elements.

> **NOTE:** If the source type `T` can't be cast to the result type `U` (because there is no type common to both `T` and `U`) then the cast will fail with an `InvalidCastException`.

```csharp
//// EMBED: LinqCourseEmbeddedCode/Methods5.cs, Cast() good
```

```csharp
//// EMBED: LinqCourseEmbeddedCode/Methods5.cs, Cast() bad
```

> **NOTE:** Casting to a more-derived type is always a dubious activity, and typically indicates a failure in polymorphic design. `Cast<U>` should more likely be used to cast to a less-derived, base type.