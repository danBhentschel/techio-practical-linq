# Background Topics - IEnumerable&lt;T&gt;

The `IEnumerable<T>` interface is central to LINQ. All LINQ methods are extension methods to the `IEnumerable<T>` interface. That means that you can call **any** LINQ method on **any** object that implements `IEnumerable<T>`. You can even create your own classes that implement `IEnumerable<T>`, and those classes will instantly "inherit" all LINQ functionality!

Pretty cool huh?

## What is IEnumerable&lt;T&gt;?
`IEnumerable<T>` is an interface that guarantees a given class is **iterable**. That's a technical term indicating a class that implements `IEnumerable<T>` can be thought of and used as a sequence of elements.

## What classes implement IEnumerable&lt;T&gt;?
Most C# **collections** and all C# **arrays** implement `IEnumerable<T>`. Here are some examples:

```csharp
//// EMBED: LinqCourseEmbeddedCode/Background1.cs, IEnumerable<T> examples
```

## What's the &lt;T&gt;?
A `<T>` after an interface name indicates that the interface is **generic**. This means that it can be used with any data type, and the `T` is a placeholder for that data type. In the case of `IEnumerable<T>`, the `T` represents the data type of the elements within the sequence.

An `IEnumerable<int>` contains a sequence of `int`s. An `IEnumerable<string>` contains a sequence of `string`s. An `IEnumerable<object>` contains (God help us) a sequence of `object`s, meaning it can hold, quite literally, anything.
