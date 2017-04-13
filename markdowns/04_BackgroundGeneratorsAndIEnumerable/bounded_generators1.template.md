# Background: Bounded generators

There is a certain set of problems for which an unbounded generator is a great solution. But the majority of real-world situations deal with bounded problems. In fact, in order to use the `GetFibonacci()` method in practical examples, we found that it was necessary to impose some bounds on the sequence.

### Exiting the generator method
One way to make a generator bounded is to simply allow the method to exit normally. Suppose we wanted `GetFibonacci()` to provide only the first `n` values of the sequence. We could write it like this:

```csharp
//// EMBED: LinqCourseEmbeddedCode/IEnumerable1.cs, Declare GetFibonacciOfLength() generator method
```

Now, we could use this new `GetFibonacci()` method like so:

```csharp
//// EMBED: LinqCourseEmbeddedCode/IEnumerable1.cs, Iterate GetFibonacciOfLength()
```

Unlike with the previous examples, we don't need to break out of the `foreach` loop. It will complete normally at the end of the 5-value sequence.
