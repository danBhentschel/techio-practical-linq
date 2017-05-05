# Methods: Calculating a single value

### Any(&lt;condition&gt;) method
Returns `true` if at least one of the values in the source sequence meets the provided **condition**. Otherwise it returns `false`.

```csharp
//// EMBED: LinqCourseEmbeddedCode/Methods4.cs, Any()
```

> **NOTE:** `Any()` can also be called without a condition, in which case it will return `true` if there is at least one element in the source sequence.

### All(&lt;condition&gt;) method
Returns `true` if every value in the source sequence meets the provided **condition**. Otherwise it returns `false`.

```csharp
//// EMBED: LinqCourseEmbeddedCode/Methods4.cs, All()
```

### Any() / All() quiz
```csharp
//// EMBED: LinqCourseEmbeddedCode/Methods4.cs, Any() All() question
```

?[What would be the value of the "result" variable in the above code snippet?]
 - [ ] red
 - [ ] orange
 - [x] yellow
 - [ ] green
 - [ ] blue
