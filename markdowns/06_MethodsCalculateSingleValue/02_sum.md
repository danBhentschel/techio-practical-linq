[//]: # (GENERATED FILE -- DO NOT EDIT)
# Methods: Calculating a single value

### Sum() method
Without a parameter, the `Sum()` method can only be called on a sequence containing numerical elements. It returns a single value indicating the sum of all elements in the sequence. The type of the value returned matches the data type of the elements in the sequence.

```csharp
IEnumerable<int> ints = new List<int> { 2, 2, 4, 6 };
// Will return 14
int result = ints.Sum();
```

### Sum(&lt;selector&gt;) method
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
?[What data type would the Sum() method return in the code snippet above?]
 - [ ] int
 - [ ] long
 - [ ] double
 - [x] float

```csharp
IEnumerable<string> strings = new List<string> { "a", "ab", "abc" };
var result = strings.Sum(str => str.Length);
```
?[What data type would the Sum() method return in the code snippet above?]
 - [x] int
 - [ ] long
 - [ ] double
 - [ ] float