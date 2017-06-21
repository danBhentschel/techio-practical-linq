# [Select(&lt;selector&gt;)](https://msdn.microsoft.com/en-us/library/bb548891%28v=vs.110%29.aspx) method
The `Select()` method invokes the provided **selector** delegate on each element of the source `IEnumerable<T>` sequence, and returns a new result `IEnumerable<U>` sequence containing the output of each invocation.

Wow! That's a mouthful! Let's try it this way. `Select()` takes each source element, transforms it, and returns a sequence of the transformed values. Better?

> **NOTE:** Here we see LINQ showing its SQL roots again. The `Select()` method is named based on SQL syntax, but acts like the `map()` function in Java, JavaScript, Python, etc.

The **selector** method should take a single parameter of type `T` and should return a value of type `U`. The result sequence will have the same number of elements as the source sequence with one exception; each element will be of type `U`.

```csharp
//// EMBED: LinqCourseEmbeddedCode/Methods5.cs, Select() 1
```

```csharp
//// EMBED: LinqCourseEmbeddedCode/Methods5.cs, Select() 2
```

# Exercise

In this exercise, try to return a sequence of strings that consist of the provided names in the form: `"<Last>, <First>"`.

@[Select Exercise]({"stubs": ["CalculatedSequence1/Select1.cs"], "command": "CalculatedSequence1.UnitTest.Exercise1", "project": "exercises"})
