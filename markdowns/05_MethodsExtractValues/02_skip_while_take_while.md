[//]: # (GENERATED FILE -- DO NOT EDIT)
# Methods: Extract multiple elements

In the previous lesson we learned about `Take()` and `Skip()`, both of which accept an integer parameter. They also each have a variant that utilizes a delegate method to determine which elements will be taken or skipped.

### [TakeWhile(&lt;predicate&gt;)](https://msdn.microsoft.com/en-us/library/bb534804%28v=vs.110%29.aspx) method
`TakeWhile()` behaves similarly to the `Take()` method except that, instead of taking the first `n` elements of a sequence, it "takes" all of the initial elements of a sequence that meet the criteria specified by **predicate**, and stops on the first element that doesn't meet the criteria. It then returns a new sequence containing all the "taken" elements.

The **predicate** is passed into `TakeWhile()` as a delegate method that takes a single parameter of type `T` (where `T` is the data type of the elements in the `IEnumerable<T>` sequence) and returns a `bool` indicating whether or not the passed-in element should be "taken".

```csharp
List<int> ints = new List<int> { 1, 2, 4, 8, 4, 2, 1 };
// Will contain { 1, 2, 4 }
IEnumerable<int> result = ints.TakeWhile(theInt => theInt < 5);
```

### [SkipWhile(&lt;predicate&gt;)](https://msdn.microsoft.com/en-us/library/bb549075%28v=vs.110%29.aspx) method
Just as `Skip()` is the spiritual opposite of `Take()`, `SkipWhile()` is the opposite of `TakeWhile()`. `SkipWhile()` "skips" the initial elements of a sequence that meet the criteria specified by **predicate**, and returns a new sequence containing all the elements after, and including, the first element that doesn't meet the criteria.

Again, the **predicate** is provided as a delegate method that takes a single element of type `T` and returns a `bool` indicating whether or not the passed-in element should be "skipped".

```csharp
List<int> ints = new List<int> { 1, 2, 4, 8, 4, 2, 1 };
// Will contain { 4, 8, 4, 2, 1 }
IEnumerable<int> result = ints.SkipWhile(theInt => theInt != 4);
```

@[TakeWhile and SkipWhile Exercise]({"stubs": ["MultipleValue1/SkipTakeWhile1.cs"], "command": "MultipleValue1.UnitTest.Exercise2", "project": "exercises"})
