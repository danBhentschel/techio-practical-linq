# LINQ Concepts: Using LINQ

LINQ is a collection of extension methods that extend the `IEnumerable<T>` interface, as discussed in the Background lessons. There are around 50 unique methods currently available in LINQ, or even more than that if you count different signature variations as separate methods. The complete list can be found here:

[MSDN Enumerable Methods documentation](https://msdn.microsoft.com/en-us/library/system.linq.enumerable_methods%28v=vs.110%29.aspx)

Some methods are very simple, such as the `Count()` method that we have already seen and used in previous examples. Several LINQ methods are very complicated and difficult to understand, though. The `GroupJoin()` method would be a good example of this type.

### General method categories
 - Some methods return a single value from the sequence, such as `First()` or `Last()`.
 - Other methods return multiple values out of the sequence, such as `Take()`, `Skip()`, and `Where()`.
 - Some other methods return a completely different sequence based on the input, such as `Select()` and `Cast()`.
 - Still other methods return a single calculated value based on the input. `Any()`, `Sum()`, and `Max()` are examples of this type.

### Categorization quiz
Based on the method name and the signature information in the [MSDN documentation](https://msdn.microsoft.com/en-us/library/system.linq.enumerable_methods%28v=vs.110%29.aspx), try to guess in which of the above categories each method belongs.

?[Which category best describes the Count() method?]
 - [ ] Single value from the sequence
 - [ ] Multiple values from the sequence
 - [ ] Different sequence based on the input
 - [x] Single calculated value based on the input

?[Which category best describes the Skip() method?]
 - [ ] Single value from the sequence
 - [x] Multiple values from the sequence
 - [ ] Different sequence based on the input
 - [ ] Single calculated value based on the input

?[Which category best describes the SelectMany() method?]
 - [ ] Single value from the sequence
 - [ ] Multiple values from the sequence
 - [x] Different sequence based on the input
 - [ ] Single calculated value based on the input

?[Which category best describes the ElementAt() method?]
 - [x] Single value from the sequence
 - [ ] Multiple values from the sequence
 - [ ] Different sequence based on the input
 - [ ] Single calculated value based on the input

