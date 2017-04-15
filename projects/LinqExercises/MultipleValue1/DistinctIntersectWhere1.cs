using System.Collections.Generic;
using System.Linq;

namespace MultipleValue1
{
    public static class DistinctIntersectWhere1
    {
        // Return all distinct words that have less than four letters in them.
        public static IEnumerable<string> GetDistinctShortWords(
            IEnumerable<string> words)
        {
            // Uncomment:
            // return words.???();
            //// START SOLUTION ////
            return words.Distinct().Where(_ => _.Length < 4);
            //// END SOLUTION ////
        }
    }
}