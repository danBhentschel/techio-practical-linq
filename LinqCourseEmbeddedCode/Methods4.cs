using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using System.Linq;

namespace LinqCourseEmbeddedCode
{
    [TestClass]
    public class Methods4
    {
        [TestMethod]
        public void TestMethod1()
        {
            //// START EMBED: Count() ////
            IEnumerable<string> strings = new List<string> { "first", "then", "and then", "finally" };
            // Will return 4
            int result = strings.Count();
            //// END EMBED ////
            Assert.AreEqual(result, 4);
        }

        [TestMethod]
        public void TestMethod2()
        {
            //// START EMBED: Count() condition ////
            IEnumerable<string> strings = new List<string> { "first", "then", "and then", "finally" };
            // Will return 2
            int result = strings.Count(str => str.Contains("then"));
            //// END EMBED ////
            Assert.AreEqual(result, 2);
        }

        [TestMethod]
        public void TestMethod3()
        {
            //// START EMBED: Sum() ////
            IEnumerable<int> ints = new List<int> { 2, 2, 4, 6 };
            // Will return 14
            int result = ints.Sum();
            //// END EMBED ////
            Assert.AreEqual(result, 14);
        }

        [TestMethod]
        public void TestMethod4()
        {
            //// START EMBED: Sum() selector ////
            IEnumerable<int> ints = new List<int> { 2, 2, 4, 6 };
            // Will return 60
            int result = ints.Sum(val => val * val);
            //// END EMBED ////
            Assert.AreEqual(result, 60);
        }

        [TestMethod]
        public void TestMethod5()
        {
            //// START EMBED: Sum() question 1 ////
            IEnumerable<string> strings = new List<string> { "a", "ab", "abc" };
            var result = strings.Sum(str => 2.3F);
            //// END EMBED ////
            Assert.AreEqual(typeof(float), result.GetType());
        }

        [TestMethod]
        public void TestMethod6()
        {
            //// START EMBED: Sum() question 2 ////
            IEnumerable<string> strings = new List<string> { "a", "ab", "abc" };
            var result = strings.Sum(str => str.Length);
            //// END EMBED ////
            Assert.AreEqual(typeof(int), result.GetType());
        }

        [TestMethod]
        public void TestMethod7()
        {
            //// START EMBED: Max() ////
            IEnumerable<int> ints = new List<int> { 2, 2, 4, 6, 3, 6, 5 };
            // Will return 6
            int result = ints.Max();
            //// END EMBED ////
            Assert.AreEqual(6, result);
        }

        [TestMethod]
        public void TestMethod8()
        {
            //// START EMBED: Min() selector ////
            IEnumerable<string> strings = new List<string> { "1.2", "1.3", "1.5", "0.6" };
            // Will return 0.6
            float result = strings.Min(str => float.Parse(str));
            //// END EMBED ////
            Assert.AreEqual(0.6F, result);
        }

        [TestMethod]
        public void TestMethod9()
        {
            //// START EMBED: Any() ////
            IEnumerable<double> doubles = new List<double> { 1.2, 1.7, 2.5, 2.4 };
            // Will return false
            bool result = doubles.Any(val => val < 1);
            //// END EMBED ////
            Assert.IsFalse(result);
        }

        [TestMethod]
        public void TestMethod10()
        {
            //// START EMBED: All() ////
            IEnumerable<string> strings = new List<string> { "one", "three", "five" };
            // Will return true
            bool result = strings.All(str => str.Contains("e"));
            //// END EMBED ////
            Assert.IsTrue(result);
        }

        [TestMethod]
        public void TestMethod11()
        {
            //// START EMBED: Any() All() question ////
            string result = "none";
            IEnumerable<string> strings = new List<string> { "four", "one", "two", "three", "five" };
            if (strings.Take(3).Any(s => s.StartsWith("a")))
            {
                if (strings.Skip(1).Take(2).All(s => s.Length == 3))
                {
                    result = "red";
                }
                else
                {
                    result = "orange";
                }
            }
            else
            {
                if (strings.All(s => s.Length > 2))
                {
                    if (strings.OrderBy(s => s).Take(3).Any(s => s == "one"))
                    {
                        result = "yellow";
                    }
                    else
                    {
                        result = "green";
                    }
                }
                else
                {
                    result = "blue";
                }
            }
            //// END EMBED ////
            Assert.AreEqual("yellow", result);
        }

        [TestMethod]
        public void TestMethod12()
        {
            //// START EMBED: Aggregate() -> Sum() ////
            IEnumerable<int> ints = new List<int> { 2, 4, 1, 6 };
            // Reimplementation of the Sum() method utilizing Aggregate()
            // Will return 13
            int result = ints.Aggregate((sum, val) => sum + val);
            //// END EMBED ////
            Assert.AreEqual(13, result);
        }

        [TestMethod]
        public void TestMethod13()
        {
            //// START EMBED: Aggregate() -> concat ////
            IEnumerable<string> strings = new List<string> { "a", "ab", "abc", "abcd", "z" };
            // Will return "a&ab&abc&abcd&z"
            string result = strings.Aggregate((concat, str) => $"{concat}&{str}");
            //// END EMBED ////
            Assert.AreEqual("a&ab&abc&abcd&z", result);
        }

        [TestMethod]
        public void TestMethod14()
        {
            //// START EMBED: Aggregate() -> Count() ////
            IEnumerable<string> strings = new List<string> { "a", "ab", "abc", "abcd" };
            // Reimplementation of the Count() method utilizing Aggregate()
            // Will return 4
            int result = strings.Aggregate(0, (count, val) => count + 1);
            //// END EMBED ////
            Assert.AreEqual(4, result);
        }

        [TestMethod]
        public void TestMethod15()
        {
            //// START EMBED: Aggregate() -> Any() ////
            IEnumerable<string> strings = new List<string> { "a", "ab", "abc", "abcd" };
            // Reimplementation of Any(str => str.Length > 3) utilizing Aggregate()
            // Will return true
            bool result = strings.Aggregate(false, (any, val) => any || (val.Length > 3));
            //// END EMBED ////
            Assert.IsTrue(result);
        }

        [TestMethod]
        public void TestMethod16()
        {
            //// START EMBED: SequenceEqual() ////
            // returns true
            bool isEqual1 = new[] { 1, 2, 3 }.SequenceEqual(new List<int> { 1, 2, 3 });

            // returns false
            bool isEqual2 = new List<int> { 1, 2, 3, 4 }.SequenceEqual(new[] { 1, 2, 3 });

            // returns true
            bool isEqual3 = new List<int> { 1, 2, 3, 4 }.Take(3).SequenceEqual(new[] { 1, 2, 3 });

            // returns false
            bool isEqual4 = new[] { 2, 1, 2 }.SequenceEqual(new[] { 1, 1, 2 });

            // returns true
            bool isEqual5 = new[] { 2, 1, 2 }.Skip(1).SequenceEqual(new[] { 1, 1, 2 }.Skip(1));
            //// END EMBED ////
            Assert.IsTrue(isEqual1);
            Assert.IsFalse(isEqual2);
            Assert.IsTrue(isEqual3);
            Assert.IsFalse(isEqual4);
            Assert.IsTrue(isEqual5);

            // quiz
            // no compile: new[] {2}.SequenceEqual(2);
            Assert.IsTrue(new SortedSet<int> { 1, 2, 4 }.SequenceEqual(new[] { 1, 2, 4 }));
            Assert.IsFalse(new[] { 2, 5, 2 }.SequenceEqual(new[] { 2, 5, 2, 2 }));
            Assert.IsFalse(new[] { 1, 1, 1 }.SequenceEqual(new[] { 1, 1 }));
            // no compile: new[] { "1", "2", "3"}.SequenceEqual(new[] { 1, 2, 3});
            Assert.IsTrue(new List<string> { "a", "b", "abc" }.SequenceEqual(new[] { "a", "b", "abc" }));
            Assert.IsTrue(new List<string> { "a", "b", "abc" }.SequenceEqual(new[] { "a", "b", "abc" }));
            // no compile: new[] {1, 2}.SequenceEqual(new[] {1.0, 2.0});
        }
    }
}
