using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExtensionsLibrary
{
    public static class ExtensionsSTRING
    {  
        public static bool IsPalindroom(this string str)//Returna solo bool.Los mensajes no son parte del return.No poenerlos aqui
        {
            char[] charArray = str.ToCharArray();
            Array.Reverse(charArray);
            string reverse = new string(charArray);
            if (reverse != str)
            {
                Console.WriteLine("Is not");//Sacar mensajes del backend.Ademas esto sirve solo para Console apps
                return false;
            }
            Console.WriteLine("Is Palindrome");
            return true;
            #region Salvatore
            //char[] woordChars = woord.ToCharArray();
            //Array.Reverse(woordChars);
            //string woordReverse = new string(woordChars);
            //if (woord.ToLower() == woordReverse.ToLower())
            //{
            //    return true;
            //}
            //else
            //{
            //    return false;
            //}
            #endregion
            #region Zakaria
            //char[] array = str.ToCharArray();
            //string str2 = "";
            //for (int i = array.Length - 1; i >= 0; i--)
            //{
            //    str2 += array[i];
            //}
            //if (str2 == new string(array)) return true;
            //else return false;
            #endregion
            #region Hasan
            //string word = "";

            //for (int i = str.Length - 1; i >= 0; i--)
            //{
            //    word += str[i];
            //}
            //return word.Equals(str);
            #endregion
            #region Dritan
            string reversedText = new string(str.Reverse().ToArray());
            return str.Equals(reversedText);
            #endregion
        }
        public static int WoordTeller(this string str)
        {
            string[] subs = str.Split(' ');
            int count = 0;
            foreach (var sub in subs)
            {
                count++;
            }
            return count;
        }

        public static string FirstLetterToUpper(this string str)//esta es mi version que no logre run
        {
            Console.WriteLine("primavera");

            str = str.ToLower();
            string[] subs = str.Split(' ');
            /*for (int i = 0; i < subs.Length; i++)
            {
                for (int j = 0; j < subs[i].Length;)
                {
                    if (j == 0)
                    {
                        subs[j].ToUpper();
                    }
                    char[] subs2 = subs[i].ToCharArray();
                }*/
            return char.ToUpper(str[0]) + str.Substring(1);

        }
        public static string NaarTitelNotatie(this string str)
        {
            #region Salvatore
            //string[] strArr = str.ToLower().Split().ToArray();
            //List<string> titeList = new List<string>();
            //foreach (string item in strArr)
            //{
            //    string capital = item.Substring(0, 1).ToUpper();
            //    string rest = item.Substring(1).ToLower();
            //    string full = capital + rest;
            //    titeList.Add(full);
            //}

            //return String.Join(" ", titeList);
            #endregion
            #region Hasan
            //string[] words = str.Split(' ');
            //string newWord = "";
            //foreach (var word in words)
            //{
            //    newWord += word[0].ToString().ToUpper() + word.Substring(1).ToLower() + " ";
            //}
            //return newWord;
            #endregion
            #region Zakaria

            //char? firstChar = null;
            //string remaining = "";
            //string totaal = "";
            //foreach (string s in str.Split())
            //{
            //    if (string.IsNullOrWhiteSpace(s))
            //    {
            //        return s;
            //    }

            //    firstChar = char.ToUpper(s[0]);
            //    remaining = s.Substring(1).ToLower();
            //    totaal += firstChar + remaining + " ";
            //}
            //return totaal;

            #endregion
            #region Dritan
            //string[] words = str.ToLower().Split(' ');
            //for (int i = 0; i < words.Length; i++) // separate in substRing and convert to upprt
            //{
            //    if (words[i].Length > 0)
            //    {
            //        words[i] = char.ToUpper(words[i][0]) + words[i].Substring(1);
            //    }
            //}

            //return string.Join(" ", words);
            #endregion
            #region Santiago
            //TextInfo textInfo = new CultureInfo("en-US").TextInfo;
            //return textInfo.ToTitleCase(str.ToLower());
            #endregion
            #region Olesia
            str = str.ToLower();  //  input -> lowercase

            string[] words = str.Split(' ');  // input >> individual words

            for (int i = 0; i < words.Length; i++)   // checking each word
            {
                if (i == 0) // if it's the first word
                {
                    char[] letters = words[i].ToCharArray(); //  word >> of characters
                    letters[0] = char.ToUpper(letters[0]); // Capitalize the first character
                    words[i] = new string(letters); // array >> string

                }
                else //otherwise  word >> lowercase
                {
                    words[i] = words[i].ToLower();
                }
            }

            // modfied words -> single string
            return string.Join(" ", words);
            #endregion
        }
    }
    
}

