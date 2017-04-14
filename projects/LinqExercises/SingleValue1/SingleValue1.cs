using System.Collections.Generic;
using System.Linq;

namespace SingleValue1
{
    public static class SingleValue1
    {
        // Return the first word with just one letter in it, out of a sequence of words.
        // There will always be at least one.
        public static string GetFirstSingleLetterWord(IEnumerable<string> words)
        {
            // Uncomment:
            // return words.???();
            //// START SOLUTION ////
            return words.First(_ => _.Length == 1);
            //// END SOLUTION ////
        }

        // Return the first word that contains the substring "her" in it.
        // There will always be at least one.
        public static string GetLastWordWithHerInIt(IEnumerable<string> words)
        {
            // Uncomment:
            // return words.???();
            //// START SOLUTION ////
            return words.Last(_ => _.Contains("her"));
            //// END SOLUTION ////
        }

        // Return the fifth word in the sequence, if there is one. If there are
        // fewer than 5 words, then return null.
        public static string GetFifthWordIfItExists(IEnumerable<string> words)
        {
            // Uncomment:
            // return words.???();
            //// START SOLUTION ////
            return words.ElementAtOrDefault(4);
            //// END SOLUTION ////
        }

        // Return the last word in the sequence. If there are no words in
        // the sequence, return null.
        public static string GetLastWordIfAny(IEnumerable<string> words)
        {
            // Uncomment:
            // return words.???();
            //// START SOLUTION ////
            return words.LastOrDefault();
            //// END SOLUTION ////
        }
    }
}