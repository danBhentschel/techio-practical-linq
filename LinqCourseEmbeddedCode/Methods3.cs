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
            // Will contain { "then", "first", "finally", "and then" }
            IEnumerable<string> result = strings.OrderBy(str => str.Length);
            //// END EMBED ////
            Assert.IsTrue(result.SequenceEqual(new List<string> { "then", "first", "finally", "and then" }));
        }

        [TestMethod]
        public void TestMethod3()
        {
            //// START EMBED: OrderBy() 2 ////
            List<string> strings = new List<string> { "first", "then", "and then", "finally" };
            // Will contain { "and then", "then", "finally", "first" }
            IEnumerable<string> result = strings.OrderBy(str => str[2]);
            //// END EMBED ////
            Assert.IsTrue(result.SequenceEqual(new List<string> { "and then", "then", "finally", "first" }));
        }

        [TestMethod]
        public void TestMethod4()
        {
            //// START EMBED: OrderBy() 3 ////
            List<string> strings = new List<string> { "first", "then", "and then", "finally" };
            // Will contain { "then", "and then", "first", "finally" }
            IEnumerable<string> result = strings.OrderBy(ReverseCharactersInString);
            //// END EMBED ////
            Assert.IsTrue(result.SequenceEqual(new List<string> { "then", "and then", "first", "finally" }));
        }

        private static string ReverseCharactersInString(string str)
        {
            return new string(str.Reverse().ToArray());
        }

        [TestMethod]
        public void TestMethod5()
        {
            //// START EMBED: OrderBy() identity ////
            List<string> strings = new List<string> { "first", "then", "and then", "finally" };
            // Will contain { "and then", "finally", "first", "then" }
            IEnumerable<string> result = strings.OrderBy(str => str);
            //// END EMBED ////
            Assert.IsTrue(result.SequenceEqual(new List<string> { "and then", "finally", "first", "then" }));
        }
    }
}
