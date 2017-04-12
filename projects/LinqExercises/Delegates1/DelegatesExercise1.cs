namespace Delegates1
{
    // Uncomment the SayHello delegate declaration
    //
    // Following the example in the lesson, declare the 
    // type SayHello as a delegate that takes a single
    // string parameter and returns a string result.

    // public ... SayHello ...
    //// START SOLUTION ////
    public delegate string SayHello(string s);
    //// END SOLUTION ////

    public static class DelegatesExercise1
    {
        public static void CallSayHelloDelegate(SayHello func)
        {
            Exercise.PrintAnswer(func("World"));
            Exercise.PrintAnswer(func("my baby"));
            Exercise.PrintAnswer(func("my honey"));
        }
    }
}
