# Background: Extension Methods

Extension methods in C# allow the addition of new methods to a pre-existing type, without modifying the original source code for that type. This can be very useful for adding functionality to classes or interfaces found in a third-party library, or even in the .NET Framework libraries.

### Why learn about extension methods?
All LINQ methods are extension methods, defined in the `System.Linq` namespace.

### Example extension method

Here is what an extension method declaration looks like:
```csharp
//// EMBED: LinqCourseEmbeddedCode/CoolExtensionsForInt.cs, Example extension method declaration
```

The name of the class isn't important, nor is the name of the method. The important elements are:
 - The class and method must both be `static`
 - The first parameter to the method must be of the type that is being extended
 - The first parameter to the method must be prefaced with the keyword `this`

### Calling an extension method

The above extension method can be called as if it were a member of the `int` type. For example:

```csharp
//// EMBED: LinqCourseEmbeddedCode/ExtensionMethods1.cs, Call extension method
```

Notice that, since the extension method is defined in the `IntExtensions` namespace, that namespace must be included with a `using` directive.
