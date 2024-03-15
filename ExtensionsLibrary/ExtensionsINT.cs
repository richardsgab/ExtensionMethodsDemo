using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExtensionsLibrary
{
    public static class ExtensionsINT
    {
        public static void Lijn(this int aantal)// "this" converts the method in an Extendion method
        {
            Console.WriteLine(new string('-', aantal));
        }

        public static void SpeciaalLijn(this int aantal, char symbol) //Get two parameters!
        {
            Console.WriteLine(new string(symbol, aantal));
        }
    }
}
