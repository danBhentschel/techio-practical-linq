using System.Collections.Generic;
using System.Linq;
using LinqExercises.Utils;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace AllTogether1
{
    [TestClass]
    public class UnitTest
    {
        [TestMethod]
        public void Exercise1()
        {
            Utils.CgMessage("About to call TestForSquares({1, 2, 3, 4, 5}, {1, 4, 9, 16, 25})");
            var answer = FullExercise1.TestForSquares(new[] { 1, 2, 3, 4, 5 }, new[] { 1, 4, 9, 16, 25 });
            Utils.AssertAreEqual(true, answer, "{1, 2, 3, 4, 5}, {1, 4, 9, 16, 25}");

            Utils.CgMessage(string.Empty);
            Utils.CgMessage("About to call TestForSquares({1, 2, 5}, {1, 4, 9})");
            answer = FullExercise1.TestForSquares(new[] { 1, 2, 5 }, new[] { 1, 4, 9 });
            Utils.AssertAreEqual(false, answer, "{1, 2, 5}, {1, 4, 9}");

            Utils.CgMessage(string.Empty);
            Utils.CgMessage("About to call TestForSquares({12}, {144})");
            answer = FullExercise1.TestForSquares(new[] { 12 }, new[] { 144 });
            Utils.AssertAreEqual(true, answer, "{12}, {144}");

            Utils.CgMessage(string.Empty);
            Utils.CgMessage("About to call TestForSquares({1, 5, 3}, {1, 25, 9, 9})");
            answer = FullExercise1.TestForSquares(new[] { 1, 5, 3 }, new[] { 1, 25, 9, 9 });
            Utils.AssertAreEqual(false, answer, "{1, 5, 3}, {1, 25, 9, 9}");

            Utils.CgMessage(string.Empty);
            Utils.CgMessage("About to call TestForSquares({}, {})");
            answer = FullExercise1.TestForSquares(new int[0], new int[0]);
            Utils.AssertAreEqual(true, answer, "{}, {}");

            Utils.CgMessage(string.Empty);
            Utils.CgMessage("Congratulations, you did it!");
        }

        [TestMethod]
        public void Exercise2()
        {
            Utils.CgMessage("About to call GetTheLastWord({\"he\",\"she\",\"it\",\"we\",\"you\",\"they\"})");
            var answer = FullExercise2.GetTheLastWord(new[] { "he", "she", "it", "we", "you", "they" });
            Utils.AssertAreEqual("The last word is we", answer, "{\"he\",\"she\",\"it\",\"we\",\"you\",\"they\"}");

            Utils.CgMessage(string.Empty);
            Utils.CgMessage("About to call GetTheLastWord({\"hop\",\"top\",\"stop\",\"cop\",\"lop\",\"chop\"})");
            answer = FullExercise2.GetTheLastWord(new[] { "hop", "top", "stop", "cop", "lop", "chop" });
            Utils.AssertAreEqual(null, answer, "{\"hop\",\"top\",\"stop\",\"cop\",\"lop\",\"chop\"}");

            Utils.CgMessage(string.Empty);
            Utils.CgMessage("About to call GetTheLastWord({\"elastic\",\"elaborate\",\"elephant\",\"iris\",\"ibis\",\"incredible\"})");
            answer = FullExercise2.GetTheLastWord(new[] { "elastic", "elaborate", "elephant", "iris", "ibis", "incredible" });
            Utils.AssertAreEqual("The last word is incredible", answer, "{\"elastic\",\"elaborate\",\"elephant\",\"iris\",\"ibis\",\"incredible\"}");

            Utils.CgMessage(string.Empty);
            Utils.CgMessage("About to call GetTheLastWord({})");
            answer = FullExercise2.GetTheLastWord(new string[0]);
            Utils.AssertAreEqual(null, answer, "{}");

            Utils.CgMessage(string.Empty);
            Utils.CgMessage("Congratulations, you did it!");
        }
    }
}
