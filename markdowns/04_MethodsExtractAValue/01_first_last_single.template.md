# Methods: Extract a single element

These LINQ methods can be used to extract a single element from an `IEnumerable<T>` sequence. 

> **NOTE:** All four of the methods in this lesson throw an exception if they can't find an appropriate element to return. Only use them if you are absolutely certain that an element exists for them to return. You could `catch` the exception (and probably should to handle true error conditions) but if you expect that these may reasonably fail, you should use the `OrDefault` variants instead. We will go over those methods in a later lesson.

# [First()](https://msdn.microsoft.com/en-us/library/bb291976%28v=vs.110%29.aspx) method
Intuitively enough, this extracts the first element in the sequence. The data type of the value returned depends on the type of `T` in the `IEnumerable<T>` that the method is invoked on. If it is a sequence of `int`, then `First()` will return an `int`.

For example:

```csharp
//// EMBED: LinqCourseEmbeddedCode/Methods1.cs, First()
```

Looking at this code, what do you think the `First()` method call would return?

?[What is the value of the whatsThis variable?]
 - [ ] 2.2
 - [x] 2.0
 - [ ] Nothing. The First() call would throw an Exception.
 - [ ] 2.3

# [Last()](https://msdn.microsoft.com/en-us/library/bb358775%28v=vs.110%29.aspx) method
Hmm.... What do you think the `Last()` in this code would return?

```csharp
//// EMBED: LinqCourseEmbeddedCode/Methods1.cs, Last()
```

?[What is the value of the whatsThis variable?]
 - [ ] 2.2
 - [ ] 2.0
 - [ ] Nothing. The Last() call would throw an Exception.
 - [x] 2.3

# [ElementAt()](https://msdn.microsoft.com/en-us/library/bb299233%28v=vs.110%29.aspx) method
Try this one. What would the `ElementAt(2)` call return in this code snippet?

```csharp
//// EMBED: LinqCourseEmbeddedCode/Methods1.cs, ElementAt()
```

?[What is the value of the whatsThis variable?]
 - [x] 2.2
 - [ ] 2.0
 - [ ] Nothing. The ElementAt() call would throw an Exception.
 - [ ] 2.3

# [Single()](https://msdn.microsoft.com/en-us/library/bb155325%28v=vs.110%29.aspx) method
`Single()` is an interesting method. You call it when you are expecting that there is only a single element in the sequence. If there is more than one element, or if there are no elements, then `Single()` will throw an exception.

With this in mind, what do you think this would return?

```csharp
//// EMBED: LinqCourseEmbeddedCode/Methods1.cs, Single()
```

?[What is the value of the whatsThis variable?]
 - [ ] 2.2
 - [ ] 2.0
 - [x] Nothing. The Single() call would throw an Exception.
 - [ ] 2.3
