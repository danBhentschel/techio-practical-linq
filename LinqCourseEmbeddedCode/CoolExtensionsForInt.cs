using System;
using System.Collections.Generic;
using System.Text;

//// START EMBED: Example extension method declaration ////
namespace IntExtensions
{
    public static class CoolExtensionsForInt
    {
        public static string Growl(this int num)
        {
            return $"G{new string('r', num)}";
        }
    }
}
//// END EMBED ////