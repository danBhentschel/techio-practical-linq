# Methods: Calculating a single value

### Aggregate(&lt;func&gt;) method
The `Aggregate()` method applies a function to all the elements of the source sequence and calculates a cumulative result that takes into account the return value of each function call.

This is a somewhat complicated concept, and is best shown with some examples.

```csharp
//// EMBED: LinqCourseEmbeddedCode/Methods4.cs, Aggregate() -> Sum()


//// EMBED: LinqCourseEmbeddedCode/Methods4.cs, Aggregate() -> concat
```

> **NOTE:** The return value of the `Aggregate()` call (and the provided **func**) must be the same data type as that of the elements in the source sequence.

### Aggregate(&lt;seed&gt;, &lt;func&gt;) method
Another form of `Aggregate()` takes a **seed**, which specifies the initial value supplied to the **func**. In addition, this form of `Aggregate()` can return a value of a different data type than that of the elements in the source sequence. In this case, the data type of the value returned from **func** must match the data type of **seed**.

```csharp
//// EMBED: LinqCourseEmbeddedCode/Methods4.cs, Aggregate() -> Count()


//// EMBED: LinqCourseEmbeddedCode/Methods4.cs, Aggregate() -> Any()
```

### Aggregate() exercise
Think you can handle it? Try to use `Aggregate()` to write a method that will return the total number of characters in all the words in the source sequence.

@[Aggregate Exercise]({"stubs": ["SingleCalculatedValue1/Aggregate1.cs"], "command": "SingleCalculatedValue1.UnitTest.Exercise3", "project": "exercises"})
