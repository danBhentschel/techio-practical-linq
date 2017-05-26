# Methods: Calculating a single value

The LINQ methods in this chapter examine the elements of an `IEnumerable<T>` sequence and return a result based on the examined values. For most of the methods we will examine, this result will be either a `bool` or an `int`.

### Count() method
We have already seen the `Count()` method in use. In its simplest form (without any parameters) it returns an `int` indicating the number of elements in the source sequence.

```csharp
//// EMBED: LinqCourseEmbeddedCode/Methods4.cs, Count()
```

> **NOTE:** The `Count()` LINQ method (an extension method to `IEnumerable<T>`) is slightly different from the `Count` method on `List<T>`. This unfortunate situation can cause some confusion. More on this in the Advanced Topics section.

> **NOTE 2:** There is also a `LongCount()` method that returns a `long`, for use with sequences that have more values.

### Count(&lt;condition&gt;) method
There is another form of the `Count()` method that takes a **condition** delegate parameter. The provided delegate should take a parameter of type `T` and return a `bool` indicating whether or not the provided parameter meets the criteria.

This form of `Count()` will return an `int` indicating the number of elements in the source sequence that meet the provided condition. This is roughly equivalent to calling `<source>.Where(<condition>).Count()`.

```csharp
//// EMBED: LinqCourseEmbeddedCode/Methods4.cs, Count() condition
```

### Count() exercise
In the following exercise, count the number of strings in the provided sequence that begin with the provided string.

@[Count Exercise]({"stubs": ["SingleCalculatedValue1/Count1.cs"], "command": "SingleCalculatedValue1.UnitTest.Exercise1", "project": "exercises"})
