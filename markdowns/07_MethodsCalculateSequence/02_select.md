[//]: # (GENERATED FILE -- DO NOT EDIT)
# Methods: Calculate a new sequence

### Select(&lt;selector&gt;) method
The `Select()` method invokes the provided **selector** delegate with each element of the source `IEnumerable<T>` sequence, and returns a new result `IEnumerable<U>` sequence containing the result of each invocation.

> **NOTE:** Here we see LINQ showing its SQL roots again. The `Select()` method is named based on SQL syntax, but acts like the `map()` function in Java, JavaScript, Python, etc.

The **selector** method should take a single parameter of type `T`, and should return a result of type `U`. The result sequence will have the same number of elements as the source sequence, and each element will be of type `U`.

```csharp
IEnumerable<string> strings = new List<string> { "one", "two", "three", "four" };
// Will return { 3, 3, 5, 4 }
IEnumerable<int> result = strings.Select(str => str.Length);

IEnumerable<Point> points = new List<Point>
{
    new Point(0, 0),
    new Point(1, 1),
    new Point(2, 0)
};
// Will return { "(0, 0)", "(1, 1)", "(2, 0)" }
IEnumerable<string> result = points.Select(pt => $"({pt.X}, {pt.Y})");
```

In this exercise, try to return a sequence of strings that consist of the provided names in the form of `"<Last>, <First>"`.

@[Select Exercise]({"stubs": ["CalculatedSequence1/Select1.cs"], "command": "CalculatedSequence1.UnitTest.Exercise1", "project": "exercises"})
