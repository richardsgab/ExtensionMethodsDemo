namespace ExtensionsLibrary
{
    public static class ExtensionPerson
    {
        public static string FullName(this Person person)//means that "extends"class Person
        {
            return person.FirstName + " " + person.LastName;
        }
    }
}
