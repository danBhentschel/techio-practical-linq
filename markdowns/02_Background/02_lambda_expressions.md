[//]: # (GENERATED FILE -- DO NOT EDIT)
# Background Topics - Lambda Expressions

A lambda expression is a convenient way of defining an anonymous (unnamed) function that can be passed around as a variable, or a parameter to a method call. Many LINQ methods take a function (called a **delegate**) as a parameter. Here is an example of what a lambda expression looks like:

```csharp
Func<int, int> multiplyByFive = num => num * 5;
// Returns 35
int result = multiplyByFive(7);
```

The expression `num => num * 5` is a lambda expression. The `=>` operator is called the "lambda operator". In this example, `num` is an input parameter to the anonymous function, and the return value of this function is `num * 5`.

### Parameter(s)
Notice that the `num` parameter doesn't explicitly specify a data type. The compiler always infers the data type of lambda expression parameters from context. In this case, the context is that the lambda expression is stored in a variable of type `Func<int, int>`. This means that it takes an `int` parameter and returns an `int` result.

You can also create lambda expressions with more than one parameter, as shown here:

```csharp
Func<int, int, int> multiplyTwoNumbers = (a, b) => a * b;
// Returns 35
int result = multiplyTwoNumbers(7, 5);
```

We won't be using multi-parameter lambda expressions much in this course

### Return value
Notice also that there is no `return` statement. Single-line lambda expressions don't need to explicitly use the `return` keyword to return a value. This same thing could also be written as:

```csharp
Func<int, int> multiplyByFive = num =>
{
    int product = num * 5;
    return product;
};
// Returns 35
int result = multiplyByFive(7);
```

In this case, since the lambda expression has more than one line, the `return` keyword is required.

### Exercise
In this exercise, write a lambda expression that returns the provided plus one.

@[Lambda Expressions Exercise]({"stubs": ["Background1/LambdaExpressions1.cs"], "command": "Background1.UnitTest.Exercise1", "project": "exercises"})
