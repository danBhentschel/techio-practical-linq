using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using System.Linq;

namespace LinqCourseEmbeddedCode
{
    public struct Point
    {
        public int X { get; }
        public int Y { get; }

        public Point(int x, int y)
        {
            X = x;
            Y = y;
        }
    }

    [TestClass]
    public class Methods5
    {
        [TestMethod]
        public void TestMethod1()
        {
            //// START EMBED: Cast() good ////
            IEnumerable<IComparable> values = new List<IComparable> { 2, 3, 4 };
            // Will return { 2, 3, 4 }
            // The elements in the collection are the same,
            // but the collection type is different
            IEnumerable<int> result = values.Cast<int>();
            //// END EMBED ////
            Assert.IsTrue(result.SequenceEqual(new List<int> { 2, 3, 4 }));
        }

        [TestMethod]
        [ExpectedException(typeof(InvalidCastException))]
        public void TestMethod2()
        {
            //// START EMBED: Cast() bad ////
            IEnumerable<string> strings = new List<string> { "one", "two", "three" };
            // Will throw InvalidCastException
            IEnumerable<int> result = strings.Cast<int>();
            Console.WriteLine(result.First());
            //// END EMBED ////
        }

        [TestMethod]
        public void TestMethod3()
        {
            //// START EMBED: Select() 1 ////
            IEnumerable<string> strings = new List<string> { "one", "two", "three", "four" };
            // Will return { 3, 3, 5, 4 }
            IEnumerable<int> result = strings.Select(str => str.Length);
            //// END EMBED ////
            Assert.IsTrue(result.SequenceEqual(new List<int> { 3, 3, 5, 4 }));
        }

        [TestMethod]
        public void TestMethod4()
        {
            //// START EMBED: Select() 2 ////
            IEnumerable<Point> points = new List<Point>
            {
                new Point(0, 0),
                new Point(1, 1),
                new Point(2, 0)
            };
            // Will return { "(0, 0)", "(1, 1)", "(2, 0)" }
            IEnumerable<string> result = points.Select(pt => $"({pt.X}, {pt.Y})");
            //// END EMBED ////
            Assert.IsTrue(result.SequenceEqual(new List<string> { "(0, 0)", "(1, 1)", "(2, 0)" }));
        }
    }
}
