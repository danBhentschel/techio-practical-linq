using System.Collections.Generic;
using LinqExercises.Utils;
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
                Utils.CgMessage("You need to call Exercise.TestSayHello()");
            }
            Assert.IsNotNull(Answers);
            Utils.AssertAreEqual("Hello, World!", Answers[0], "World");
            Utils.AssertAreEqual("Hello, Dolly!", Answers[1], "Dolly");
            Utils.AssertAreEqual("Hello, there!", Answers[2], "there");

            Utils.CgMessage(string.Empty);
            Utils.CgMessage("Congratulations, you did it!");
        }
    }
}
