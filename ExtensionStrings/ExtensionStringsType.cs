using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExtensionStrings
{
    public static class ExtensionStringsType
    {
        public static bool IsPalindroom(this string str)
        {
            char[] charArray = str.ToCharArray();
            Array.Reverse(charArray);
            string reverse =  new string(charArray);
            if(reverse != str)
            {
                Console.WriteLine("Is not");
                return false;
            }
            Console.WriteLine("Is Palindrome");
            return true;
        }
        public static int WoordTeller(this string str) 
        {
            string[] subs = str.Split(' ');
            int count = 0;
            foreach ( var sub in subs)
            {
                count++;
            }
            return count;
        }

        public static void FirstLetterToUpper(this string str) 
        {
            Console.WriteLine("primavera");

            str = str.ToLower();
            string[] subs = str.Split(' ');
            for (int i = 0; i < subs.Length; i++)
            {
                for (int j = 0; j < subs[i].Length;)
                {
                    if (j == 0)
                    {
                        subs[j].ToUpper();
                    }
                    char[] subs2 = subs[i].ToCharArray();
                }

                Console.WriteLine(subs[i]);
            }
        }
    }
}
