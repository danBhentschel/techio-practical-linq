# Methods: Calculating a single value

### [Sum()]https://msdn.microsoft.com/en-us/library/bb338442%28v=vs.110%29.aspx) method
Without a parameter, the `Sum()` method can only be called on a sequence containing numerical elements. It returns a single value indicating the sum of all elements in the sequence. The type of the value returned matches the data type of the elements in the sequence.

```csharp
//// EMBED: LinqCourseEmbeddedCode/Methods4.cs, Sum()
```

### [Sum(&lt;selector&gt;)](https://msdn.microsoft.com/en-us/library/bb535184%28v=vs.110%29.aspx) method
The `Sum()` method can also be called with a **selector** delegate parameter. The provided delegate should take a parameter of type `T` and return a numerical value. The result of the `Sum()` call will be the summation of all of these numerical values, as calculated for each element in the sequence. The type of the value returned from `Sum()` matches the data type of the of the value returned from the **selector**.

```csharp
//// EMBED: LinqCourseEmbeddedCode/Methods4.cs, Sum() selector
```

### Sum() quiz
```csharp
//// EMBED: LinqCourseEmbeddedCode/Methods4.cs, Sum() question 1
```
?[What value and data type would the Sum() method return in the code snippet above?]
 - [ ] 3 (int)
 - [ ] 6 (int)
 - [ ] 6.9 (double)
 - [x] 6.9 (float)

```csharp
//// EMBED: LinqCourseEmbeddedCode/Methods4.cs, Sum() question 2
```
?[What value and data type would the Sum() method return in the code snippet above?]
 - [ ] 3 (int)
 - [x] 6 (int)
 - [ ] 6.9 (double)
 - [ ] 6 (float)
