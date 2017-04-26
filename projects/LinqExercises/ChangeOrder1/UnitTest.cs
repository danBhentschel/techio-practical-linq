using System;
using System.Collections.Generic;
using System.Linq;
using LinqExercises.Utils;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace ChangeOrder1
{
    [TestClass]
    public class UnitTest
    {
        [TestMethod]
        public void Exercise1()
        {
            var names = new List<Name>
            {
                new NameImpl("Martin Luther King"),
                new NameImpl("Johan Sebastian Bach"),
                new NameImpl("Wolfgang Amadeus Mozart"),
                new NameImpl("Franklin Delano Roosevelt")
            };
            var description = "{\"" + string.Join("\", \"", names) + "\"}";
            Utils.CgMessage($"About to test SortNames({description})");
            var answer = OrderBy1.SortNames(names);
            var str = string.Join(", ", answer.Select(_ => _.Last));
            Utils.AssertAreEqual("Roosevelt, Mozart, King, Bach", str, description);

            names = new List<Name>
            {
                new NameImpl("Hillary Rodham Clinton"),
                new NameImpl("Edgar Allan Poe"),
                new NameImpl("Billie Jean King"),
                new NameImpl("John Fitzgerald Kennedy")
            };
            description = "{\"" + string.Join("\", \"", names) + "\"}";
            Utils.CgMessage($"About to test SortNames({description})");
            answer = OrderBy1.SortNames(names);
            str = string.Join(", ", answer.Select(_ => _.Last));
            Utils.AssertAreEqual("Poe, King, Kennedy, Clinton", str, description);

            Utils.CgMessage(string.Empty);
            Utils.CgMessage("Congratulations, you did it!");
        }

        [TestMethod]
        public void Exercise2()
        {
            var names = new List<Name>
            {
                new NameImpl("Martin Luther King"),
                new NameImpl("Johan Sebastian Bach"),
                new NameImpl("Billie Jean King"),
                new NameImpl("Franklin Delano Roosevelt")
            };
            var description = "{\"" + string.Join("\", \"", names) + "\"}";
            Utils.CgMessage($"About to test SortNames({description})");
            var answer = ThenBy1.SortNames(names);
            var str = string.Join(", ", answer.Select(_ => _.First));
            Utils.AssertAreEqual("Johan, Billie, Martin, Franklin", str, description);

            names = new List<Name>
            {
                new NameImpl("Hillary Rodham Clinton"),
                new NameImpl("Edgar Allan Poe"),
                new NameImpl("Edgar Ellen Poe"),
                new NameImpl("John Fitzgerald Kennedy")
            };
            description = "{\"" + string.Join("\", \"", names) + "\"}";
            Utils.CgMessage($"About to test SortNames({description})");
            answer = ThenBy1.SortNames(names);
            str = string.Join(", ", answer.Select(_ => _.Middle));
            Utils.AssertAreEqual("Rodham, Fitzgerald, Allan, Ellen", str, description);

            Utils.CgMessage(string.Empty);
            Utils.CgMessage("Congratulations, you did it!");
        }

        private class NameImpl : Name
        {
            public string First { get; private set; }

            public string Middle { get; private set; }

            public string Last { get; private set; }

            public NameImpl(string name)
            {
                var names = name.Split(' ');
                First = names[0];
                Middle = names[1];
                Last = names[2];
            }

            public override string ToString()
            {
                return $"{First} {Middle} {Last}";
            }
        }
    }
}
