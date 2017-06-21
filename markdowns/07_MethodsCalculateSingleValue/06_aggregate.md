[//]: # (GENERATED FILE -- DO NOT EDIT)
# [Aggregate(&lt;func&gt;)](https://msdn.microsoft.com/en-us/library/bb548651%28v=vs.110%29.aspx) method
The `Aggregate()` method applies a function to all the elements of the source sequence and calculates a cumulative result that takes into account the return value of each function call.

This is a somewhat complicated concept, and is best shown with some examples.

```csharp
IEnumerable<int> ints = new List<int> { 2, 4, 1, 6 };
// Reimplementation of the Sum() method utilizing Aggregate()
// Will return 13
int result = ints.Aggregate((sum, val) => sum + val);
```

What's happening in this example? We have provided the lambda expression `(sum, val) => sum + val` to the `Aggregate()` method. This expression will be executed 3 (length - 1) times:

1. It is passed 2 and 4 for the `sum` and `val` parameters, and returns the sum: 6.
2. It is passed 6 and 1 for `sum` and `val`, and returns 7.
3. It is passed 7 and 6 and returns 13.


```csharp
IEnumerable<string> strings = new List<string> { "a", "ab", "abc", "abcd", "z" };
// Will return "a&ab&abc&abcd&z"
string result = strings.Aggregate((concat, str) => $"{concat}&{str}");
```

In this example, the expression `(concat, str) => $"{concat}&{str}"` is called 4 times:

1. It is passed "a" and "ab" for the `concat` and `str` parameters, and returns "a&ab".
2. It is passed "a&ab" and "abc" and returns "a&ab&abc".
3. "a&ab&abc" and "abcd" -> "a&ab&abc&abcd"
4. "a&ab&abc&abcd" and "z" -> "a&ab&abc&abcd&z"

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
