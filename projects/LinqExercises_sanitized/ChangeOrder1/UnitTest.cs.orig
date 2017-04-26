using System.Collections.Generic;
using System.Linq;
using ChangeOrder2;
using LinqExercises.Utils;
using Microsoft.VisualStudio.TestTools.UnitTesting;

// ReSharper disable once CheckNamespace
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
            var description = "{" + string.Join(", ", names) + "}";
            Utils.CgMessage($"About to test SortNames({description})");
            var answer = OrderBy1.SortNames(names);
            var str = string.Join(", ", answer.Select(_ => _.Last));
            Utils.AssertAreEqual("Roosevelt, Mozart, King, Bach", str, description);

            Utils.CgMessage(string.Empty);
            names = new List<Name>
            {
                new NameImpl("Hillary Rodham Clinton"),
                new NameImpl("Edgar Allan Poe"),
                new NameImpl("Billie Jean King"),
                new NameImpl("John Fitzgerald Kennedy")
            };
            description = "{" + string.Join(", ", names) + "}";
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
            var names = new List<ChangeOrder2.Name>
            {
                new NameImpl2("Johan Sebastian Bach"),
                new NameImpl2("Martin Luther King"),
                new NameImpl2("Billie Jean King"),
                new NameImpl2("Im The King"),
                new NameImpl2("Franklin Delano Roosevelt")
            };
            var description = "{" + string.Join(", ", names) + "}";
            Utils.CgMessage($"About to test SortNames({description})");
            var answer = ThenBy1.SortNames(names);
            var str = string.Join(", ", answer.Select(_ => _.First));
            Utils.AssertAreEqual("Johan, Billie, Im, Martin, Franklin", str, description);

            Utils.CgMessage(string.Empty);
            names = new List<ChangeOrder2.Name>
            {
                new NameImpl2("Hillary Rodham Clinton"),
                new NameImpl2("Edgar Ellen Poe"),
                new NameImpl2("Edgar Allan Poe"),
                new NameImpl2("John Fitzgerald Kennedy")
            };
            description = "{" + string.Join(", ", names) + "}";
            Utils.CgMessage($"About to test SortNames({description})");
            answer = ThenBy1.SortNames(names);
            str = string.Join(", ", answer.Select(_ => _.Middle));
            Utils.AssertAreEqual("Rodham, Fitzgerald, Allan, Ellen", str, description);

            Utils.CgMessage(string.Empty);
            Utils.CgMessage("Congratulations, you did it!");
        }

        private class NameImpl : Name
        {
            public string First { get; }

            public string Middle { get; }

            public string Last { get; }

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
        private class NameImpl2 : ChangeOrder2.Name
        {
            public string First { get; }

            public string Middle { get; }

            public string Last { get; }

            public NameImpl2(string name)
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
