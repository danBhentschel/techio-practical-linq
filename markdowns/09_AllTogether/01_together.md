[//]: # (GENERATED FILE -- DO NOT EDIT)
# Combined Exercise #1

As we have already seen in some of the examples, LINQ methods can build on each other. Since many LINQ methods return an `IEnumerable<T>`, subsequent LINQ methods can be called on the results. For example:

```csharp
IEnumerable<string> values = new List<string> { "fe", "fi", "fo", "fum" };
// Will return 12
int result = values
    .Select(word => $"{word}-{word}") // { "fe-fe", "fi-fi", ... }
    .Skip(2)
    .Select(phrase => phrase.Length)
    .Sum();
```

In this exercise, combine LINQ method calls together to determine if the second sequence passed into the `TestForSquares()` method contains the squares of the elements in the first sequence. It should return `true` if the two sequences have the same number of elements and **each** element in `squares` is equal to the square of the corresponding element in `numbers`.

@[Combined Exercise 1]({"stubs": ["AllTogether1/AllTogether1.cs"], "command": "AllTogether1.UnitTest.Exercise1", "project": "exercises"})
