[//]: # (GENERATED FILE -- DO NOT EDIT)
# Methods: Conditionally extract a single element

Three of the four methods in the previous lesson (`First()`, `Last()`, and `Single()`) have another form that accepts a delegate parameter to make them more selective in which element they return. The provided delegate should take a parameter of type `T` and return a `bool` indicating whether or not the provided parameter meets the criteria.

> **NOTE:** Same remark as in the previous lesson. If these methods can't find an appropriate element to return, they will throw an exception.

### [First(&lt;predicate&gt;)](https://msdn.microsoft.com/en-us/library/bb535050%28v=vs.110%29.aspx) method
Any idea what this call to `First()` would return?

```csharp
List<double> doubles = new List<double> { 2.0, 2.1, 2.2, 2.3 };
double whatsThis = doubles.First(val => val > 2.3);
```

?[What is the value of the whatsThis variable?]
 - [ ] 2.2
 - [ ] 2.0
 - [x] Nothing. The First() call would throw an Exception.
 - [ ] 2.3

### [Last(&lt;predicate&gt;)](https://msdn.microsoft.com/en-us/library/bb549138%28v=vs.110%29.aspx) method
How about this call to `Last()`?

```csharp
List<double> doubles = new List<double> { 2.0, 2.1, 2.2, 2.3 };
double whatsThis = doubles.Last(val => val < 2.1);
```

?[What is the value of the whatsThis variable?]
 - [ ] 2.2
 - [x] 2.0
 - [ ] Nothing. The Last() call would throw an Exception.
 - [ ] 2.3

### [Single(&lt;predicate&gt;)](https://msdn.microsoft.com/en-us/library/bb535118%28v=vs.110%29.aspx) method
And this call to `Single()`?

```csharp
List<double> doubles = new List<double> { 2.0, 2.1, 2.2, 2.3 };
double whatsThis = doubles.Single(val => val > 2.2);
```

?[What is the value of the whatsThis variable?]
 - [ ] 2.2
 - [ ] 2.0
 - [ ] Nothing. The Single() call would throw an Exception.
 - [x] 2.3
