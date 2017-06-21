# LINQ Concepts: Using LINQ

LINQ is a collection of extension methods that extend the `IEnumerable<T>` interface, as discussed in the Background lessons. There are around 50 unique methods currently available in LINQ (even more if you count different signature variations as separate methods)! The complete list can be found here:

[MSDN Enumerable Methods documentation](https://msdn.microsoft.com/en-us/library/system.linq.enumerable_methods%28v=vs.110%29.aspx)

Some methods are very simple, such as the `Count()` method. On the other hand, several LINQ methods are very complicated and difficult to understand. The `GroupJoin()` method would be a good example of this.

## General method categories
 - Some methods return a single element from the target sequence, such as `First()` or `Last()`.
 - Some methods return multiple elements out of the target sequence, such as `Take()`, `Skip()`, and `Where()`.
 - Some methods return the entire target sequence with the elements' order changed, such as `Reverse()` and `OrderBy()`.
 - Some methods return a single calculated value based on the input, such as `Any()`, `Sum()`, and `Max()`.
 - Some methods return a completely different sequence based on the target sequence, such as `Select()` and `Cast()`.

# Categorization quiz
Based on the method name and the signature information in the [MSDN documentation](https://msdn.microsoft.com/en-us/library/system.linq.enumerable_methods%28v=vs.110%29.aspx), try to guess in which of the above categories each method belongs.

?[Which category best describes the Count() method?]
 - [ ] Single element from the sequence
 - [ ] Multiple elements from the sequence
 - [ ] Change the order of the elements
 - [x] Single calculated value based on the input
 - [ ] Different sequence based on the input

?[Which category best describes the Intersect() method?]
 - [ ] Single element from the sequence
 - [x] Multiple elements from the sequence
 - [ ] Change the order of the elements
 - [ ] Single calculated value based on the input
 - [ ] Different sequence based on the input

?[Which category best describes the SelectMany() method?]
 - [ ] Single element from the sequence
 - [ ] Multiple elements from the sequence
 - [ ] Change the order of the elements
 - [ ] Single calculated value based on the input
 - [x] Different sequence based on the input

?[Which category best describes the ElementAt() method?]
 - [x] Single element from the sequence
 - [ ] Multiple elements from the sequence
 - [ ] Change the order of the elements
 - [ ] Single calculated value based on the input
 - [ ] Different sequence based on the input
