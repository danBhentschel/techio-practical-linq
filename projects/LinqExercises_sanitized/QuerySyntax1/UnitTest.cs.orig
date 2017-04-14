using System.Collections.Generic;
using LinqExercises.Utils;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace QuerySyntax1
{
    [TestClass]
    public class UnitTest
    {
        [TestMethod]
        public void Exercise1()
        {
            Utils.CgMessage("About to test FilterAndSort({foo, bar, goo, onion}, oo)");
            var answer = QuerySyntax1.FilterAndSort(new List<string> {"foo", "bar", "goo", "onion"}, "oo");
            Utils.AssertAreEqual("foo, goo", string.Join(", ", answer), "{foo, bar, goo, onion}, oo");

            Utils.CgMessage(string.Empty);
            Utils.CgMessage("About to test FilterAndSort({abc, bca, cba, aaa}, a)");
            answer = QuerySyntax1.FilterAndSort(new List<string> { "abc", "bca", "cba", "aaa" }, "a");
            Utils.AssertAreEqual("aaa, abc, bca, cba", string.Join(", ", answer), "{abc, bca, cba, aaa}, a");

            Utils.CgMessage(string.Empty);
            Utils.CgMessage("About to test FilterAndSort({pointer, reference, structure, integer}, er)");
            answer = QuerySyntax1.FilterAndSort(new List<string> { "pointer", "reference", "structure", "integer" }, "er");
            Utils.AssertAreEqual("integer, pointer, reference", string.Join(", ", answer), "{pointer, reference, structure, integer}, er");

            Utils.CgMessage(string.Empty);
            Utils.CgMessage("Congratulations, you did it!");
        }
    }
}
