using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExtensionStrings
{
    public class Person
    {
        public int Id { get; set; }
        public string FirstName { get; set; }//"?" = allows null values -- string?
        public string LastName { get; set; }
        public int Age { get; set; }


    }
}
