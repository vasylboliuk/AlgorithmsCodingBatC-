using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace AlgoritmsCodingBat
{
    public class String_3
    {

        /*
         * Given a string, count the number of words ending in 'y' or 'z' -- so the 'y' in "heavy" 
         * and the 'z' in "fez" count, but not the 'y' in "yellow" (not case sensitive). 
         * We'll say that a y or z is at the end of a word if there is not an alphabetic letter immediately following it. 
         * (Note: Character.isLetter(char) tests if a char is an alphabetic letter.)
         * 
         * countYZ("fez day") → 2
         * countYZ("day fez") → 2
         * countYZ("day fyyyz") → 2
         */
        public int CountYZ(String str)
        {
            String[] list = Regex.Split(str, "[^a-zA-Z]+");
            int count = 0;

            foreach (string s in list)
            {
                String s2 = s.ToLower();

                char[] listChars = s2.ToCharArray();

                if (s2 != null && s2.Length != 0 && ((s2.Substring(s.Length - 1).Equals("z") || s2.Substring(s.Length - 1).Equals("y"))))
                {
                    count++;
                }

            }
            return count;
        }


        /*
         * Given a string, return the longest substring that appears at both the 
         * beginning and end of the string without overlapping. 
         * For example, sameEnds("abXab") is "ab".
         *
         * sameEnds("abXYab") → "ab"
         * sameEnds("xx") → "x"
         * sameEnds("xxx") → "x"
         */
        public String SameEnds(String str)
        {
            String result = "";
            int mid = str.Length / 2;
            String part1 = "";
            String part2 = "";
            int lengthPart1 = mid;
            int lengthPart2 = mid;
            if (str.Length % 2 == 1)
            {
                lengthPart2 = lengthPart2 + 1;
                part1 = str.Substring(0, lengthPart1);
                part2 = str.Substring(lengthPart2);
            }
            else
            {
                part1 = str.Substring(0, lengthPart1);
                part2 = str.Substring(lengthPart2);
            }

            bool isPart1EqualsPart2 = part1.Equals(part2);
            if (isPart1EqualsPart2 == true)
            {
                result = part1;
            }

            while (isPart1EqualsPart2 == false)
            {
                if (!part1.Equals(part2) && str.Length % 2 == 0)
                {
                    lengthPart1 = lengthPart1 - 1;
                    lengthPart2 = lengthPart2 + 1;
                    part1 = str.Substring(0, lengthPart1);
                    part2 = str.Substring(lengthPart2);
                }
                else
                {
                    result = str.Substring(0, lengthPart1);
                    isPart1EqualsPart2 = true;
                }

            }
            return result;
        }

        /*
         * Given a string, look for a mirror image (backwards) string at both the beginning and end of the given string. 
         * In other words, zero or more characters at the very begining of the given string, 
         * and at the very end of the string in reverse order (possibly overlapping). For example, 
         * the string "abXYZba" has the mirror end "ab".
         * 
         * mirrorEnds("abXYZba") → "ab"
         * mirrorEnds("abca") → "a"
         * mirrorEnds("aba") → "aba"
         * */
        public String MirrorEnds(string str)
        {
            string result = "";
            string part1 = "";
            string part2 = "";

            int mid = str.Length / 2;
            int lengthPart1 = mid;
            int lengthPart2 = mid;

            if (str.Length % 2 == 1)
            {
                lengthPart1 = lengthPart1 + 1;
                part1 = str.Substring(0, lengthPart1);
                part2 = str.Substring(lengthPart2);
            }
            else
            {
                part1 = str.Substring(0, lengthPart1);
                part2 = str.Substring(lengthPart2);
            }

            char[] part1List = part1.ToCharArray();
            char[] part2List = part2.ToCharArray();

            for (int i = 0; i < lengthPart1; i++)
            {
                if (part1List[i] == part2List[(lengthPart1 - 1) - i])
                {
                    result = result + part1List[i];
                }
                else
                {
                    break;
                }
            }
            if (result == part1) return str;

            return result;
        }
    }
}
