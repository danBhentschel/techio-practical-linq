[//]: # (GENERATED FILE -- DO NOT EDIT)
# Exercise: Delegates

In the previous lessons, we learned how to declare delegate types, and how to pass method references as function parameters using delegates.

In this exercise, you must pass either a method delegate or a lambda expression to the `TestSayHello()` method in order to produce the desired results. This delegate takes a single `string` argument and returns a `string` result.

For reference, here are some examples of passing a lambda expression to a method:

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
