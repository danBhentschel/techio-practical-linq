# Methods: Calculate a new sequence

### SelectMany(&lt;selector&gt;) method
The `SelectMany()` method is used to "flatten" a sequence in which the elements of the sequence are, themselves, sequences. For example, `SelectMany()` can turn a two-dimensional array into a single sequence of values, as shown in this example:

```csharp
//// EMBED: LinqCourseEmbeddedCode/Methods5.cs, SelectMany() 1
```

Notice that in the above code, we passed an identity lambda expression into the `SelectMany()` call. This causes the elements of the constituent arrays to be copied, unaltered, into the resultant sequence.

You can also perform transformations on the constituent sequences, as shown in this example utilizing a list of lists:

```csharp
//// EMBED: LinqCourseEmbeddedCode/Methods5.cs, SelectMany() 2
```