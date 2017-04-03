using System.Collections.Generic;

namespace Delegates1
{
    public static class Exercise
    {
        public static void PrintAnswer(string answer)
        {
            Delegates.UnitTest.Answers.Add(answer);
        }
    }
}

namespace Delegates2
{
    public static class Exercise
    {
        public static void TestSayHello(SayHello func)
        {
            Delegates.UnitTest.Answers = new List<string>
            {
                func("World"), func("Dolly"), func("there")
            };
        }
    }
}
