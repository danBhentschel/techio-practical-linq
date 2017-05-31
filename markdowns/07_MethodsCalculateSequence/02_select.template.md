# Methods: Calculate a new sequence

### Select(&lt;selector&gt;) method
The `Select()` method invokes the provided **selector** delegate with each element of the source `IEnumerable<T>` sequence, and returns a new result `IEnumerable<U>` sequence containing the result of each invocation.

> **NOTE:** Here we see LINQ showing its SQL roots again. The `Select()` method is named based on SQL syntax, but acts like the `map()` function in Java, JavaScript, Python, etc.

The **selector** method should take a single parameter of type `T`, and should return a result of type `U`. The result sequence will have the same number of elements as the source sequence, and each element will be of type `U`.

```csharp
//// EMBED: LinqCourseEmbeddedCode/Methods5.cs, Select() 1

//// EMBED: LinqCourseEmbeddedCode/Methods5.cs, Select() 2
```

In this exercise, try to return a sequence of strings that consist of the provided names in the form of `"<Last>, <First>"`.

@[Select Exercise]({"stubs": ["CalculatedSequence1/Select1.cs"], "command": "CalculatedSequence1.UnitTest.Exercise1", "project": "exercises"})
