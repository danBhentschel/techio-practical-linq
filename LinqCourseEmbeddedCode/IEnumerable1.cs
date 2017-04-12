using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace LinqCourseEmbeddedCode
{
    [TestClass]
    public class IEnumerable1
    {
        //// START EMBED: Declare method returning IEnumerable ////
        private IEnumerable<int> GetInts()
        {
            return new List<int> { 2, 4, 5, 7 };
        }
        //// END EMBED ////
        
        [TestMethod]
        public void TestMethod1()
        {
            //// START EMBED: Call method returning IEnumerable ////
            // Will print:
            // Value: 2
            // Value: 4
            // Value: 5
            // Value: 7
            foreach (int val in GetInts())
            {
                Console.WriteLine($"Value: {val}");
            }
            //// END EMBED ////
        }

        //// START EMBED: Declare GetFibonacci() generator method ////
        private IEnumerable<int> GetFibonacci()
        {
            int previousVal1 = 0;
            int previousVal2 = 1;

            while (true)
            {
                int nextVal = previousVal1 + previousVal2;
                previousVal1 = previousVal2;
                previousVal2 = nextVal;
                yield return nextVal;
            }
        }
        //// END EMBED ////

        [TestMethod]
        public void TestMethod2()
        {
            //// START EMBED: Call GetFibonacci().Count() ////
            Console.WriteLine(GetFibonacci().Count());
            //// END EMBED ////
        }

        [TestMethod]
        public void TestMethod3()
        {
            //// START EMBED: Iterate GetFibonacci() with a break ////
            // Will print:
            // Value: 1
            // Value: 2
            // Value: 3
            // Value: 5
            // Value: 8
            int i = 0;
            foreach (int val in GetFibonacci())
            {
                if (i > 4) break;
                Console.WriteLine($"Value: {val}");
                i++;
            }
            //// END EMBED ////
        }

        [TestMethod]
        public void TestMethod4()
        {
            //// START EMBED: Try to index into GetFibonacci() ////
            IEnumerable<int> fibonacci = GetFibonacci();
            for (int i = 0; i < 5; i++)
            {
                //// START REPLACE: ".First()" ::: "[i]" ////
                Console.WriteLine($"Value: {fibonacci.First()}");
                //// END REPLACE: ".First()" ////
            }
            //// END EMBED ////
        }

        [TestMethod]
        public void TestMethod5()
        {
            //// START EMBED: Bound GetFibonacci() with Take() ////
            // Will print:
            // Value: 1
            // Value: 2
            // Value: 3
            // Value: 5
            // Value: 8
            foreach (int val in GetFibonacci().Take(5))
            {
                Console.WriteLine($"Value: {val}");
            }
            //// END EMBED ////
        }

        //// START EMBED: Declare GetFibonacciOfLength() generator method ////
        private IEnumerable<int> GetFibonacciOfLength(int length)
        {
            int previousVal1 = 0;
            int previousVal2 = 1;

            for (int i = 0; i < length; i++)
            {
                int nextVal = previousVal1 + previousVal2;
                previousVal1 = previousVal2;
                previousVal2 = nextVal;
                yield return nextVal;
            }
        }
        //// END EMBED ////

        [TestMethod]
        public void TestMethod6()
        {
            //// START EMBED: Iterate GetFibonacciOfLength() ////
            // Will print:
            // Value: 1
            // Value: 2
            // Value: 3
            // Value: 5
            // Value: 8
            foreach (int val in GetFibonacciOfLength(5))
            {
                Console.WriteLine($"Value: {val}");
            }
            //// END EMBED ////
        }

        //// START EMBED: Declare GetFibonacciUpTo() generator method ////
        private IEnumerable<int> GetFibonacciUpTo(int max)
        {
            int previousVal1 = 0;
            int previousVal2 = 1;

            while (true)
            {
                int nextVal = previousVal1 + previousVal2;
                if (nextVal > max) yield break;
                previousVal1 = previousVal2;
                previousVal2 = nextVal;
                yield return nextVal;
            }
        }
        //// END EMBED ////

        [TestMethod]
        public void TestMethod7()
        {
            //// START EMBED: Call GetFibonacciUpTo().Count() ////
            // Prints the number 11, indicating that
            // there are 11 values <= 200:
            // 1, 2, 3, 5, 8, 13, 21, 34, 55, 89, 144

            Console.WriteLine(GetFibonacciUpTo(200).Count());
            //// END EMBED ////
        }

        //// START EMBED: Declare GetDoubles() generator method ////
        public IEnumerable<int> GetDoubles(int n)
        {
            for (int i = 0; i < n; i++)
            {
                yield return i * 2;
            }
        }
        //// END EMBED ////
    }
}
