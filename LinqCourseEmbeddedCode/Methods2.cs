using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using System.Linq;
using System.Diagnostics;

namespace LinqCourseEmbeddedCode
{
    [TestClass]
    public class Methods2
    {
        [TestMethod]
        public void TestMethod1()
        {
            //// START EMBED: Take() ////
            List<bool> bools = new List<bool> { true, false, true, true, false };
            // Will contain { true, false, true }
            IEnumerable<bool> result = bools.Take(3);
            //// END EMBED ////
            Assert.IsTrue(result.SequenceEqual(new List<bool> { true, false, true }));
        }

        [TestMethod]
        public void TestMethod2()
        {
            //// START EMBED: Skip() ////
            List<bool> bools = new List<bool> { true, false, true, true, false };
            // Will contain { true, true, false }
            IEnumerable<bool> result = bools.Skip(2);
            //// END EMBED ////
            Assert.IsTrue(result.SequenceEqual(new List<bool> { true, true, false }));
        }

        [TestMethod]
        public void TestMethod3()
        {
            //// START EMBED: TakeWhile() ////
            List<int> ints = new List<int> { 1, 2, 4, 8, 4, 2, 1 };
            // Will contain { 1, 2, 4 }
            IEnumerable<int> result = ints.TakeWhile(theInt => theInt < 5);
            //// END EMBED ////
            Assert.IsTrue(result.SequenceEqual(new List<int> { 1, 2, 4 }));
        }

        [TestMethod]
        public void TestMethod4()
        {
            //// START EMBED: SkipWhile() ////
            List<int> ints = new List<int> { 1, 2, 4, 8, 4, 2, 1 };
            // Will contain { 4, 8, 4, 2, 1 }
            IEnumerable<int> result = ints.SkipWhile(theInt => theInt != 4);
            //// END EMBED ////
            Assert.IsTrue(result.SequenceEqual(new List<int> { 4, 8, 4, 2, 1 }));
        }

        [TestMethod]
        public void TestMethod5()
        {
            //// START EMBED: Distinct() ////
            List<int> ints = new List<int> { 1, 2, 4, 8, 4, 2, 1 };
            // Will contain { 1, 2, 4, 8 }
            IEnumerable<int> result = ints.Distinct();
            //// END EMBED ////
            Assert.IsTrue(result.SequenceEqual(new List<int> { 1, 2, 4, 8 }));
        }

        [TestMethod]
        public void TestMethod6()
        {
            //// START EMBED: Intersect() ////
            List<int> ints = new List<int> { 1, 2, 4, 8, 4, 2, 1 };
            List<int> filter = new List<int> { 1, 1, 2, 3, 5, 8 };
            // Will contain { 1, 2, 8 }
            IEnumerable<int> result = ints.Intersect(filter);
            //// END EMBED ////
            Debug.WriteLine(string.Join(" ", result));
            Assert.IsTrue(result.SequenceEqual(new List<int> { 1, 2, 8 }));
        }

        [TestMethod]
        public void TestMethod7()
        {
            //// START EMBED: Where() ////
            List<int> ints = new List<int> { 1, 2, 4, 8, 4, 2, 1 };
            // Will contain { 2, 4, 4, 2 }
            IEnumerable<int> result = ints.Where(theInt => Math.Abs(theInt - 3) == 1);
            //// END EMBED ////
            Debug.WriteLine(string.Join(" ", result));
            Assert.IsTrue(result.SequenceEqual(new List<int> { 2, 4, 4, 2 }));
        }
    }
}
