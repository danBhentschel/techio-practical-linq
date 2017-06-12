[//]: # (GENERATED FILE -- DO NOT EDIT)
# Methods: Changing element order

These LINQ methods reorder the elements in an `IEnumerable<T>` sequence. Each method in this chapter provides a different means of specifying the desired element order.

> **NOTE:** Same comment as in the last chapter. If I state that a method "returns a sequence," this is not technically true. The methods in this chapter return an `IEnumerable<T>`, which is a generator (or an iterator) that can provide a sequence on demand.

# [Reverse()](https://msdn.microsoft.com/en-us/library/bb358497%28v=vs.110%29.aspx) method
The `Reverse()` method returns a new sequence that contains all the elements from the source sequence in the opposite order.

```csharp
IEnumerable<string> strings = new List<string> { "first", "then", "and then", "finally" };
// Will contain { "finally", "and then", "then", "first" }
IEnumerable<string> result = strings.Reverse();
```

> **NOTE:** The `Reverse()` LINQ method (an extension method to `IEnumerable<T>`) behaves differently from the `Reverse()` method on `List<T>`. This unfortunate situation can cause confusion. More on this in the **Advanced Topics** course.

# [OrderBy(&lt;keySelector&gt;)](https://msdn.microsoft.com/en-us/library/bb534966%28v=vs.110%29.aspx) method
`OrderBy()` sorts the elements in the source sequence based on a **key** value. The key for an element is calculated by a **keySelector** delegate method passed into the `OrderBy()` call. The examples below demonstrate how this works.

```csharp
List<string> strings = new List<string> { "first", "then", "and then", "finally" };
// Sort the strings by their length
// Will contain { "then", "first", "finally", "and then" }
IEnumerable<string> result = strings.OrderBy(str => str.Length);

// Sort the strings by the 3rd character
// Will contain { "and then", "then", "finally", "first" }
IEnumerable<string> result = strings.OrderBy(str => str[2]);

// Sort the strings by their reversed characters
// Will contain { "then", "and then", "first", "finally" }
IEnumerable<string> result = strings.OrderBy(str => new string(str.Reverse().ToArray()));
```

> **NOTE:** The **key** values are sorted based on the output of the [default comparer](https://msdn.microsoft.com/en-us/library/azhsac5f%28v=vs.110%29.aspx) for the data type of the keys.

> **NOTE 2:** There is also an `OrderByDescending()` version of this method that sorts _in reverse order_ by the specified **key** value.

## There is no Sort()

If you want to sort the elements within a sequence, then you will need to pass in an _identity_ **keySelector** method that indicates that each element in the sequence is, itself, a **key**. Here is what that looks like:

```csharp
List<string> strings = new List<string> { "first", "then", "and then", "finally" };
// Sort the strings in alphabetical order
// Will contain { "and then", "finally", "first", "then" }
IEnumerable<string> result = strings.OrderBy(str => str);
```

# OrderBy() exercise
In the following exercise, try to sort all the input names by `Last`, in descending order.

@[OrderBy Exercise]({"stubs": ["ChangeOrder1/OrderBy1.cs"], "command": "ChangeOrder1.UnitTest.Exercise1", "project": "exercises"})
