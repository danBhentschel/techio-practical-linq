# Methods: Calculating a single value

### Min() and Max() methods
Very simply, the `Min()` method returns the minimum value from the source sequence and the `Max()` method returns the maximum value.

```csharp
//// EMBED: LinqCourseEmbeddedCode/Methods4.cs, Max()
```

### Min(&lt;selector&gt;) and Max(&lt;selector&gt;) methods
Similar to the `Sum()` method, `Min()` and `Max()` can also be called with a **selector** delegate parameter. The provided delegate should take a parameter of type `T` and return a numerical value. The result of the `Min()` or `Max()` method call will be the minimum or maximum of all of these numerical values, as calculated for each element in the sequence. The type of the value returned from `Min()` or `Max()` matches the data type of the of the value returned from the **selector**.

```csharp
//// EMBED: LinqCourseEmbeddedCode/Methods4.cs, Min() selector
```

### Min() / Max() exercise
In the following exercise, write a method that will return the length of the shortest string in the provided sequence as an integer value.

@[Min / Max Exercise]({"stubs": ["SingleCalculatedValue1/MinMax1.cs"], "command": "SingleCalculatedValue1.UnitTest.Exercise2", "project": "exercises"})