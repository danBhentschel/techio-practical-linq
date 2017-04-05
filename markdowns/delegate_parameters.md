# Background: Delegates as Parameters

Still referring to the `FuncTwoInts` type, previously declared as:

```csharp
public delegate int FuncTwoInts(int, int);
```

### Declaring a method with a delegate argument

The `FuncTwoInts` type can be used to declare method parameters, as shown here:

```csharp
public static void PrintWith_2and4(FuncTwoInts func)
{
    int result = func(2, 4);
    Console.WriteLine(result);
}
```

The method `PrintWith_2and4()` takes a delegate as an argument. The passed-in delegate must match the `FuncTwoInts` type, meaning that it must accept two `int` parameters and return an `int`. 

### Passing a delegate to a method

Here are some examples of how the `PrintWith_2and4()` method can be called:

```csharp
public static void Execute()
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

For each of the above calls, `PrintWith_2and4()` executes the provided method reference with 2 and 4 as arguments, and then prints the result.
