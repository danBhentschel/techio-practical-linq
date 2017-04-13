[//]: # (GENERATED FILE -- DO NOT EDIT)
# LINQ Concepts: Query syntax

There are two different syntax paradigms for accessing LINQ functionality. They are the **query syntax** and the **method syntax**.

Query syntax has a very distinctive syntactical style. Because of its unique format, query syntax is very memorable, and somewhat iconic in that it is often what people envision when thinking of LINQ. Here is an example of LINQ code using query syntax:

### Query syntax example
```csharp
using System.Linq;
  ...
    List<string> animalNames = new List<string>
        {"fawn", "gibbon", "heron", "ibex", "jackalope"};

    IEnumerable<string> longAnimalNames =
        from name in animalNames
        where name.Length > 5
        orderby name.Length
        select name;
```

For those who are familiar with SQL syntax, you might find some similarities in this example. It's not exactly the same as SQL, though. This example returns all the strings in `animalNames` that are at least 6 characters in length, ordered from the entry with the fewest characters to the entry with the most characters.

The [MSDN documentation](https://msdn.microsoft.com/en-us/library/bb397947.aspx) claims that "*many people find query syntax simpler and easier to read*." I, on the other hand, consider it to be obscure and jarring.

> **NOTE:** The above example includes a `using System.Linq;` line. This is **essential** when using LINQ. Both query syntax and method syntax require it. I will not include it in all examples, but it is always implied.

### Insane query syntax example
Here is an example of the expressiveness of LINQ query syntax:

[Taking LINQ to Objects to Extremes: A fully LINQified RayTracer](https://blogs.msdn.microsoft.com/lukeh/2007/10/01/taking-linq-to-objects-to-extremes-a-fully-linqified-raytracer/)

Try to decipher that! I challenge you!

### Query syntax exercise
Now you try it out. The following code shows a LINQ query that returns the input `inValues` unmodified. Using the format of the above example, see if you can return only the strings that have `pattern` in them (using the `.Contains()` method of `string`) and order the list alphabetically.

@[Query Syntax Exercise]({"stubs": ["QuerySyntax1/QuerySyntax1.cs"], "command": "QuerySyntax1.UnitTest.Exercise1", "project": "exercises"})