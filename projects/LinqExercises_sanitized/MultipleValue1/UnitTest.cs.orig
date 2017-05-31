using LinqExercises.Utils;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace MultipleValue1
{
    [TestClass]
    public class UnitTest
    {
        [TestMethod]
        public void Exercise1()
        {
            var words = "This is the first test".Split(' ');
            var description = "{" + string.Join(", ", words) + "}";
            Utils.CgMessage($"About to test GetThirdFourthFifthItems({description})");
            var answer = SkipTake1.GetThirdFourthFifthItems(words);
            var str = string.Join(", ", answer);
            Utils.AssertAreEqual("the, first, test", str, description);

            Utils.CgMessage(string.Empty);
            words = "I'm sorry Dave I can't do that".Split(' ');
            description = "{" + string.Join(", ", words) + "}";
            Utils.CgMessage($"About to test GetThirdFourthFifthItems({description})");
            answer = SkipTake1.GetThirdFourthFifthItems(words);
            str = string.Join(", ", answer);
            Utils.AssertAreEqual("Dave, I, can't", str, description);

            Utils.CgMessage(string.Empty);
            words = "640K should be enough for anybody".Split(' ');
            description = "{" + string.Join(", ", words) + "}";
            Utils.CgMessage($"About to test GetThirdFourthFifthItems({description})");
            answer = SkipTake1.GetThirdFourthFifthItems(words);
            str = string.Join(", ", answer);
            Utils.AssertAreEqual("be, enough, for", str, description);

            Utils.CgMessage(string.Empty);
            Utils.CgMessage("Congratulations, you did it!");
        }

        [TestMethod]
        public void Exercise2()
        {
            var words = "This start is the end first test".Split(' ');
            var description = "{" + string.Join(", ", words) + "}";
            Utils.CgMessage($"About to test GetStartThroughEnd({description})");
            var answer = Count1.GetStartThroughEnd(words);
            var str = string.Join(", ", answer);
            Utils.AssertAreEqual("start, is, the", str, description);

            Utils.CgMessage(string.Empty);
            words = "start I'm sorry Dave end I can't do that".Split(' ');
            description = "{" + string.Join(", ", words) + "}";
            Utils.CgMessage($"About to test GetStartThroughEnd({description})");
            answer = Count1.GetStartThroughEnd(words);
            str = string.Join(", ", answer);
            Utils.AssertAreEqual("start, I'm, sorry, Dave", str, description);

            Utils.CgMessage(string.Empty);
            words = "640K should be start end enough for anybody".Split(' ');
            description = "{" + string.Join(", ", words) + "}";
            Utils.CgMessage($"About to test GetStartThroughEnd({description})");
            answer = Count1.GetStartThroughEnd(words);
            str = string.Join(", ", answer);
            Utils.AssertAreEqual("start", str, description);

            Utils.CgMessage(string.Empty);
            Utils.CgMessage("Congratulations, you did it!");
        }


        [TestMethod]
        public void Exercise3()
        {
            var words = "Cant see the forest for the trees".Split(' ');
            var description = "{" + string.Join(", ", words) + "}";
            Utils.CgMessage($"About to test GetDistinctShortWords({description})");
            var answer = DistinctIntersectWhere1.GetDistinctShortWords(words);
            var str = string.Join(", ", answer);
            Utils.AssertAreEqual("see, the, for", str, description);

            Utils.CgMessage(string.Empty);
            words = "Im sorry Dave I cant do that".Split(' ');
            description = "{" + string.Join(", ", words) + "}";
            Utils.CgMessage($"About to test GetDistinctShortWords({description})");
            answer = DistinctIntersectWhere1.GetDistinctShortWords(words);
            str = string.Join(", ", answer);
            Utils.AssertAreEqual("Im, I, do", str, description);

            Utils.CgMessage(string.Empty);
            words = "it was the best of times it was the worst of times".Split(' ');
            description = "{" + string.Join(", ", words) + "}";
            Utils.CgMessage($"About to test GetDistinctShortWords({description})");
            answer = DistinctIntersectWhere1.GetDistinctShortWords(words);
            str = string.Join(", ", answer);
            Utils.AssertAreEqual("it, was, the, of", str, description);

            Utils.CgMessage(string.Empty);
            Utils.CgMessage("Congratulations, you did it!");
        }
    }
}
