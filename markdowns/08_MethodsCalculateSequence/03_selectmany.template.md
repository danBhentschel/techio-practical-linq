# [SelectMany(&lt;selector&gt;)](https://msdn.microsoft.com/en-us/library/bb534336%28v=vs.110%29.aspx) method
The `SelectMany()` method is used to "flatten" a sequence in which the elements of the sequence are sequences themselves. For example, `SelectMany()` can turn a two-dimensional array into a single sequence of values, as shown in this example:

```csharp
//// EMBED: LinqCourseEmbeddedCode/Methods5.cs, SelectMany() 1
```

Notice that in the code above, we passed an identity lambda expression into the `SelectMany()` call. This causes the elements of the constituent arrays to be copied into the resultant sequence without alteration.

As shown in this example utilizing a list of lists, you can also perform transformations on the constituent sequences:

```csharp
//// EMBED: LinqCourseEmbeddedCode/Methods5.cs, SelectMany() 2
```
