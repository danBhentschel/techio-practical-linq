# Background: Bounded generators

Suppose we want to have a generator that provides a bounded sequence, but it's non-trivial to calculate exactly how many values will be in the sequence. There is a way to do this as well.

### The yield break statement
Let's write a `GetFibonacci()` method that returns a sequence in which the maximum returned value is less-than-or-equal-to a provided `max` parameter. Here is one implementation of such a method:

```csharp
//// EMBED: LinqCourseEmbeddedCode/IEnumerable1.cs, Declare GetFibonacciUpTo() generator method
```

When execution hits the `yield break` statement, the iterator ends, as shown here using the `Count()` LINQ method:

```csharp
//// EMBED: LinqCourseEmbeddedCode/IEnumerable1.cs, Call GetFibonacciUpTo().Count()
```
