# Methods: Extract multiple elements

These LINQ methods can be used to extract multiple elements from an `IEnumerable<T>` sequence. Each method in this chapter provides a different means of defining the criteria determining which sequence elements to remove and which elements to keep.

> **NOTE:** Throughout this chapter, I state that a method "returns a sequence". This is not technically true. The methods in this chapter return an `IEnumerable<T>`, which is a generator (or an iterator) that can provide a sequence on demand. The difference is subtle, and can often be ignored, but there are some situations where the distinction is important. These special cases will be discussed in more detail in the **Advanced Topics** course.

# [Take()](https://msdn.microsoft.com/en-us/library/bb503062%28v=vs.110%29.aspx) method
The `Take()` method extracts the first `n` elements (where `n` is a parameter to the method) from the beginning of the target sequence and returns a new sequence containing only the elements taken. 

```csharp
//// EMBED: LinqCourseEmbeddedCode/Methods2.cs, Take()
```

# [Skip()](https://msdn.microsoft.com/en-us/library/bb358985%28v=vs.110%29.aspx) method
The `Skip()` method can be thought of as the exact opposite of the `Take()` method. Where the `Take()` method, returns a sequence containing the first `n` elements of the target sequence, the `Skip()` method "skips" over the first `n` elements in the sequence and returns a new sequence containing the remaining elements after the first `n` elements.

```csharp
//// EMBED: LinqCourseEmbeddedCode/Methods2.cs, Skip()
```

# Exercise
In this exercise, make the `GetThirdFourthFifthItems()` method return the 3rd, 4th, and 5th elements of the provided sequence.

@[Take and Skip Exercise]({"stubs": ["MultipleValue1/SkipTake1.cs"], "command": "MultipleValue1.UnitTest.Exercise1", "project": "exercises"})
