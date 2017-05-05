# Methods: Calculating a single value

### Aggregate(&lt;func&gt;) method
The `Aggregate()` method applies a function to all the elements of the source sequence and calculates a cumulative result that takes into account the return value of each function call.

This is a somewhat complicated concept, and is best shown with some examples.

```csharp
//// EMBED: LinqCourseEmbeddedCode/Methods4.cs, Aggregate() -> Sum()


//// EMBED: LinqCourseEmbeddedCode/Methods4.cs, Aggregate() -> concat
```

### Aggregate(&lt;seed&gt;, &lt;func&gt;) method
Another form of `Aggregate()` takes a **seed** that specifies the initial value supplied to the **func**. In addition, this form of `Aggregate()` can return a value that is a different type than the elements in the source sequence.

```csharp
//// EMBED: LinqCourseEmbeddedCode/Methods4.cs, Aggregate() -> Count()


//// EMBED: LinqCourseEmbeddedCode/Methods4.cs, Aggregate() -> Any()
```

### Aggregate() exercise
Think you can handle it? Try to use `Aggregate()` to write a method that will return the total number of characters in all the words in the source sequence.

@[Aggregate Exercise]({"stubs": ["SingleCalculatedValue1/Aggregate1.cs"], "command": "SingleCalculatedValue1.UnitTest.Exercise3", "project": "exercises"})
