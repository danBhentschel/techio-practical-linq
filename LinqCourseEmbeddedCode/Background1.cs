using System;
using System.Collections;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using System.Linq;

namespace LinqCourseEmbeddedCode
{
    [TestClass]
    public class Background1
    {
        [TestMethod]
        public void TestMethod1()
        {
            //// START EMBED: Lambda 1 ////
            Func<int, int> multiplyByFive = num => num * 5;
            // Returns 35
            int result = multiplyByFive(7);
            //// END EMBED ////
            Assert.AreEqual(35, result);
        }

        [TestMethod]
        public void TestMethod2()
        {
            //// START EMBED: Lambda 1 ////
            Func<int, int, int> multiplyTwoNumbers = (a, b) => a * b;
            // Returns 35
            int result = multiplyTwoNumbers(7, 5);
            //// END EMBED ////
            Assert.AreEqual(35, result);
        }

        [TestMethod]
        public void TestMethod3()
        {
            //// START EMBED: Lambda 3 ////
            Func<int, int> multiplyByFive = num =>
            {
                int product = num * 5;
                return product;
            };
            // Returns 35
            int result = multiplyByFive(7);
            //// END EMBED ////
            Assert.AreEqual(35, result);
        }

        [TestMethod]
        public void TestMethod4()
        {
            //// START EMBED: IEnumerable<T> examples ////
            IEnumerable<int> list = new List<int> { 1, 2, 3 };
            IEnumerable<int> array = new[] { 1, 2, 3 };
            IEnumerable<int> set = new SortedSet<int> { 1, 2, 3 };
            //// END EMBED ////
            Assert.IsTrue(list.SequenceEqual(array));
            Assert.IsTrue(list.SequenceEqual(set));
        }

        [TestMethod]
        public void TestMethod5()
        {
            //// START EMBED: ToList() and ToArray() ////
            List<int> list = new[] {1, 2, 3}.ToList();
            int[] array = new List<int> {1, 2, 3}.ToArray();
            List<int> list2 = new SortedSet<int> {1, 2, 3}.ToList();
            //// END EMBED ////
            Assert.IsTrue(list.SequenceEqual(array));
            Assert.IsTrue(list.SequenceEqual(list2));
        }
    }
}
