using System.Linq;
using LinqExercises.Utils;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Generators1
{
    [TestClass]
    public class UnitTest
    {
        [TestMethod]
        public void Exercise1()
        {
            Utils.CgMessage("About to test AddTwoThenDouble().Take(10)");
            var answer = string.Join(" ", GeneratorsExercise1.AddTwoThenDouble().Take(10));
            Utils.AssertAreEqual("2 4 6 12 14 28 30 60 62 124", answer, "First 10 values");

            Utils.CgMessage(string.Empty);
            Utils.CgMessage("About to test AddTwoThenDouble().Skip(13).Take(4)");
            answer = string.Join(" ", GeneratorsExercise1.AddTwoThenDouble().Skip(13).Take(4));
            Utils.AssertAreEqual("508 510 1020 1022", answer, "Values 14 - 17");

            Utils.CgMessage(string.Empty);
            Utils.CgMessage("About to test AddTwoThenDouble().Skip(28).First()");
            answer = GeneratorsExercise1.AddTwoThenDouble().Skip(28).First().ToString();
            Utils.AssertAreEqual("65534", answer, "28th value");

            Utils.CgMessage(string.Empty);
            Utils.CgMessage("Congratulations, you did it!");
        }
    }
}
