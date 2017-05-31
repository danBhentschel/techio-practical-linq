[//]: # (GENERATED FILE -- DO NOT EDIT)
# Background Topics - ToList() and ToArray()

Any LINQ method that returns a sequence of elements returns it as an `IEnumerable<T>`. For many applications, it can be difficult to work with this interface, and it may be desirable to **iterate** this enumerable to either a list or an array. Both of these are more intuitive to use.

LINQ provides two very handy methods to do just this: `ToList()` and `ToArray()`. They, wonder of wonders, "convert" an `IEnumerable<T>` to either a `List<T>` or an array of type `T[]`.

Here are a few examples:

```csharp
List<int> list = new[] {1, 2, 3}.ToList();
int[] array = new List<int> {1, 2, 3}.ToArray();
List<int> list2 = new SortedSet<int> {1, 2, 3}.ToList();
```