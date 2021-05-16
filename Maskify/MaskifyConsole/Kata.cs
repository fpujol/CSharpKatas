using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace MaskifyConsole
{
    //Kata.Maskify("4556364607935616"); // should return "############5616"
    //Kata.Maskify("64607935616");      // should return "#######5616"
    //Kata.Maskify("1");                // should return "1"  
    //Kata.Maskify("");                 // should return ""
    public static class Kata
    {
        public static string MaskifyVersion1(string cc)
        {
            int skipChars = 4;
            if (cc.Length <= skipChars)
                return cc;

            var charsToMaskify = Regex.Replace(cc.Substring(0, cc.Length - skipChars), "[0-9]", "#");
            var secondStr = cc.Substring(cc.Length - skipChars);
            return charsToMaskify + secondStr;

        }

        public static string MaskifyVersion2(string cc)
        {
            int skipChars = 4;
            int charcount = cc.Length;

            if (charcount <= skipChars)
            {
                return cc;
            }

            int startIndex = cc.Length - skipChars;

            string lastFour = cc.Substring(startIndex);

            string masked = lastFour.PadLeft(charcount, '#');

            return masked;
        }
    }
}
