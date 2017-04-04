# Background: Unbounded Generators


### The Fibonacci generator
In the previous lesson, we looked at an `IEnumerable<int>` backed by a `List<int>`. An `IEnumerable<T>` could also be backed by a stateful method, rather than a static collection. This method is called a generator, and it looks like this:

```C#
public IEnumerable<int> GetFibonacci()
{
    int previousVal1 = 0;
    int previousVal2 = 1;
	
	while (true)
	{
		int nextVal = previousVal1 + previousVal2;
		previousVal1 = previousVal2;
		previousVal2 = nextVal;
		yield return nextVal;
	}
}
```

Wait a minute! What does that return? It looks like it's returning an `int`, even though the method declaration returns an `IEnumerable<int>`. And what's up with that infinite loop?

### How it works
The magic is in that `yield return` statement. Within the context of a single _iteration_, each implementation of that line returns the next value of the sequence, and then maintains context so that a request for the subsequent value can continue right where it left off.

Be aware that, at least in this example, this method produces a pseudo-infinite sequence. It's not truly infinite, as the following examples will illustrate.