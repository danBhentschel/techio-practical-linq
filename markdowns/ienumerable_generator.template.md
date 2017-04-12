# Background: Unbounded Generators


### The Fibonacci generator
In the previous lesson, we looked at an `IEnumerable<int>` backed by a `List<int>`. An `IEnumerable<T>` could also be backed by a stateful method, rather than a static collection. This method is called a generator, and it looks like this:

```csharp
//// EMBED: LinqCourseEmbeddedCode/IEnumerable1.cs, Declare GetFibonacci() generator method
```

Wait a minute! What does that return? It looks like it's returning an `int`, even though the method declaration returns an `IEnumerable<int>`. And what's up with that infinite loop?

### How it works
The magic is in that `yield return` statement. Within the context of a single _iteration_, each execution of that line returns the next value in the sequence. The `yield return` statement maintains context so that a request for the subsequent value can continue execution right where it left off.

Be aware that, at least in this example, this method produces a pseudo-infinite sequence. It's not truly infinite, as the following examples will illustrate.
