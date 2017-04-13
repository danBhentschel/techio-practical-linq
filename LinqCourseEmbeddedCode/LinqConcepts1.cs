using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;
//// START EMBED: LINQ query syntax ////
using System.Linq;

//// START ELIDE ////

namespace LinqCourseEmbeddedCode
{
    [TestClass]
    public class LinqConcepts1
    {
        [TestMethod]
        public void TestMethod1()
        {
    //// END ELIDE ////

    List<string> animalNames = new List<string>
        {"fawn", "gibbon", "heron", "ibex", "jackalope"};
    
    // Result: {"heron", "gibbon", "jackalope"}
    IEnumerable<string> longAnimalNames =
        from name in animalNames
        where name.Length >= 5
        orderby name.Length
        select name;
    //// END EMBED ////

            Assert.IsTrue((new List<string>{"heron", "gibbon", "jackalope"}).SequenceEqual(longAnimalNames));
        }

        [TestMethod]
        public void TestMethod2()
        {
            //// START EMBED: LINQ method syntax ////
            List<string> animalNames = new List<string>
                {"fawn", "gibbon", "heron", "ibex", "jackalope"};

            IEnumerable<string> longAnimalNames =
                animalNames
                .Where(name => name.Length >= 5)
                .OrderBy(name => name.Length);
            //// END EMBED ////
        }
    }
}
