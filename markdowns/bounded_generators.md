# Background: Bounded generators

There is a certain set of problems for which an unbounded generator is a great solution. But the majority of real-world situations deal with bounded problems. In fact, in order to use the `GetFibonacci()` method in practical examples, we found that it was necessary to impose some bounds on the sequence.

### Exiting the generator method
One way to make a generator bounded is to simply allow the method to exit normally. Suppose we wanted `GetFibonacci()` to provide only the first `n` values of the sequence. We could write this like:

```C#
public IEnumerable<int> GetFibonacci(int n)
{
    int previousVal1 = 0;
    int previousVal2 = 1;
	
	for (int i = 0; i < n; i++)
	{
		int nextVal = previousVal1 + previousVal2;
		previousVal1 = previousVal2;
		previousVal2 = nextVal;
		yield return nextVal;
	}
}
```

Now, we could use this like so:

```C#
// Will print:
// Value: 1
// Value: 2
// Value: 3
// Value: 5
// Value: 8
foreach (int val in GetFibonacci(5))
{
    Console.WriteLine($"Value: {val}");
}
```

Unlike with the previous examples, we don't need to break out of the `foreach` loop. It will complete normally at the end of the 5 value sequence.