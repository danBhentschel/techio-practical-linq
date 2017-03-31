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

            Console.WriteLine("CG> message --channel \"execution progress\" Running...");

            Example1.DoSayHello();

            Assert.IsNotNull(Answers, "You need to call Example1Runner.TestSayHello()");
            Console.WriteLine($"CG> message --channel \"exercise results\" IN: <World> OUT: <{Answers[0]}>");
            Assert.AreEqual("Hello, World!", Answers[0]);
            Console.WriteLine($"CG> message --channel \"exercise results\" IN: <Dolly> OUT: <{Answers[1]}>");
            Assert.AreEqual("Hello, Dolly!", Answers[1]);
            Console.WriteLine($"CG> message --channel \"exercise results\" IN: <there> OUT: <{Answers[2]}>");
            Assert.AreEqual("Hello, there!", Answers[2]);

            Console.WriteLine("CG> message --channel \"exercise results\" \"\"");
            Console.WriteLine("CG> message --channel \"exercise results\" Congratulations, you did it!");
        }
    }
}
