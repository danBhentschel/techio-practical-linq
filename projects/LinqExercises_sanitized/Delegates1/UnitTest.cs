using System.Collections.Generic;
using LinqExercises.Utils;
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

            Answers.ForEach(Utils.CgMessage);
            Utils.CgMessage(string.Empty);
            Utils.CgMessage("Congratulations, you did it!");
        }
    }
}
