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
    }
}
