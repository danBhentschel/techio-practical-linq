using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using System.Linq;
using System.Diagnostics;

namespace LinqCourseEmbeddedCode
{
    [TestClass]
    public class Methods3
    {
        [TestMethod]
        public void TestMethod1()
        {
            //// START EMBED: Reverse() ////
            IEnumerable<string> strings = new List<string> { "first", "then", "and then", "finally" };
            // Will contain { "finally", "and then", "then", "first" }
            IEnumerable<string> result = strings.Reverse();
            //// END EMBED ////
            Assert.IsTrue(result.SequenceEqual(new List<string> { "finally", "and then", "then", "first" }));
        }

        [TestMethod]
        public void TestMethod2()
        {
            //// START EMBED: OrderBy() 1 ////
            List<string> strings = new List<string> { "first", "then", "and then", "finally" };
            // Sort the strings by their length
            // Will contain { "then", "first", "finally", "and then" }
            IEnumerable<string> result = strings.OrderBy(str => str.Length);
            //// END EMBED ////
            Assert.IsTrue(result.SequenceEqual(new List<string> { "then", "first", "finally", "and then" }));
        }

        [TestMethod]
        public void TestMethod3()
        {
            List<string> strings = new List<string> { "first", "then", "and then", "finally" };
            //// START EMBED: OrderBy() 2 ////
            // Sort the strings by the 3rd character
            // Will contain { "and then", "then", "finally", "first" }
            IEnumerable<string> result = strings.OrderBy(str => str[2]);
            //// END EMBED ////
            Assert.IsTrue(result.SequenceEqual(new List<string> { "and then", "then", "finally", "first" }));
        }

        [TestMethod]
        public void TestMethod4()
        {
            List<string> strings = new List<string> { "first", "then", "and then", "finally" };
            //// START EMBED: OrderBy() 3 ////
            // Sort the strings by their reversed characters
            // Will contain { "then", "and then", "first", "finally" }
            IEnumerable<string> result = strings.OrderBy(str => new string(str.Reverse().ToArray()));
            //// END EMBED ////
            Assert.IsTrue(result.SequenceEqual(new List<string> { "then", "and then", "first", "finally" }));
        }

        [TestMethod]
        public void TestMethod5()
        {
            //// START EMBED: OrderBy() identity ////
            List<string> strings = new List<string> { "first", "then", "and then", "finally" };
            // Sort the strings in alphabetical order
            // Will contain { "and then", "finally", "first", "then" }
            IEnumerable<string> result = strings.OrderBy(str => str);
            //// END EMBED ////
            Assert.IsTrue(result.SequenceEqual(new List<string> { "and then", "finally", "first", "then" }));
        }

        [TestMethod]
        public void TestMethod6()
        {
            //// START EMBED: ThenBy() ////
            List<string> strings = new List<string> { "first", "then", "and then", "finally" };
            // Order by the last character, then by the first character
            // Will contain { "and then", "then", "first", "finally" }
            IEnumerable<string> result = strings.OrderBy(str => str.Last()).ThenBy(str => str.First());
            //// END EMBED ////
            Assert.IsTrue(result.SequenceEqual(new List<string> { "and then", "then", "first", "finally" }));
        }
    }
}
