using System;
using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Generators1
{
    [TestClass]
    public class UnitTest
    {
        [TestMethod]
        public void Exercise1()
        {
            CgMessage("About to test AddTwoThenDouble().Take(10)");
            var answer = string.Join(" ", GeneratorsExercise1.AddTwoThenDouble().Take(10));
            AssertAreEqual("2 4 6 12 14 28 30 60 62 124", answer, "First 10 values");

            CgMessage(string.Empty);
            CgMessage("About to test AddTwoThenDouble().Skip(13).Take(4)");
            answer = string.Join(" ", GeneratorsExercise1.AddTwoThenDouble().Skip(13).Take(4));
            AssertAreEqual("508 510 1020 1022", answer, "Values 14 - 17");

            CgMessage(string.Empty);
            CgMessage("About to test AddTwoThenDouble().Skip(28).First()");
            answer = GeneratorsExercise1.AddTwoThenDouble().Skip(28).First().ToString();
            AssertAreEqual("65534", answer, "28th value");

            CgMessage(string.Empty);
            CgMessage("Congratulations, you did it!");
        }

        private static void CgMessage(string message)
        {
            Console.WriteLine($"CG> message -channel \"exercise results\" \"{message}\"");
        }

        private static void AssertAreEqual(string expected, string actual, string provided)
        {
            if (expected != actual)
            {
                PrintDifference(expected, actual);
            }

            Assert.AreEqual(expected, actual);
            CgMessage($"IN: <{provided}> OUT: <{actual}>");
        }

        private static void PrintDifference(string expected, string actual)
        {
            int offset = GetDiffOffest(expected, actual);
            var errCaret = new string(' ', offset) + '^' +
                           new string(' ', expected.Length - offset - 1);
            CgMessage($"EXPECTED: <{expected}>  GOT: <{actual}>");
            CgMessage($"           {errCaret}         {errCaret}");
        }

        private static int GetDiffOffest(string expected, string actual)
        {
            for (var i = 0; i < expected.Length; i++)
            {
                if (expected[i] != actual[i])
                {
                    return i;
                }
            }

            return 0;
        }
    }
}
