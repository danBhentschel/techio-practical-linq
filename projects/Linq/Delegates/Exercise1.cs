namespace Delegates
{
    public delegate string SayHello(string subject);

    public class Exercise1
    {
        public static void DoSayHello()
        {
            // The method ExerciseRunner.TestSayHello() takes a
            // SayHello delegate as input. Pass it a delegate
            // method that, when given a string "foo", will
            // return the string "Hello, foo!".

            ExerciseRunner.TestSayHello(_ => $"Hello, {_}!");

        }
    }
}