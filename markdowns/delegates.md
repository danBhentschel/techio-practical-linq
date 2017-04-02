# Background: Delegates

When learning LINQ, it is important to have a good understanding of delegates in C#. Many of the more powerful capabilities of LINQ make use of delegates.

### What is a delegate?
A delegate is simply a reference to a method. Delegates can be stored and passed around in a variable, and hence they must have a type definition:

```C#
public delegate int FuncTwoInts(int, int);
```

The line above defines the type `FuncTwoInts`.

### Delegate expressions
The `FuncTwoInts` type can be used to declare variables like this:

```C#
private static int Add(int one, int two)
{
	return one + two;
}

private FuncTwoInts theFunc = Add;
```

Or like this:

```C#
FuncTwoInts theFunc = delegate(int one, int two) {
    return one + two;
};
```

Or this:

```C#
FuncTwoInts theFunc = (one, two) => {
    return one + two;
};
```

Or even like this:

```C#
FuncTwoInts theFunc = (one, two) => one + two;
```

### Lambda expressions
The last two delegate examples above (the ones utilizing the => operator) are called lambda expressions. Lambda expressions are just a more efficient way of defining a delegate.

The => operator is called the lambda operator.
