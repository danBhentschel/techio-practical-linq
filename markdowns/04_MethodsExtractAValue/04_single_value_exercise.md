[//]: # (GENERATED FILE -- DO NOT EDIT)
# Exercise - Extract a single element

Using what you have learned about `First()`, `Last()`, `ElementAt()`, and `Single()` (and their variations) modify the methods in this exercise to extract the desired element from the provided sequence of strings.

For reference, here are some examples of LINQ methods that return a single element from the sequence:

```csharp
List<double> doubles = new List<double> { 2.0, 2.1, 2.2, 2.3 };
double whatsThis = doubles.First();

List<double> doubles = new List<double> { 2.0, 2.1, 2.2, 2.3 };
double whatsThis = doubles.Last(val => val < 2.1);


List<double> doubles = new List<double> { 2.0, 2.1, 2.2, 2.3 };
double whatsThis = doubles.ElementAtOrDefault(4);
```

@[Extract a Single Value Exercise]({"stubs": ["SingleValue1/SingleValue1.cs"], "command": "SingleValue1.UnitTest.Exercise1", "project": "exercises"})
