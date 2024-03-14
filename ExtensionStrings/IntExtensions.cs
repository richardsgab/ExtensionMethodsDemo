using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExtensionStrings
{
    public static class IntExtensions
    {
        public static void Lijn(this int aantal)// "this" converts the method in an Extendion method
        {
            Console.WriteLine(new string('_', aantal));
        }
    }
}
