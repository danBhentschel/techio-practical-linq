using System;
using System.Collections.Generic;
using System.Text;

//// START EMBED: Example extension method with extra parameters ////
namespace IntExtensions
{
    //// START REPLACE: "CoolExtensionsForInt2" ::: "CoolExtensionsForInt" ////
    public static class CoolExtensionsForInt2
    //// END REPLACE ////
    {
        public static string Growl(this int num, char a, char b)
        {
            return $"{a}{new string(b, num)}";
        }
    }
}
//// END EMBED ////