[//]: # (GENERATED FILE -- DO NOT EDIT)
# Methods: Changing element order

### ThenBy() method
`ThenBy()` specifies a secondary sort **key** that is used to further sort data that has already been sorted with a call to `OrderBy()`.

`ThenBy()` is an interesting method. It is not an extension to `IEnumerable<T>`. It is a method of the `IOrderedEnumerable<T>` type, which is returned from `OrderBy()`, `OrderByDescending()`, `ThenBy()`, and `ThenByDescending()`.

Since `IOrderedEnumerable<T>` implements the `IEnumerable<T>` interface, it can be thought of as an `IEnumerable<T>` with attached metadata that describes the order operations that have previously been performed on the sequence.

`ThenBy()` can be called any number of times, providing a new **key** on each subsequent call.

```csharp
ERROR: CONTENT NOT FOUND FOR TAG "ThenBy\(\)" in LinqCourseEmbeddedCode/Methods3.cs
```

?[Which of the following use correct syntax?]
 - [x] names = names.OrderBy(n => n.Last).ThenBy(n => n.First)
 - [ ] planets = planets.OrderBy(p => p.Type).Reverse().ThenBy(p => p.Size)
 - [x] houses = houses.OrderBy(h => h.BedRooms).ThenBy(h => h.Baths).ThenBy(h => h.Size)
 - [ ] drinks = drinks.OrderBy(d => d.Calories).ThenBy(d.CaffeineContent).ThenBy(d.Price)

### ThenBy() exercise
In the following exercise, try to order all the input names by `Last`. If any names have the same value for `Last`, then they should be ordered by `First`. If any have matching `Last` and `First`, then they should be ordered by `Middle`.

@[ThenBy Exercise]({"stubs": ["ChangeOrder1/ThenBy1.cs"], "command": "ChangeOrder1.UnitTest.Exercise2", "project": "exercises"})
