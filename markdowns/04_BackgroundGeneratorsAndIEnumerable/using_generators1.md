[//]: # (GENERATED FILE -- DO NOT EDIT)
# Background: Using generators

Let's continue using the unbounded `GetFibonacci()` generator method from the previous lesson. Take a look at this line of code:

```csharp
Console.WriteLine(GetFibonacci().Count());
```

What will this print?

Actually, it won't print anything. It will process for a while, and then eventually fail with the error:

<pre>
System.OverflowException: Arithmetic operation resulted in an overflow.
</pre>

Why do you think this is?

Eventually, the numbers produced by the `GetFibonacci()` method get large enough that they don't fit into an `int`. This is the cause of the `OverflowException`.

> **NOTE:** The `Count()` method used above is a LINQ method. More on this later.
