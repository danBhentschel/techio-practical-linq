# Methods: Calculating a single value

### [Any(&lt;predicate&gt;)](https://msdn.microsoft.com/en-us/library/bb534972%28v=vs.110%29.aspx) method
Returns `true` if _at least one of the elements_ in the source sequence matches the provided **predicate**. Otherwise it returns `false`.

```csharp
//// EMBED: LinqCourseEmbeddedCode/Methods4.cs, Any()
```

> **NOTE:** `Any()` can also be called [without a predicate](https://msdn.microsoft.com/en-us/library/bb337697%28v=vs.110%29.aspx), in which case it will return `true` if there is at least one element in the source sequence.

### [All(&lt;predicate&gt;)](https://msdn.microsoft.com/en-us/library/bb548541%28v=vs.110%29.aspx) method
Returns `true` if _every element_ in the source sequence matches the provided **predicate**. Otherwise it returns `false`.

```csharp
//// EMBED: LinqCourseEmbeddedCode/Methods4.cs, All()
```

### Any() / All() quiz
```csharp
//// EMBED: LinqCourseEmbeddedCode/Methods4.cs, Any() All() question
```

?[What would be the value of the "result" variable in the code snippet above?]
 - [ ] none
 - [ ] red
 - [ ] orange
 - [x] yellow
 - [ ] green
 - [ ] blue
