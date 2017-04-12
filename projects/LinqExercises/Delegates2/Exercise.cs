using System.Collections.Generic;

namespace Delegates2
{
    public static class Exercise
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
