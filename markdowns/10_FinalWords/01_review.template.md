# Using C# LINQ - Review
Congratulations on completing the **Using C# LINQ** course!

Here is a quick review of what you have learned:

### Lambda expressions
Lambda expressions are defined using the lambda operator, `=>`, and allow you to define an anonymous method that can be stored and passed around in a variable. Here is an example of a lambda expression:

```csharp
//// EMBED: LinqCourseEmbeddedCode/Background1.cs, Lambda 1
```

Many LINQ methods take a method reference (called a delegate) as a parameter, and lambda expressions are a convenient way of defining these delegates.

### IEnumerable&lt;T&gt;
LINQ methods are extensions to the `IEnumerable<T>` interface, which is an abstraction for a sequence of values of data type `T`. Any LINQ method can be called on anything that implements `IEnumerable<T>`, including C# arrays and collections.

Any `IEnumerable<T>` can be converted into an array or a list (which may be more convenient to work with) by calling the `ToArray()` or `ToList()` LINQ methods.

### MSDN documentation
Every LINQ method is documented on MSDN at the following address:

[https://msdn.microsoft.com/en-us/library/system.linq.enumerable_methods%28v=vs.110%29.aspx](https://msdn.microsoft.com/en-us/library/system.linq.enumerable_methods%28v=vs.110%29.aspx)

### Query and method syntax
There are two different ways to express a LINQ statement in C#: query syntax and method syntax. Query syntax looks similar to SQL, and may be more human-readable, but not all LINQ methods are supported by query syntax. Method syntax looks more like standard C# code, and supports the full set of LINQ methods. Query syntax is converted into method syntax by the compiler.

### LINQ Methods
We discussed 27 different LINQ methods, arranged into five categories:

 - Methods to **extract a single element** from a sequence: `First()`, `Last()`, `Single()`, `FirstOrDefault()`, `LastOrDefault()`, and `SingleOrDefault()`
 - Methods to **extract multiple elements** from a sequence: `Skip()`, `Take()`, `SkipWhile()`, `TakeWhile()`, `Distinct()`, `Intersect()`, and `Where()`
 - Methods to **change the order** of the elements in a sequence: `Reverse()`, `OrderBy()` and `ThenBy()`
 - Methods to **calculate a single value** based on a sequence: `Count()`, `Sum()`, `Min()`, `Max()`, `Any()`, `All()`, `SequenceEqual()`, and `Aggregate()`
 - Methods to **calculate a new sequence** based on a source sequence: `Cast<U>()`, `Select()`, and `SelectMany()`
