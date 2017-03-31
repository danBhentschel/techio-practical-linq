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

            Assert.IsNotNull(Answers, "You need to call Example1Runner.TestSayHello()");
            Assert.AreEqual("Hello, World!", Answers[0]);
            Assert.AreEqual("Hello, Dolly!", Answers[1]);
            Assert.AreEqual("Hello, there!", Answers[2]);
            Console.WriteLine("CG> message You did it!");
        }
    }
}
