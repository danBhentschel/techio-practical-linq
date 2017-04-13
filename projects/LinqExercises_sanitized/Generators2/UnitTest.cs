using System.Linq;
using LinqExercises.Utils;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Generators2
{
    [TestClass]
    public class UnitTest
    {
        [TestMethod]
        public void Exercise2()
        {
            Utils.CgMessage("About to test: AddTwoThenDouble(10)");
            var enumerable = GeneratorsExercise2.AddTwoThenDouble(10);
            var answer = enumerable.Count().ToString();
            Utils.AssertAreEqual("10", answer, "10 values");
            answer = string.Join(" ", enumerable);
            Utils.AssertAreEqual("2 4 6 12 14 28 30 60 62 124", answer, "First 10 values");

            Utils.CgMessage(string.Empty);
            Utils.CgMessage("About to test: AddTwoThenDouble(17).Count()");
            enumerable = GeneratorsExercise2.AddTwoThenDouble(17);
            answer = enumerable.Count().ToString();
            Utils.AssertAreEqual("17", answer, "17 values");

            Utils.CgMessage(string.Empty);
            Utils.CgMessage("About to test: AddTwoThenDouble(17).Skip(13)");
            answer = string.Join(" ", enumerable.Skip(13));
            Utils.AssertAreEqual("508 510 1020 1022", answer, "Values 14 - 17");

            Utils.CgMessage(string.Empty);
            Utils.CgMessage("About to test: AddTwoThenDouble(30).Count()");
            answer = GeneratorsExercise2.AddTwoThenDouble(30).Count().ToString();
            Utils.AssertAreEqual("30", answer, "30 values");

            Utils.CgMessage(string.Empty);
            Utils.CgMessage("Congratulations, you did it!");
        }
    }
}
