[//]: # (GENERATED FILE -- DO NOT EDIT)
# Methods: Calculating a single value

### Min() and Max() methods
Very simply, the `Min()` method returns the minimum value from the source sequence and the `Max()` method returns the maximum value.

```csharp
IEnumerable<int> ints = new List<int> { 2, 2, 4, 6, 3, 6, 5 };
// Will return 6
int result = ints.Max();
```

### Min(&lt;selector&gt;) and Max(&lt;selector&gt;) methods
Similar to the `Sum()` method, `Min()` and `Max()` can also be called with a **selector** delegate parameter. The provided delegate should take a parameter of type `T` and return a numerical value. The result of the `Min()` or `Max()` method call will be the minimum or maximum of all of these numerical values, as calculated for each element in the sequence. The type of the value returned from `Min()` or `Max()` matches the data type of the of the value returned from the **selector**.

```csharp
IEnumerable<string> strings = new List<string> { "1.2", "1.3", "1.5", "0.6" };
// Will return 0.6
float result = strings.Min(str => float.Parse(str));
```

### Min() / Max() exercise
In the following exercise, write a method that will return the length of the shortest string in the provided sequence as an integer value.

@[Min / Max Exercise]({"stubs": ["SingleCalculatedValue1/MinMax1.cs"], "command": "SingleCalculatedValue1.UnitTest.Exercise2", "project": "exercises"})