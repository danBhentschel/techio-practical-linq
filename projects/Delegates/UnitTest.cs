using System;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Delegates
{
    [TestClass]
    public class UnitTest
    {
        public static List<string> Answers;
        private static string CgMessage = "CG> message -channel \"exercise results\"";

        [TestMethod]
        public void Exercise1()
        {
            Answers = null;

            Example1.DoSayHello();

            Assert.IsNotNull(Answers, $"\n{CgMessage} You need to call Example1Runner.TestSayHello()");
            AssertAreEqual("Hello, World!", Answers[0], "World");
            AssertAreEqual("Hello, Dolly!", Answers[1], "Dolly");
            AssertAreEqual("Hello, there!", Answers[2], "there");

            Console.WriteLine($"{CgMessage} \"\"");
            Console.WriteLine($"{CgMessage> Congratulations, you did it!");
        }

        private static void AssertAreEqual(string expected, string actual, string provided)
        {
            Assert.AreEqual(expected, actual, $"\n{CgMessage} EXPECTED: <{expected}>  GOT: <{actual}>");
            Console.WriteLine($"{CgMessage} IN: <{provided}> OUT: <{actual}>");
        }
    }
}
