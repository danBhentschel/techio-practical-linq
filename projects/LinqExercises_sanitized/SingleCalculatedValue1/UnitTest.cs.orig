using System.Collections.Generic;
using System.Linq;
using LinqExercises.Utils;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace SingleCalculatedValue1
{
    [TestClass]
    public class UnitTest
    {
        [TestMethod]
        public void Exercise1()
        {
            var words = "This is the first test".Split(' ');
            var description = "{" + string.Join(", ", words) + "}";
            Utils.CgMessage($"About to test NumberThatStartWith({description}, \"is\")");
            var answer = Count1.NumberThatStartWith(words, "is");
            Utils.AssertAreEqual("1", answer.ToString(), description);

            Utils.CgMessage(string.Empty);
            words = "I'm sorry Dave I can't do that".Split(' ');
            description = "{" + string.Join(", ", words) + "}";
            Utils.CgMessage($"About to test NumberThatStartWith({description}, \"I\")");
            answer = Count1.NumberThatStartWith(words, "I");
            Utils.AssertAreEqual("2", answer.ToString(), description);

            Utils.CgMessage(string.Empty);
            words = "She sells sea shells down by the sea shore".Split(' ');
            description = "{" + string.Join(", ", words) + "}";
            Utils.CgMessage($"About to test NumberThatStartWith({description}, \"se\")");
            answer = Count1.NumberThatStartWith(words, "se");
            Utils.AssertAreEqual("3", answer.ToString(), description);

            Utils.CgMessage(string.Empty);
            Utils.CgMessage("Congratulations, you did it!");
        }

        [TestMethod]
        public void Exercise2()
        {
            var words = "This is the first test".Split(' ');
            var description = "{" + string.Join(", ", words) + "}";
            Utils.CgMessage($"About to test LengthOfShortestWord({description})");
            var answer = MinMax1.LengthOfShortestWord(words);
            Utils.AssertAreEqual("2", answer.ToString(), description);

            Utils.CgMessage(string.Empty);
            words = "I'm sorry Dave I can't do that".Split(' ');
            description = "{" + string.Join(", ", words) + "}";
            Utils.CgMessage($"About to test LengthOfShortestWord({description})");
            answer = MinMax1.LengthOfShortestWord(words);
            Utils.AssertAreEqual("1", answer.ToString(), description);

            Utils.CgMessage(string.Empty);
            words = "She sells sea shells down by the sea shore".Split(' ');
            description = "{" + string.Join(", ", words) + "}";
            Utils.CgMessage($"About to test LengthOfShortestWord({description})");
            answer = MinMax1.LengthOfShortestWord(words);
            Utils.AssertAreEqual("2", answer.ToString(), description);

            Utils.CgMessage(string.Empty);
            Utils.CgMessage("Congratulations, you did it!");
        }

        [TestMethod]
        public void Exercise3()
        {
            var words = "This is the first test".Split(' ');
            var description = "{" + string.Join(", ", words) + "}";
            Utils.CgMessage($"About to test TotalCharactersInSequence({description})");
            var answer = Aggregate1.TotalCharactersInSequence(words);
            Utils.AssertAreEqual("18", answer.ToString(), description);

            Utils.CgMessage(string.Empty);
            words = "I'm sorry Dave I can't do that".Split(' ');
            description = "{" + string.Join(", ", words) + "}";
            Utils.CgMessage($"About to test TotalCharactersInSequence({description})");
            answer = Aggregate1.TotalCharactersInSequence(words);
            Utils.AssertAreEqual("24", answer.ToString(), description);

            Utils.CgMessage(string.Empty);
            words = "She sells sea shells down by the sea shore".Split(' ');
            description = "{" + string.Join(", ", words) + "}";
            Utils.CgMessage($"About to test TotalCharactersInSequence({description})");
            answer = Aggregate1.TotalCharactersInSequence(words);
            Utils.AssertAreEqual("34", answer.ToString(), description);

            Utils.CgMessage(string.Empty);
            Utils.CgMessage("Congratulations, you did it!");
        }
    }
}
