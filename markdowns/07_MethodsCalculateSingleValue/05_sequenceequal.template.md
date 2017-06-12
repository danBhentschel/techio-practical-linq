# [SequenceEqual()](https://msdn.microsoft.com/en-us/library/bb348567%28v=vs.110%29.aspx) method
The `SequenceEqual()` method takes a **second** `IEnumerable<T>` sequence as a parameter, and performs a comparison, element-by-element, with the target (first) sequence. If the two sequences contain the same number of elements, and each element in the first sequence is equal to the corresponding element in the second sequence (using the [default equality comparer](https://msdn.microsoft.com/en-us/library/ms224763%28v=vs.110%29.aspx)) then `SequenceEqual()` returns `true`.  Otherwise, `false` is returned.

It is interesting to note that this can be used to compare *any* two sequences! So, for example, a list and an array can be compared using this method. It can be quite handy sometimes. The only stipulation is that the data type of the two sequences, `<T>`, must be the same.

```csharp
//// EMBED: LinqCourseEmbeddedCode/Methods4.cs, SequenceEqual()
```

> **NOTE:** There is also another form of `SequenceEqual()` that takes an `IEqualityComparer<T>` comparer parameter to use instead of the default equality comparer.

# SequenceEqual() quiz
Which of the following would _both_ compile correctly _and_ return `true`?

?[Which statements would compile and return true?]
 - [ ] new[]{2}.SequenceEqual(2)
 - [x] new SortedSet&lt;int&gt;{1,2,4}.SequenceEqual(new[]{1,2,4})
 - [ ] new[]{2,5,2}.SequenceEqual(new[]{2,5,2,2})
 - [ ] new[]{1,1,1}.SequenceEqual(new[]{1,1})
 - [ ] new[]{"1","2","3"}.SequenceEqual(new[]{1,2,3})
 - [x] new List&lt;string&gt;{"a","b","abc"}.SequenceEqual(new[]{"a","b","abc"})
 - [ ] new[]{1,2}.SequenceEqual(new[]{1.0,2.0})
