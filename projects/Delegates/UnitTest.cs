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

            Console.WriteLine("CG> redirect-streams --input \"out\" \"null\"");
            Console.WriteLine("CG> redirect-streams --input \"exercise results\" out");

            Example1.DoSayHello();

            Assert.IsNotNull(Answers, "You need to call Example1Runner.TestSayHello()");
            Assert.AreEqual("Hello, World!", Answers[0]);
            Console.WriteLine("CG> message --channel \"exercise results\" IN: <World> OUT: <Hello, World!>");
            Assert.AreEqual("Hello, Dolly!", Answers[1]);
            Console.WriteLine("CG> message --channel \"exercise results\" IN: <Dolly> OUT: <Hello, Dolly!>");
            Assert.AreEqual("Hello, there!", Answers[2]);
            Console.WriteLine("CG> message --channel \"exercise results\" IN: <there> OUT: <Hello, there!>");

            Console.WriteLine("CG> message --channel \"exercise results\" \"\"");
            Console.WriteLine("CG> message --channel \"exercise results\" You did it!");
        }
    }
}
