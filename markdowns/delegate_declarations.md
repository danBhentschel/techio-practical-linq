# Background: Delegate Declarations

### Why learn about delegates?
When learning LINQ, it is important to have a good understanding of delegates in C#. Many of the more powerful capabilities of LINQ make use of delegates.

### What is a delegate?
A delegate is simply a reference to a method. Delegates can be stored and passed around in a variable, and hence they must have a type definition:

```C#
public delegate int FuncTwoInts(int, int);
```

The line above defines the type `FuncTwoInts`. The `FuncTwoInts` type is a reference to a method that takes two `int` parameters and returns a single `int` result.

@[Delegates Exercise]({"stubs": ["DelegatesExercise1.cs"], "command": "Delegates1.UnitTest.Exercise1", "project": "delegates1"})
