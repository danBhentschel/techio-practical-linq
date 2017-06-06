# Methods: Extract multiple elements

`Take()` and `Skip()` return consecutive elements at the beginning and end of a sequence, but there are also ways to extract specific elements scattered throughout a given sequence.

### Distinct() method
The `Distinct()` method works the same way as the `DISTINCT` directive in SQL. It returns a new sequence containing all the elements from the target sequence that are distinct from each other, as determined by the default equality comparer for the data type of the sequence.

For example:

```csharp
//// EMBED: LinqCourseEmbeddedCode/Methods2.cs, Distinct()
```

### Intersect() method
`Intersect()` returns a new sequence containing all the elements that are common to both the target sequence and a second sequence provided as a parameter to the method. Both sequences must provide the same data type, and commonality is determined by the default equality comparer for that data type.

```csharp
//// EMBED: LinqCourseEmbeddedCode/Methods2.cs, Intersect()
```

### Where(&lt;predicate&gt;) method
`Where()` returns a new sequence containing all the elements from the target sequence that meet a specified criteria.

> **NOTE:** LINQ is showing its SQL roots here. The `Where()` method is named based on SQL syntax, but acts like the `filter()` function in Java, JavaScript, Python, etc.

The criteria is passed into `Where()` as a **predicate** delegate method that takes a single parameter of type `T` (where `T` is the datatype of the elements in the `IEnumerable<T>` sequence) and returns a `bool` indicating whether or not the passed-in element should be included in the returned sequence.

```csharp
//// EMBED: LinqCourseEmbeddedCode/Methods2.cs, Where()
```

@[Distinct, Intersect, and Where Exercise]({"stubs": ["MultipleValue1/DistinctIntersectWhere1.cs"], "command": "MultipleValue1.UnitTest.Exercise3", "project": "exercises"})
