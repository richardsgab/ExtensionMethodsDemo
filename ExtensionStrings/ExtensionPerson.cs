using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace ExtensionStrings
{
    public static class ExtensionPerson
    {
        public static string FullName(this Person person)
        {
            return person.FirstName + " " + person.LastName;
        }
    }
}
