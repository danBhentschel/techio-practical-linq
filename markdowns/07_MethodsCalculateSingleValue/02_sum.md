[//]: # (GENERATED FILE -- DO NOT EDIT)
# Methods: Calculating a single value

### [Sum()](https://msdn.microsoft.com/en-us/library/bb338442%28v=vs.110%29.aspx) method
Without a parameter, the `Sum()` method can only be called on a sequence containing numerical elements. It returns a single value indicating the sum of all elements in the sequence. The type of the value returned matches the data type of the elements in the sequence.

```csharp
IEnumerable<int> ints = new List<int> { 2, 2, 4, 6 };
// Will return 14
int result = ints.Sum();
```

### [Sum(&lt;selector&gt;)](https://msdn.microsoft.com/en-us/library/bb535184%28v=vs.110%29.aspx) method
The `Sum()` method can also be called with a **selector** delegate parameter. The provided delegate should take a parameter of type `T` and return a numerical value. The result of the `Sum()` call will be the summation of all of these numerical values, as calculated for each element in the sequence. The type of the value returned from `Sum()` matches the data type of the of the value returned from the **selector**.

```csharp
IEnumerable<int> ints = new List<int> { 2, 2, 4, 6 };
// Will return 60
int result = ints.Sum(val => val * val);
```

### Sum() quiz
```csharp
IEnumerable<string> strings = new List<string> { "a", "ab", "abc" };
var result = strings.Sum(str => 2.3F);
```
?[What value and data type would the Sum() method return in the code snippet above?]
 - [ ] 3 (int)
 - [ ] 6 (int)
 - [ ] 6.9 (double)
 - [x] 6.9 (float)

```csharp
IEnumerable<string> strings = new List<string> { "a", "ab", "abc" };
var result = strings.Sum(str => str.Length);
```
?[What value and data type would the Sum() method return in the code snippet above?]
 - [ ] 3 (int)
 - [x] 6 (int)
 - [ ] 6.9 (double)
 - [ ] 6 (float)
