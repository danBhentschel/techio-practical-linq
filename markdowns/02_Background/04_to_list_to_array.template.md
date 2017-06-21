# Background Topics - ToList() and ToArray()

Any LINQ method that returns a sequence of elements returns it as an `IEnumerable<T>`. For many applications, it can be difficult to work with this interface, and it may be desirable to **iterate** this enumerable to either a list or an array. Both of these are more intuitive to use.

LINQ provides two very handy methods to do just this: [`ToList()`](https://msdn.microsoft.com/en-us/library/bb342261%28v=vs.110%29.aspx) and [`ToArray()`](https://msdn.microsoft.com/en-us/library/bb298736%28v=vs.110%29.aspx). They "convert" an `IEnumerable<T>` to either a `List<T>` or an array of type `T[]`.

Here are a few examples:

```csharp
//// EMBED: LinqCourseEmbeddedCode/Background1.cs, ToList() and ToArray()
```
