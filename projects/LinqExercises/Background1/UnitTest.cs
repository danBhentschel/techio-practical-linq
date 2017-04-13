using System.Collections.Generic;
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
            Utils.CgMessage("About to test DoTransform(new List<int> { 10, 20, 30 }, x => x / 10)");
            var enumerable = BackgroundReviewExercise1.DoTransform(new List<int> { 10, 20, 30 }, x => x / 10);
            var answer = string.Join(" ", enumerable);
            Utils.AssertAreEqual("1 2 3", answer, "{ 10, 20, 30 } -- x / 3");

            Utils.CgMessage(string.Empty);
            Utils.CgMessage("About to test DoTransform(new List<int> { 7, 11, 15, 19 }, x => x - 7)");
            enumerable = BackgroundReviewExercise1.DoTransform(new List<int> { 7, 11, 15, 19 }, x => x - 7);
            answer = string.Join(" ", enumerable);
            Utils.AssertAreEqual("0 4 8 12", answer, "{ 7, 11, 15, 19 } -- x - 7");

            Utils.CgMessage(string.Empty);
            Utils.CgMessage("About to test DoTransform(new List<int> { 1, 1, 1, 2, 2, 2 }, x => 20)");
            enumerable = BackgroundReviewExercise1.DoTransform(new List<int> { 1, 1, 1, 2, 2, 2 }, x => 20);
            answer = string.Join(" ", enumerable);
            Utils.AssertAreEqual("20 20 20 20 20 20", answer, "{ 1, 1, 1, 2, 2, 2 } -- 20");

            Utils.CgMessage(string.Empty);
            Utils.CgMessage("About to test new List<int> { 1, 2, 3 }.Transform(x => x * 2)");
            enumerable = new List<int> { 1, 2, 3 }.Transform(x => x * 2);
            answer = string.Join(" ", enumerable);
            Utils.AssertAreEqual("2 4 6", answer, "{ 1, 2, 3 } -- x * 2");

            Utils.CgMessage(string.Empty);
            Utils.CgMessage("Congratulations, you did it!");
        }
    }
}
