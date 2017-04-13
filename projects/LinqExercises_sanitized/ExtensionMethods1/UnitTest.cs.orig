using System;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace ExtensionMethods1
{
    [TestClass]
    public class UnitTest
    {
        [TestMethod]
        public void Exercise1()
        {
            CgMessage("About to test DoSayHello(\"World\")");
            var answer = ExtensionMethodsExercise1.DoSayHello("World");
            AssertAreEqual("Hello, World!", answer, "World");
            CgMessage("About to test DoSayHello(\"Dolly\")");
            answer = ExtensionMethodsExercise1.DoSayHello("Dolly");
            AssertAreEqual("Hello, Dolly!", answer, "Dolly");
            CgMessage("About to test DoSayHello(\"Nurse\")");
            answer = ExtensionMethodsExercise1.DoSayHello("Nurse");
            AssertAreEqual("Hello, Nurse!", answer, "Nurse");

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
