using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delegates
{
    public delegate string SayHello(string subject);

    public class Example1
    {
        public static void DoSayHello()
        {
            // The method ExampleRunner.TestSayHello() takes a
            // SayHello delegate as input. Pass it a delegate
            // method that, when given a string "foo", will
            // return the string "Hello, foo!".

            // Example1Runner.TestSayHello(<something>);
        }
    }
}
