using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delegates
{
    public class Example1Runner
    {
        public static void TestSayHello(SayHello func)
        {
            UnitTest.Answers = new List<string>
            {
                func("World"), func("Dolly"), func("there")
            };
        }
    }
}
