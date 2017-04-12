namespace Delegates1
{
    public static class Exercise
    {
        public static void PrintAnswer(string answer)
        {
            UnitTest.Answers.Add(answer);
        }
    }
}