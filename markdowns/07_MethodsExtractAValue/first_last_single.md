[//]: # (GENERATED FILE -- DO NOT EDIT)
# Methods: First(), Last(), ElementAt(), and Single()

These LINQ methods can be used to extract a single value from an `IEnumerable<T>` sequence. 

> **NOTE:** All four of the methods in this lesson throw an exception if they can't find an appropriate value to return. Only use them if you are absolutely certain that a value exists for them to return. You could `catch` the exception (and probably should to handle true error conditions) but if you expect that these may reasonably fail, you should use the `OrDefault` variants instead. We will go over those methods in a later lesson.

### First()

Intuitively enough, this extracts the first value in the sequence. The type of value returned depends on the type of `T` in the `IEnumerable<T>` that the method is invoked on. If it is a sequence of `int`, then `First()` will return an `int`.

For example:

```csharp
List<double> doubles = new List<double> { 2.0, 2.1, 2.2, 2.3 };
double twoPointOh = doubles.First();
```

### Last()
Hmm.... What do you think this code might return?

```csharp
List<double> doubles = new List<double> { 2.0, 2.1, 2.2, 2.3 };
double whatsThis = doubles.Last();
```

?[What is the value of the whatsThis variable?]
 - [ ] 2.2
 - [ ] 2.0
 - [ ] Nothing. The `Last()` call will throw an Exception.
 - [x] 2.3

### ElementAt()
Try this one:

```csharp
List<double> doubles = new List<double> { 2.0, 2.1, 2.2, 2.3 };
double whatsThis = doubles.ElementAt(2);
```

?[What is the value of the whatsThis variable?]
 - [x] 2.2
 - [ ] 2.0
 - [ ] Nothing. The `ElementAt()` call will throw an Exception.
 - [ ] 2.3

### Single()
`Single()` is an interesting method. You call it when you are expecting that there is only a single element in the sequence. If there is more than one element, then `Single()` will throw an exception.

With this in mind, what do you think this will do?

```csharp
List<double> doubles = new List<double> { 2.0, 2.1, 2.2, 2.3 };
double whatsThis = doubles.Single();
```

?[What is the value of the whatsThis variable?]
 - [ ] 2.2
 - [ ] 2.0
 - [x] Nothing. The `Single()` call will throw an Exception.
 - [ ] 2.3