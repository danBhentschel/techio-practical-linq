using System;
using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Generators2
{
    [TestClass]
    public class UnitTest
    {
        [TestMethod]
        public void Exercise2()
        {
            CgMessage("About to test: AddTwoThenDouble(10)");
            var enumerable = GeneratorsExercise2.AddTwoThenDouble(10);
            var answer = enumerable.Count().ToString();
            AssertAreEqual("10", answer, "10 values");
            answer = string.Join(" ", enumerable);
            AssertAreEqual("2 4 6 12 14 28 30 60 62 124", answer, "First 10 values");

            CgMessage(string.Empty);
            CgMessage("About to test: AddTwoThenDouble(17).Count()");
            enumerable = GeneratorsExercise2.AddTwoThenDouble(17);
            answer = enumerable.Count().ToString();
            AssertAreEqual("17", answer, "17 values");

            CgMessage(string.Empty);
            CgMessage("About to test: AddTwoThenDouble(17).Skip(13)");
            answer = string.Join(" ", enumerable.Skip(13));
            AssertAreEqual("508 510 1020 1022", answer, "Values 14 - 17");

            CgMessage(string.Empty);
            CgMessage("About to test: AddTwoThenDouble(30).Count()");
            answer = GeneratorsExercise2.AddTwoThenDouble(30).Count().ToString();
            AssertAreEqual("30", answer, "30 values");

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
