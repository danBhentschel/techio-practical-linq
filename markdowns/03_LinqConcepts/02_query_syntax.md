[//]: # (GENERATED FILE -- DO NOT EDIT)
# LINQ Concepts - Query syntax

There are two different syntax paradigms for accessing LINQ functionality: **query syntax** and **method syntax**.

Query syntax has a very distinctive syntactical style. Due to its unique format, query syntax is very memorable and somewhat iconic as it's often what people envision when thinking of LINQ. Here is an example of LINQ code using query syntax:

## Query syntax example
```csharp
using System.Linq;

   ...

List<string> animalNames = new List<string>
    {"fawn", "gibbon", "heron", "ibex", "jackalope"};
    
// Result: {"heron", "gibbon", "jackalope"}
IEnumerable<string> longAnimalNames =
    from name in animalNames
    where name.Length >= 5
    orderby name.Length
    select name;
```

For those who are familiar with SQL syntax, you might find some similarities in this example. It's not exactly the same as SQL though. This example gathers all the strings in `animalNames` that are at least 5 characters in length, ordered from the entry with the fewest characters to the entry with the most characters.

> **NOTE:** The above example includes `using System.Linq;`. This is **essential** when using LINQ. Both query syntax and method syntax require it. Although I will not include it in all examples, it is always implied.

## Advantages of query syntax

 - The [MSDN documentation](https://msdn.microsoft.com/en-us/library/bb397947.aspx) claims that "*many people find query syntax simpler and easier to read*."
 - Query syntax can be more compact since the variables created have a scope that spans the whole statement, vs. method syntax where variables need to be re-declared for each method call.


## Insane query syntax example
Here is an example of the expressiveness of LINQ query syntax:

[Taking LINQ to Objects to Extremes: A fully LINQified RayTracer](https://blogs.msdn.microsoft.com/lukeh/2007/10/01/taking-linq-to-objects-to-extremes-a-fully-linqified-raytracer/)

Try to decipher that, I challenge you!

# Query syntax exercise

Now you try it out. The following code shows a LINQ query that returns the input `inValues` unmodified. Using the format of the example above, see if you can return only the strings that have `pattern` in them (using the [`String.Contains()`](https://msdn.microsoft.com/en-us/library/dy85x1sa%28v=vs.110%29.aspx) method) and order the list alphabetically.

@[Query Syntax Exercise]({"stubs": ["QuerySyntax1/QuerySyntax1.cs"], "command": "QuerySyntax1.UnitTest.Exercise1", "project": "exercises"})
