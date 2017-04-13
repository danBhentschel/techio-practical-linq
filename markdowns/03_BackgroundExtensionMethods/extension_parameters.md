[//]: # (GENERATED FILE -- DO NOT EDIT)
# Background: Parameters to extension methods

An extension method can take extra parameters, in addition to an instance of the type that it is extending. Here is an example of that:

```csharp
namespace IntExtensions
{
    public static class CoolExtensionsForInt
    {
        public static string Growl(this int num, char a, char b)
        {
            return $"{a}{new string(b, num)}";
        }
    }
}
```

What does this do? Let's call it a few times and find out:

```csharp
using IntExtensions;

  ...

    // Prints "Grrrrrrr" to the console
    Console.WriteLine(7.Growl('G', 'r'));

    // Prints "Brrr" to the console
    Console.WriteLine(3.Growl('B', 'r'));

    // Prints "Shhhh" to the console
    Console.WriteLine(4.Growl('S', 'h'));
```
