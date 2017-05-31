[//]: # (GENERATED FILE -- DO NOT EDIT)
# Methods: Extract multiple values

In the previous lesson we learned about `Take()` and `Skip()`, both of which accept an integer parameter. They also each have a variant that utilizes a delegate method to determine which values will be taken or skipped.

### TakeWhile(&lt;criteria&gt;) method
`TakeWhile()` behaves similarly to the `Take()` method except that, instead of taking the first `n` values of a sequence, it "takes" all of the initial values of a sequence that meet a specified **criteria**, and stops on the first value that doesn't meet the criteria. It then returns a new sequence containing all the "taken" values.

The criteria is passed into `TakeWhile()` as a delegate method that takes a single parameter of type `T` (where `T` is the type of values in the `IEnumerable<T>` sequence) and returns a `bool` indicating whether or not the passed-in value should be "taken".

```csharp
List<int> ints = new List<int> { 1, 2, 4, 8, 4, 2, 1 };
// Will contain { 1, 2, 4 }
IEnumerable<int> result = ints.TakeWhile(theInt => theInt < 5);
```

### SkipWhile(&lt;criteria&gt;) method
Just as `Skip()` is the spiritual opposite of `Take()`, `SkipWhile()` is the opposite of `TakeWhile()`. `SkipWhile()` "skips" the initial values of a sequence that meet a specified **criteria**, and returns a new sequence containing all the values after, and including, the first value that doesn't meet the criteria.

Again, the criteria is provided as a delegate method that takes a single value of type `T` and returns a `bool` indicating whether or not the passed-in value should be "skipped".

```csharp
List<int> ints = new List<int> { 1, 2, 4, 8, 4, 2, 1 };
// Will contain { 4, 8, 4, 2, 1 }
IEnumerable<int> result = ints.SkipWhile(theInt => theInt != 4);
```

@[TakeWhile and SkipWhile Exercise]({"stubs": ["MultipleValue1/SkipTakeWhile1.cs"], "command": "MultipleValue1.UnitTest.Exercise2", "project": "exercises"})