[//]: # (GENERATED FILE -- DO NOT EDIT)
# [Select(&lt;selector&gt;)](https://msdn.microsoft.com/en-us/library/bb548891%28v=vs.110%29.aspx) method
The `Select()` method invokes the provided **selector** delegate on each element of the source `IEnumerable<T>` sequence, and returns a new result `IEnumerable<U>` sequence containing the output of each invocation.

Wow! That's a mouthful! Let's try it this way. `Select()` takes each source element, transforms it, and returns a sequence of the transformed values. Better?

> **NOTE:** Here we see LINQ showing its SQL roots again. The `Select()` method is named based on SQL syntax, but acts like the `map()` function in Java, JavaScript, Python, etc.

The **selector** method should take a single parameter of type `T`, and should return a value of type `U`. The result sequence will have the same number of elements as the source sequence, and each element will be of type `U`.

```csharp
IEnumerable<string> strings = new List<string> { "one", "two", "three", "four" };
// Will return { 3, 3, 5, 4 }
IEnumerable<int> result = strings.Select(str => str.Length);
```

```csharp
IEnumerable<Point> points = new List<Point>
{
    new Point(0, 0),
    new Point(1, 1),
    new Point(2, 0)
};
// Will return { "(0, 0)", "(1, 1)", "(2, 0)" }
IEnumerable<string> result = points.Select(pt => $"({pt.X}, {pt.Y})");
```

In this exercise, try to return a sequence of strings that consist of the provided names in the form: `"<Last>, <First>"`.

@[Select Exercise]({"stubs": ["CalculatedSequence1/Select1.cs"], "command": "CalculatedSequence1.UnitTest.Exercise1", "project": "exercises"})
