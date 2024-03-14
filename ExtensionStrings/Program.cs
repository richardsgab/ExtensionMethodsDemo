// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");

/*Start();
void Start()
{
    SayHello();
    SayChaoToOldFramework();
}

void SayHello()
{
    Console.WriteLine("Hola wns");
}
void SayChaoToOldFramework()
{
    Console.WriteLine("Chao Framework");
}*/

using ExtensionStrings;

Main();

void Main()//To access the class Person
{
    Person person = new Person();
    person.Id = 1;
    person.FirstName = "Rik";
    person.LastName = "Delon";
    
    Console.WriteLine(person.FullName());//This is the call to the extension method
    Print();

    ExtensionStringsType.IsPalindroom("kayak");
    ExtensionStringsType.IsPalindroom("ball");
    
}
void Print()
{
    Console.WriteLine(new string('_', 60));
    30.Lijn();//calling the extension method
    80.Lijn();
    int u = 100;
    u.Lijn();    
}