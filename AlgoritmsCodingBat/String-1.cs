using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AlgoritmsCodingBat
{
    public class String_1
    {
        /*
         * Given 2 strings, a and b, return a new string made of the first char of a and the last char of b, so "yo"
         *  and "java" yields "ya". If either string is length 0, use '@' for its missing char.
         *  
         *  lastChars("last", "chars") → "ls"
         *  lastChars("yo", "java") → "ya"
         *  lastChars("hi", "") → "h@"
         */
        public String LastChars(string a, string b)
        {
            int aLen = a.Length;
            int bLen = b.Length;
            string aStr = "@";
            string bStr = "@";

            if (aLen != 0)
            {
                aStr = a.Substring(0, 1);
            }
            if (bLen != 0)
            {
                bStr = b.Substring(bLen - 1,1);
            }
            return aStr + bStr;
        }

        /*
         * Given two strings, append them together (known as "concatenation") and return the result. 
         * However, if the concatenation creates a double-char, then omit one of the chars, so "abc" and "cat" yields "abcat".
         * 
         * conCat("abc", "cat") → "abcat"
         * conCat("dog", "cat") → "dogcat"
         * conCat("abc", "") → "abc"         * 
         */
         public String ConCat(String a, String b)
        {
            if (a.Length != 0 && b.Length != 0
                  && a[a.Length - 1] == b[0])
                return a + b.Substring(1);
            return a + b;
        }

        /*
         * Given a string of any length, return a new string where the last 2 chars, if present, 
         * are swapped, so "coding" yields "codign".
         * 
         * lastTwo("coding") → "codign"
         * lastTwo("cat") → "cta"
         * lastTwo("ab") → "ba"
         *  
         */
        public String LastTwo(String str)
        {
            int strLen = str.Length;

            if (strLen > 1)
            {
                string part1 = str.Substring(0, strLen - 2);
                string swap1 = "" + str[strLen - 1] + str[strLen - 2];
                //string swap = str.Substring(strLen-1) + str.Substring(strLen-2,1);
                return part1 + swap1;
            }
          
            return str;
        }
    }

}
