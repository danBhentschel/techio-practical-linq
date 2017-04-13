using System;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Background1
{
    [TestClass]
    public class UnitTest
    {
        [TestMethod]
        public void Exercise1()
        {
            CgMessage("About to test DoTransform(new List<int> { 10, 20, 30 }, x => x / 10)");
            var enumerable = BackgroundReviewExercise1.DoTransform(new List<int> { 10, 20, 30 }, x => x / 10);
            var answer = string.Join(" ", enumerable);
            AssertAreEqual("1 2 3", answer, "{ 10, 20, 30 } -- x / 3");

            CgMessage(string.Empty);
            CgMessage("About to test DoTransform(new List<int> { 7, 11, 15, 19 }, x => x - 7)");
            enumerable = BackgroundReviewExercise1.DoTransform(new List<int> { 7, 11, 15, 19 }, x => x - 7);
            answer = string.Join(" ", enumerable);
            AssertAreEqual("0 4 8 12", answer, "{ 7, 11, 15, 19 } -- x - 7");

            CgMessage(string.Empty);
            CgMessage("About to test DoTransform(new List<int> { 1, 1, 1, 2, 2, 2 }, x => 20)");
            enumerable = BackgroundReviewExercise1.DoTransform(new List<int> { 1, 1, 1, 2, 2, 2 }, x => 20);
            answer = string.Join(" ", enumerable);
            AssertAreEqual("20 20 20 20 20 20", answer, "{ 1, 1, 1, 2, 2, 2 } -- 20");

            CgMessage(string.Empty);
            CgMessage("About to test new List<int> { 1, 2, 3 }.Transform(x => x * 2)");
            enumerable = new List<int> { 1, 2, 3 }.Transform(x => x * 2);
            answer = string.Join(" ", enumerable);
            AssertAreEqual("2 4 6", answer, "{ 1, 2, 3 } -- x * 2");

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
