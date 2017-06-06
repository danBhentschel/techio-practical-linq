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
            var answer = PracticalLinqFullExercise1.TestForSquares(new[] { 1, 2, 3, 4, 5 }, new[] { 1, 4, 9, 16, 25 });
            Utils.AssertAreEqual(true, answer, "{1, 2, 3, 4, 5}, {1, 4, 9, 16, 25}");

            Utils.CgMessage(string.Empty);
            Utils.CgMessage("About to call TestForSquares({1, 2, 5}, {1, 4, 9})");
            answer = PracticalLinqFullExercise1.TestForSquares(new[] { 1, 2, 5 }, new[] { 1, 4, 9 });
            Utils.AssertAreEqual(false, answer, "{1, 2, 5}, {1, 4, 9}");

            Utils.CgMessage(string.Empty);
            Utils.CgMessage("About to call TestForSquares({12}, {144})");
            answer = PracticalLinqFullExercise1.TestForSquares(new[] { 12 }, new[] { 144 });
            Utils.AssertAreEqual(true, answer, "{12}, {144}");

            Utils.CgMessage(string.Empty);
            Utils.CgMessage("About to call TestForSquares({1, 5, 3}, {1, 25, 9, 9})");
            answer = PracticalLinqFullExercise1.TestForSquares(new[] { 1, 5, 3 }, new[] { 1, 25, 9, 9 });
            Utils.AssertAreEqual(false, answer, "{1, 5, 3}, {1, 25, 9, 9}");

            Utils.CgMessage(string.Empty);
            Utils.CgMessage("About to call TestForSquares({}, {})");
            answer = PracticalLinqFullExercise1.TestForSquares(new int[0], new int[0]);
            Utils.AssertAreEqual(true, answer, "{}, {}");

            Utils.CgMessage(string.Empty);
            Utils.CgMessage("Congratulations, you did it!");
        }
    }
}
