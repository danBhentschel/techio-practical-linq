# Background: Delegate Variables

### Delegate expressions
The `FuncTwoInts` type can be used to declare variables like this:

```csharp
private static int Add(int one, int two)
{
	return one + two;
}

private FuncTwoInts theFunc = Add;
```

Or like this:

```csharp
FuncTwoInts theFunc = delegate(int one, int two) {
    return one + two;
};
```

Or this:

```csharp
FuncTwoInts theFunc = (one, two) => {
    return one + two;
};
```

Or even like this:

```csharp
FuncTwoInts theFunc = (one, two) => one + two;
```

### Lambda expressions
The last two delegate examples above (the ones utilizing the => operator) are called lambda expressions. Lambda expressions are just a more efficient way of defining a delegate.

The => operator is called the lambda operator.
