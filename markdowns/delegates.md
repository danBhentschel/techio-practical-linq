# Background: Delegates

When learning LINQ, it is important to have a good understanding of delegates in C#. Many of the more powerful capabilities of LINQ make use of delegates.

A delegate is simply a reference to a method. Delegates can be stored and passed around in a variable, and hence they must have a type definition:


```C#
public delegate int FuncTwoInts(int, int);
```

The line above defines the type `FuncTwoInts`, which can be used to declare variables like this:

```C#
private static int Add(int one, int two)
{
	return one + two;
};

private FuncTwoInts theFunc = Add;
```

Or like this:

```C#
FuncTwoInts theFunc = (one, two) => {
    return one + two;
}
```

Or even like this:

```C#
FuncTwoInts theFunc = (one, two) => one + two;
```

The `TwoFuncInts` type can be used to declare method parameters, as shown here:

```C#
public static void PrintWith_2and4(FuncTwoInts func)
{
    Console.WriteLine(func(2, 4));
}
```

The method `PrintWith_2and4()` takes a delegate as an argument. The passed-in delegate must match the `FuncTwoInts` type, meaning that it must accept two `int` parameters and return an `int`. 

Here are some examples of how the `PrintWith_2and4()` method can be called:

```C#
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

#### Head to the next page to try an exercise using delegates -->>>
