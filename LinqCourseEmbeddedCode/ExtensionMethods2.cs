using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
//// START EMBED: Call extension method with extra parameters ////
using IntExtensions;

//// START ELIDE ////

namespace LinqCourseEmbeddedCode
{
    [TestClass]
    public class ExtensionMethods2
    {
        [TestMethod]
        public void TestMethod1()
        {
    //// END ELIDE ////

    // Prints "Grrrrrrr" to the console
    Console.WriteLine(7.Growl('G', 'r'));

    // Prints "Brrr" to the console
    Console.WriteLine(3.Growl('B', 'r'));

    // Prints "Shhhh" to the console
    Console.WriteLine(4.Growl('S', 'h'));
    //// END EMBED ////
        }
    }
}
