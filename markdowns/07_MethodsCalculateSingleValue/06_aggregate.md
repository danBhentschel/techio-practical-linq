[//]: # (GENERATED FILE -- DO NOT EDIT)
# [Aggregate(&lt;func&gt;)](https://msdn.microsoft.com/en-us/library/bb548651%28v=vs.110%29.aspx) method
The `Aggregate()` method applies a function to all the elements of the source sequence and calculates a cumulative result that takes into account the return value of each function call.

This is a somewhat complicated concept, and is best shown with some examples.

```csharp
IEnumerable<int> ints = new List<int> { 2, 2, 4, 6 };
// Reimplementation of the Sum() method utilizing Aggregate()
// Will return 14
int result = ints.Aggregate((sum, val) => sum + val);


IEnumerable<string> strings = new List<string> { "a", "ab", "abc", "abcd" };
// Will return "a&ab&abc&abcd"
string result = strings.Aggregate((concat, str) => $"{concat}&{str}");
```

> **NOTE:** The return value of the `Aggregate()` call (and the provided **func**) must be the same data type as that of the elements in the source sequence.

# [Aggregate(&lt;seed&gt;, &lt;func&gt;)](https://msdn.microsoft.com/en-us/library/bb549218%28v=vs.110%29.aspx) method
Another form of `Aggregate()` takes a **seed**, which specifies the initial value supplied to the **func**. In addition, this form of `Aggregate()` can return a value of a different data type than that of the elements in the source sequence. In this case, the data type of the value returned from **func** must match the data type of **seed**.

```csharp
IEnumerable<string> strings = new List<string> { "a", "ab", "abc", "abcd" };
// Reimplementation of the Count() method utilizing Aggregate()
// Will return 4
int result = strings.Aggregate(0, (count, val) => count + 1);


IEnumerable<string> strings = new List<string> { "a", "ab", "abc", "abcd" };
// Reimplementation of Any(str => str.Length > 3) utilizing Aggregate()
// Will return true
bool result = strings.Aggregate(false, (any, val) => any || (val.Length > 3));
```

# Aggregate() exercise
Think you can handle it? Try to use `Aggregate()` to write a method that will return the total number of characters in all the words in the source sequence.

@[Aggregate Exercise]({"stubs": ["SingleCalculatedValue1/Aggregate1.cs"], "command": "SingleCalculatedValue1.UnitTest.Exercise3", "project": "exercises"})
