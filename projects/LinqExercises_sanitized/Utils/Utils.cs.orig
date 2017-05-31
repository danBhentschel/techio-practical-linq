using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace LinqExercises.Utils
{
    public static class Utils
    {
        public static void CgMessage(string message)
        {
            Console.WriteLine($"TECHIO> message -channel \"exercise results\" \"{message}\"");
        }

        public static void AssertAreEqual(string expected, string actual, string provided)
        {
            if (expected != actual)
            {
                PrintDifference(expected, actual);
            }

            Assert.AreEqual(expected, actual);
            CgMessage($"IN: <{provided}> OUT: <{actual}>");
        }

        private static void PrintDifference(string expected, string actual)
        {
            int offset1 = GetDiffOffest(expected, actual);
            int offset2 = expected.Length - offset1 - 1;
            if (offset2 < 0) offset2 = 0;
            var errCaret = new string(' ', offset1) + '^' +
                           new string(' ', offset2);
            CgMessage($"EXPECTED: <{expected}>  GOT: <{actual}>");
            CgMessage($"           {errCaret}         {errCaret}");
        }

        private static int GetDiffOffest(string expected, string actual)
        {
            var length = Math.Max(expected.Length, actual.Length);
            var ePadded = expected.PadRight(length, ' ');
            var aPadded = actual.PadRight(length, ' ');
            for (var i = 0; i < length; i++)
            {
                if (ePadded[i] != aPadded[i])
                {
                    return i;
                }
            }

            return 0;
        }
    }
}
