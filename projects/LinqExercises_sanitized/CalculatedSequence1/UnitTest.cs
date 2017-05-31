using System.Collections.Generic;
using LinqExercises.Utils;
using Microsoft.VisualStudio.TestTools.UnitTesting;

// ReSharper disable once CheckNamespace
namespace CalculatedSequence1
{
    [TestClass]
    public class UnitTest
    {
        [TestMethod]
        public void Exercise1()
        {
            var names = new List<Select1.Name>
            {
                new NameImpl("Martin Luther King"),
                new NameImpl("Johan Sebastian Bach"),
                new NameImpl("Wolfgang Amadeus Mozart"),
                new NameImpl("Franklin Delano Roosevelt")
            };
            var description = "{" + string.Join(", ", names) + "}";
            Utils.CgMessage($"About to test DisplayStringsForNames({description})");
            var answer = Select1.DisplayStringsForNames(names);
            var str = string.Join("; ", answer);
            Utils.AssertAreEqual("King, Martin; Bach, Johan; Mozart, Wolfgang; Roosevelt, Franklin", str, description);

            Utils.CgMessage(string.Empty);
            names = new List<Select1.Name>
            {
                new NameImpl("Hillary Rodham Clinton"),
                new NameImpl("Edgar Allan Poe"),
                new NameImpl("Billie Jean King"),
                new NameImpl("John Fitzgerald Kennedy")
            };
            description = "{" + string.Join(", ", names) + "}";
            Utils.CgMessage($"About to test DisplayStringsForNames({description})");
            answer = Select1.DisplayStringsForNames(names);
            str = string.Join("; ", answer);
            Utils.AssertAreEqual("Clinton, Hillary; Poe, Edgar; King, Billie; Kennedy, John", str, description);

            Utils.CgMessage(string.Empty);
            Utils.CgMessage("Congratulations, you did it!");
        }

        private class NameImpl : Select1.Name
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
    }
}
