using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
//// START EMBED: Call extension method ////
using IntExtensions;

//// START ELIDE ////

namespace LinqCourseEmbeddedCode
{
    [TestClass]
    public class ExtensionMethods1
    {
        [TestMethod]
        public void TestMethod1()
        {
    //// END ELIDE ////

    // Prints "Grrrrrrr" to the console
    Console.WriteLine(7.Growl());
    //// END EMBED ////
        }
    }
}
