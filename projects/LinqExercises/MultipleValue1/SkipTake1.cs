using System.Collections.Generic;
using System.Linq;

namespace MultipleValue1
{
    public static class SkipTake1
    {
        // Return the 3rd, 4th, and 5th items of the provided sequence.
        public static IEnumerable<string> GetThirdFourthFifthItems(
            IEnumerable<string> words)
        {
            // Uncomment:
            // return words.???();
            //// START SOLUTION ////
            return words.Skip(2).Take(3);
            //// END SOLUTION ////
        }
    }
}