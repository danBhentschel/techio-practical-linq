# Methods: Calculating a single value

### Sum() method
Without a parameter, the `Sum()` method can only be called on a sequence containing numerical elements. It returns a single value indicating the sum of all elements in the sequence. The type of the value returned matches the data type of the elements in the sequence.

```csharp
//// EMBED: LinqCourseEmbeddedCode/Methods4.cs, Sum()
```

### Sum(&lt;selector&gt;) method
The `Sum()` method can also be called with a **selector** delegate parameter. The provided delegate should take a parameter of type `T` and return a numerical value. The result of the `Sum()` call will be the summation of all of these numerical values, as calculated for each element in the sequence. The type of the value returned from `Sum()` matches the data type of the of the value returned from the **selector**.

```csharp
//// EMBED: LinqCourseEmbeddedCode/Methods4.cs, Sum() selector
```

### Sum() quiz
```csharp
//// EMBED: LinqCourseEmbeddedCode/Methods4.cs, Sum() question 1
```
?[What data type would the Sum() method return in the code snippet above?]
 - [ ] int
 - [ ] long
 - [ ] double
 - [x] float

```csharp
//// EMBED: LinqCourseEmbeddedCode/Methods4.cs, Sum() question 2
```
?[What data type would the Sum() method return in the code snippet above?]
 - [x] int
 - [ ] long
 - [ ] double
 - [ ] float