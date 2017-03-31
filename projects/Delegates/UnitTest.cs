using System;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Delegates
{
    [TestClass]
    public class UnitTest
    {
        public static List<string> Answers;

        [TestMethod]
        public void Exercise1()
        {
            Answers = null;

            Example1.DoSayHello();
            var cgMessage = "CG> message -channel \"exercise results\"";

            Assert.IsNotNull(Answers, $"\n{cgMessage} You need to call Example1Runner.TestSayHello()");
            AssertAreEqual("Hello, World!", Answers[0], "World");
            AssertAreEqual("Hello, Dolly!", Answers[1], "Dolly");
            AssertAreEqual("Hello, there!", Answers[2], "there");

            Console.WriteLine("CG> message --channel \"exercise results\" \"\"");
            Console.WriteLine("CG> message --channel \"exercise results\" Congratulations, you did it!");
        }

        private static void AssertAreEqual(string expected, string actual, string provided)
        {
            Assert.AreEqual(expected, actual, $"\n{cgMessage} EXPECTED: <{expected}>  GOT: <{actual}>");
            Console.WriteLine($"{cgMessage} IN: <{provided}> OUT: <{actual}>");
        }
    }
}
