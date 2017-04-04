# Background: Using generators

### Iterating an unbounded generator
Here is another example using the `GetFibonacci()` method:

```C#
// Will print:
// Value: 1
// Value: 2
// Value: 3
// Value: 5
// Value: 8
int i = 0;
foreach (int val in GetFibonacci())
{
    if (i > 4) break;
    Console.WriteLine($"Value: {val}");
    i++;
}
```

This is one way to (quite literally) `break` out of the infinite iteration of this sequence.

### Indexing into an `IEnumerable<T>`
You might want to try to do this:

```C#
IEnumerable<int> fibonacci = GetFibonacci();
for (int i = 0; i < 5; i++)
{
    Console.WriteLine($"Value: {fibonacci[i]}");
}
```

This won't work, though.

`IEnumerable<T>` doesn't support the `[ ]` indexer operator, which somewhat makes sense. This Fibonacci generator isn't a static array that you can index into. It is a method call that returns a series of values as the result of an evaluation. So in order to retrieve the value at index `i`, you would need to evaluate the generator method `i` times.

### Introducing a boundary with 
There is another way to get the first 5 values of the sequence:

```C#
// Will print:
// Value: 1
// Value: 2
// Value: 3
// Value: 5
// Value: 8
foreach (int val in GetFibonacci().Take(5))
{
    Console.WriteLine($"Value: {val}");
}
```

In this example, the `Take()` method is a LINQ method that returns a bounded iterator to the first 5 values of the sequence provided by `GetFibonacci()`.