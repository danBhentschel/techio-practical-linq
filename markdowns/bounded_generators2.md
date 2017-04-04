# Background: Bounded generators

Suppose we want to have a generator that provides a bounded sequence, but it's non-trivial to calculate exactly how many values will be in the sequence. There is a way to do this as well.

### The `yield break` statement
Let's write a `GetFibonacci()` method that returns a sequence in which the maximum returned value is less-than-or-equal-to a provided `max` parameter. Here is one implementation of such a method:

```C#
public IEnumerable<int> GetFibonacci(int max)
{
    int previousVal1 = 0;
    int previousVal2 = 1;
	
	while (true)
	{
		int nextVal = previousVal1 + previousVal2;
		if (nextVal > max) yield break;
		previousVal1 = previousVal2;
		previousVal2 = nextVal;
		yield return nextVal;
	}
}
```

When execution hits the `yield break` statement, the iterator ends, as shown here using the `Count()` LINQ method:

```C#
// Prints the number 11, indicating that
// there are 11 values <= 200:
// 1, 2, 3, 5, 8, 13, 21, 34, 55, 89, 144

Console.WriteLine(GetFibonacci(200).Count());
```