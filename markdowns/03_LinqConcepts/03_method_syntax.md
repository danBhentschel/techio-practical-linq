[//]: # (GENERATED FILE -- DO NOT EDIT)
# LINQ Concepts: Method syntax
The other LINQ format is method syntax. LINQ method syntax can do everything that query syntax can do, and more. It's just a different way to format the instructions.

## Method syntax example
Recall this example of query syntax from the previous lesson:

```csharp
List<string> animalNames = new List<string>
    {"fawn", "gibbon", "heron", "ibex", "jackalope"};
    
// Result: {"heron", "gibbon", "jackalope"}
IEnumerable<string> longAnimalNames =
    from name in animalNames
    where name.Length >= 5
    orderby name.Length
    select name;
```

This exact same instruction set can be written using method syntax like this:

```csharp
List<string> animalNames = new List<string>
    {"fawn", "gibbon", "heron", "ibex", "jackalope"};

IEnumerable<string> longAnimalNames =
    animalNames
    .Where(name => name.Length >= 5)
    .OrderBy(name => name.Length);
```

> **NOTE:** The spaces, tabs, and linebreaks in these examples are just whitespace, used for formatting, and are not syntactically important.

## Advantages of method syntax

I, personally, prefer method syntax over query syntax, and this is the format that will be used for the rest of this course. Here are some of the advantages of method syntax:

 - All query syntax is automatically converted to method syntax at compilation time
 - Not all LINQ methods can be utilized with query syntax
 - Method syntax is stylistically more similar to other C# code

# Method syntax exercise

This is the exact same exercise as in the previous lesson. Now try to write it with method syntax.

The following code shows a LINQ query that returns the input `inValues` unmodified. Using the format of the above example, see if you can return only the strings that have `pattern` in them (using the [`String.Contains()`](https://msdn.microsoft.com/en-us/library/dy85x1sa%28v=vs.110%29.aspx) method) and order the list alphabetically.

@[Method Syntax Exercise]({"stubs": ["MethodSyntax1/MethodSyntax1.cs"], "command": "MethodSyntax1.UnitTest.Exercise1", "project": "exercises"})
