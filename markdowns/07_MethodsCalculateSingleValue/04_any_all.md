[//]: # (GENERATED FILE -- DO NOT EDIT)
# Methods: Calculating a single value

### [Any(&lt;condition&gt;)](https://msdn.microsoft.com/en-us/library/bb534972%28v=vs.110%29.aspx) method
Returns `true` if _at least one of the elements_ in the source sequence meets the provided **condition**. Otherwise it returns `false`.

```csharp
IEnumerable<double> doubles = new List<double> { 1.2, 1.7, 2.5, 2.4 };
// Will return false
bool result = doubles.Any(val => val < 1);
```

> **NOTE:** `Any()` can also be called [without a condition](https://msdn.microsoft.com/en-us/library/bb337697%28v=vs.110%29.aspx), in which case it will return `true` if there is at least one element in the source sequence.

### [All(&lt;condition&gt;)](https://msdn.microsoft.com/en-us/library/bb548541%28v=vs.110%29.aspx) method
Returns `true` if _every element_ in the source sequence meets the provided **condition**. Otherwise it returns `false`.

```csharp
IEnumerable<string> strings = new List<string> { "one", "three", "five" };
// Will return true
bool result = strings.All(str => str.Contains("e"));
```

### Any() / All() quiz
```csharp
string result = "none";
IEnumerable<string> strings = new List<string> { "four", "one", "two", "three", "five" };
if (strings.Take(3).Any(s => s.StartsWith("a")))
{
    if (strings.Skip(1).Take(2).All(s => s.Length == 3))
    {
        result = "red";
    }
    else
    {
        result = "orange";
    }
}
else
{
    if (strings.All(s => s.Length > 2))
    {
        if (strings.OrderBy(s => s).Take(3).Any(s => s == "one"))
        {
            result = "yellow";
        }
        else
        {
            result = "green";
        }
    }
    else
    {
        result = "blue";
    }
}
```

?[What would be the value of the "result" variable in the code snippet above?]
 - [ ] none
 - [ ] red
 - [ ] orange
 - [x] yellow
 - [ ] green
 - [ ] blue
