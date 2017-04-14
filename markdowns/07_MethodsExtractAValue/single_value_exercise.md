[//]: # (GENERATED FILE -- DO NOT EDIT)
# Exercise: Extract a single value

Using what you have learned about `First()`, `Last()`, `ElementAt()`, and `Single()` (and their variations) modify the methods in this exercise to extract the desired element from the provided sequence of strings.

For reference, here are some examples of LINQ methods that return a single value from the sequence:

```csharp
private static void Execute()
{
    // Prints 8
    PrintWith_2and4((first, second) => first * second);

    // Prints 6
    PrintWith_2and4((one, two) => one + two);

    // Prints 224
    PrintWith_2and4((a, b) => int.Parse($"{a}{a}{b}"));

    // Prints 9999
    PrintWith_2and4((foo, bar) => 9999);
}
```

@[Delegates Exercise]({"stubs": ["Delegates2/DelegatesExercise2.cs"], "command": "Delegates2.UnitTest.Exercise2", "project": "exercises"})
