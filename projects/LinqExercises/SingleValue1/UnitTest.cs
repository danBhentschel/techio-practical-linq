using System.Collections.Generic;
using System.Linq;
using LinqExercises.Utils;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace SingleValue1
{
    [TestClass]
    public class UnitTest
    {
        [TestMethod]
        public void Exercise1()
        {
            Utils.CgMessage("About to test GetFirstSingleLetterWord({This, is, a, test})");
            var answer = SingleValue1.GetFirstSingleLetterWord(new List<string> { "This", "is", "a", "test" });
            Utils.AssertAreEqual("a", answer, "{This, is, a, test}");

            Utils.CgMessage(string.Empty);
            Utils.CgMessage("About to test GetFirstSingleLetterWord({I, am, not, a, crook})");
            answer = SingleValue1.GetFirstSingleLetterWord(new List<string> { "I", "am", "not", "a", "crook" });
            Utils.AssertAreEqual("I", answer, "{I, am, not, a, crook}");

            Utils.CgMessage(string.Empty);
            Utils.CgMessage("About to test GetFirstSingleLetterWord({d, e, a, d, b, e, e, f})");
            answer = SingleValue1.GetFirstSingleLetterWord("deadbeef".ToCharArray().Select(_ => _.ToString()));
            Utils.AssertAreEqual("d", answer, "{d, e, a, d, b, e, e, f}");

            Utils.CgMessage(string.Empty);
            Utils.CgMessage("Congratulations, you did it!");

            Utils.CgMessage(string.Empty);
            Utils.CgMessage(string.Empty);
            Utils.CgMessage("About to test GetLastWordWithHerInIt({Watching, the, weather, together, with, her})");
            answer = SingleValue1.GetLastWordWithHerInIt("Watching the weather together with her".Split(' '));
            Utils.AssertAreEqual("her", answer, "{Watching, the, weather, together, with, her}");

            Utils.CgMessage(string.Empty);
            Utils.CgMessage("About to test GetLastWordWithHerInIt({Watching, the, watcher, alone})");
            answer = SingleValue1.GetLastWordWithHerInIt("Watching the watcher alone".Split(' '));
            Utils.AssertAreEqual("watcher", answer, "{Watching, the, watcher, alone}");

            Utils.CgMessage(string.Empty);
            Utils.CgMessage("About to test GetLastWordWithHerInIt({where, where, where, where})");
            answer = SingleValue1.GetLastWordWithHerInIt("where where where where".Split(' '));
            Utils.AssertAreEqual("where", answer, "{where, where, where, where}");

            Utils.CgMessage(string.Empty);
            Utils.CgMessage("Congratulations, you did it!");

            Utils.CgMessage(string.Empty);
            Utils.CgMessage(string.Empty);
            Utils.CgMessage("About to test GetFifthWordIfItExists({Watching, the, weather, together, with, her})");
            answer = SingleValue1.GetFifthWordIfItExists("Watching the weather together with her".Split(' '));
            Utils.AssertAreEqual("with", answer, "{Watching, the, weather, together, with, her}");

            Utils.CgMessage(string.Empty);
            Utils.CgMessage("About to test GetFifthWordIfItExists({Watching, the, watcher, alone})");
            answer = SingleValue1.GetFifthWordIfItExists("Watching the watcher alone".Split(' '));
            Utils.AssertAreEqual(null, answer, "{Watching, the, watcher, alone}");

            Utils.CgMessage(string.Empty);
            Utils.CgMessage("About to test GetFifthWordIfItExists({ })");
            answer = SingleValue1.GetFifthWordIfItExists(new List<string>());
            Utils.AssertAreEqual(null, answer, "{ }");

            Utils.CgMessage(string.Empty);
            Utils.CgMessage("Congratulations, you did it!");

            Utils.CgMessage(string.Empty);
            Utils.CgMessage(string.Empty);
            Utils.CgMessage("About to test GetLastWordIfAny({Watching, the, weather, together, with, her})");
            answer = SingleValue1.GetLastWordIfAny("Watching the weather together with her".Split(' '));
            Utils.AssertAreEqual("her", answer, "{Watching, the, weather, together, with, her}");

            Utils.CgMessage(string.Empty);
            Utils.CgMessage("About to test GetLastWordIfAny({Watching, the, watcher, alone})");
            answer = SingleValue1.GetLastWordIfAny("Watching the watcher alone".Split(' '));
            Utils.AssertAreEqual("alone", answer, "{Watching, the, watcher, alone}");

            Utils.CgMessage(string.Empty);
            Utils.CgMessage("About to test GetLastWordIfAny({ })");
            answer = SingleValue1.GetLastWordIfAny(new List<string>());
            Utils.AssertAreEqual(null, answer, "{ }");

            Utils.CgMessage(string.Empty);
            Utils.CgMessage("Congratulations, you did it!");
        }
    }
}
