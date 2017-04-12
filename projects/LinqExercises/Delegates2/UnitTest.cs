using System;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Delegates2
{
    [TestClass]
    public class UnitTest
    {
        public static List<string> Answers;

        [TestMethod]
        public void Exercise2()
        {
            Answers = null;

            DelegatesExercise2.DoSayHello();

            if (Answers == null)
            {
                CgMessage("You need to call Exercise.TestSayHello()");
            }
            Assert.IsNotNull(Answers);
            AssertAreEqual("Hello, World!", Answers[0], "World");
            AssertAreEqual("Hello, Dolly!", Answers[1], "Dolly");
            AssertAreEqual("Hello, there!", Answers[2], "there");

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
