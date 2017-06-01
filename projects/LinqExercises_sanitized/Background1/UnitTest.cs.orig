using System.Collections.Generic;
using System.Linq;
using LinqExercises.Utils;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Background1
{
    [TestClass]
    public class UnitTest
    {
        [TestMethod]
        public void Exercise1()
        {
            Utils.CgMessage("About to test GetNextNumber(5)");
            var answer = LambdaExpressions1.GetNextNumber(5).ToString();
            Utils.AssertAreEqual("6", answer, "5");

            Utils.CgMessage(string.Empty);
            Utils.CgMessage("About to test GetNextNumber(-2)");
            answer = LambdaExpressions1.GetNextNumber(-2).ToString();
            Utils.AssertAreEqual("-1", answer, "-2");

            Utils.CgMessage(string.Empty);
            Utils.CgMessage("Congratulations, you did it!");
        }
    }
}
