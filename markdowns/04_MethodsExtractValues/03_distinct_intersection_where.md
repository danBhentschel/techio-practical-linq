[//]: # (GENERATED FILE -- DO NOT EDIT)
# Methods: Extract multiple values

`Take()` and `Skip()` return consecutive values at the beginning and end of a sequence, but there are also ways to extract specific values scattered throughout a given sequence.

### Distinct() method
The `Distinct()` method works the same way as the `DISTINCT` directive in SQL. It returns a new sequence containing all the values from the target sequence that are distinct from each other, as determined by the default equality comparer for the data type of the sequence.

For example:

```csharp
List<int> ints = new List<int> { 1, 2, 4, 8, 4, 2, 1 };
// Will contain { 1, 2, 4, 8 }
IEnumerable<int> result = ints.Distinct();
```

### Intersect() method
`Intersect()` returns a new sequence containing all the values that are common to both the target sequence and a second sequence provided as a parameter to the method. Both sequences must provide the same data type, and commonality is determined by the default equality comparer for that data type.

```csharp
List<int> ints = new List<int> { 1, 2, 4, 8, 4, 2, 1 };
List<int> filter = new List<int> { 1, 1, 2, 3, 5, 8 };
// Will contain { 1, 2, 8 }
IEnumerable<int> result = ints.Intersect(filter);
```

### Where() method
`Where()` returns a new sequence containing all the values from the target sequence that meet a specified criteria.

The criteria is passed into `Where()` as a delegate method that takes a single parameter of type `T` (where `T` is the type of values in the `IEnumerable<T>` sequence) and returns a `bool` indicating whether or not the passed-in value should be included in the returned sequence.

```csharp
List<int> ints = new List<int> { 1, 2, 4, 8, 4, 2, 1 };
// Will contain { 2, 4, 4, 2 }
IEnumerable<int> result = ints.Where(theInt => theInt == 2 || theInt == 4);
```

@[Distinct, Intersect, and Where Exercise]({"stubs": ["MultipleValue1/DistinctIntersectWhere1.cs"], "command": "MultipleValue1.UnitTest.Exercise3", "project": "exercises"})