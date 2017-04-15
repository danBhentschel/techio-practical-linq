# Methods: Extract multiple values

These LINQ methods can be used to extract multiple values from an `IEnumerable<T>` sequence. Each method in this chapter provides a different means of defining the criteria determining which sequence values to remove and which values to keep.

> **NOTE:** Throughout this chapter I state that a method "returns a sequence". This is not technically true. The methods in this chapter return an `IEnumerable<T>` which is a generator method (or an iterator) that can provide a sequence on demand. The difference is subtle, and can often be ignored, but there are some situations where the distinction is important. This will be discussed in more detail in the Advanced Topics section at the end of the course.

### Take() method
We have already seen this method in action in the Background lessons on Generators. The `Take()` method extracts the first `n` values (where `n` is a parameter to the method) from the beginning of the target sequence, and returns a new sequence containing only the values taken. 

```csharp
//// EMBED: LinqCourseEmbeddedCode/Methods2.cs, Take()
```

### Skip() method
The `Skip()` method can be thought of as the exact opposite of the `Take()` method. Where `Take()` returns a sequence containing the first `n` values of the target sequence, `Skip()` "skips" over the first `n` values in the sequence and returns a new sequence containing the remaining values after the first `n` values.

```csharp
//// EMBED: LinqCourseEmbeddedCode/Methods2.cs, Skip()
```

@[Take and Skip Exercise]({"stubs": ["MultipleValue1/SkipTake1.cs"], "command": "MuptipleValue1.UnitTest.Exercise1", "project": "exercises"})
