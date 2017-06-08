using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using System.Linq;

namespace LinqCourseEmbeddedCode
{
    [TestClass]
    public class AllTogether1
    {
        [TestMethod]
        public void TestMethod1()
        {
            //// START EMBED: All Together ////
            IEnumerable<string> values = new List<string> { "fe", "fi", "fo", "fum" };
            // Will return 12
            int result = values
                .Select(word => $"{word}-{word}") // { "fe-fe", "fi-fi", ... }
                .Skip(2)
                .Select(phrase => phrase.Length)
                .Sum();
            //// END EMBED ////
            Assert.AreEqual(result, 12);
        }
    }
}
