using System.Collections.Generic;

namespace Delegates
{
    public class ExerciseRunner
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
