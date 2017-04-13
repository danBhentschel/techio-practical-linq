using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
using System.Linq;

namespace LinqCourseEmbeddedCode
{
    [TestClass]
    public class LinqConcepts1
    {
        [TestMethod]
        public void TestMethod1()
        {
            //// START EMBED: LINQ query syntax ////
            List<string> animalNames = new List<string>
                {"fawn", "gibbon", "heron", "ibex", "jackalope"};
            IEnumerable<string> longAnimalNames =
                from name in animalNames
                where name.Length > 5
                orderby name.Length
                select name;
            //// END EMBED ////
        }

        [TestMethod]
        public void TestMethod2()
        {
            //// START EMBED: LINQ method syntax ////
            List<string> animalNames = new List<string>
                {"fawn", "gibbon", "heron", "ibex", "jackalope"};
            IEnumerable<string> longAnimalNames =
                animalNames
                .Where(name => name.Length > 5)
                .OrderBy(name => name.Length);
            //// END EMBED ////
        }
    }
}
