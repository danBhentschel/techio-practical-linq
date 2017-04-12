using System;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Delegates1
{
    [TestClass]
    public class UnitTest
    {
        public static List<string> Answers;

        [TestMethod]
        public void Exercise1()
        {
            Answers = new List<string>();

            DelegatesExercise1.CallSayHelloDelegate(s => $"Hello, {s}!");

            Assert.AreEqual("Hello, World!", Answers[0]);
            Assert.AreEqual("Hello, my baby!", Answers[1]);
            Assert.AreEqual("Hello, my honey!", Answers[2]);

            Answers.ForEach(CgMessage);
            CgMessage(string.Empty);
            CgMessage("Congratulations, you did it!");
        }

        private static void CgMessage(string message)
        {
            Console.WriteLine($"CG> message -channel \"exercise results\" \"{message}\"");
        }
    }
}
