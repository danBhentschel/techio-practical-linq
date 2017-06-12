[//]: # (GENERATED FILE -- DO NOT EDIT)
# [SelectMany(&lt;selector&gt;)](https://msdn.microsoft.com/en-us/library/bb534336%28v=vs.110%29.aspx) method
The `SelectMany()` method is used to "flatten" a sequence in which the elements of the sequence are, themselves, sequences. For example, `SelectMany()` can turn a two-dimensional array into a single sequence of values, as shown in this example:

```csharp
int[][] arrays = {
    new[] {1, 2, 3},
    new[] {4},
    new[] {5, 6, 7, 8},
    new[] {12, 14}
};
// Will return { 1, 2, 3, 4, 5, 6, 7, 8, 12, 14 }
IEnumerable<int> result = arrays.SelectMany(array => array);
```

Notice that in the above code, we passed an identity lambda expression into the `SelectMany()` call. This causes the elements of the constituent arrays to be copied, unaltered, into the resultant sequence.

You can also perform transformations on the constituent sequences, as shown in this example utilizing a list of lists:

```csharp
List<List<int>> lists = new List<List<int>> {
    new List<int> {1, 2, 3},
    new List<int> {12},
    new List<int> {5, 6, 5, 7},
    new List<int> {10, 10, 10, 12}
};
// Will return { 1, 2, 3, 12, 5, 6, 7, 10, 12 }
IEnumerable<int> result = lists.SelectMany(list => list.Distinct());
```
