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



using ExtensionsLibrary;

Main();

void Main()//To access the class Person
{
    Person person = new Person();
    person.Id = 1;
    person.FirstName = "Rik";
    person.LastName = "Delon";
    
    Console.WriteLine(person.FullName());//This is the call to the extension method
    Print();
    IsPalindroom();
    SpecialPrint();
    PascalCaseFromAnyWord();

    WordtellenExemple();
    Console.WriteLine("Une phrase avec beaucoup plus de mots que la première phrase".WoordTeller());

    
}
void Print()
{
    Console.WriteLine(new string('_', 60));
    30.Lijn();//calling the extension method
    80.Lijn();
    int u = 100;
    u.Lijn();

    string exemple = "bonjour à tous";
    (exemple.Length + 4).Lijn();
    Console.WriteLine($"· {exemple} ·");
    (exemple.Length + 4).Lijn();
}
void IsPalindroom()
{
    /* string str = "lepel";
     bool ispalindromm = str.IsPalindroom();*/
    Console.WriteLine("Is not");
    Console.WriteLine("lepel".IsPalindroom());
}
void WordtellenExemple()
{
    Console.WriteLine("Une phrase avec beaucoup de mots".WoordTeller());
    string zin = "Dit is een voorbeeld zin";
    int quantity = zin.WoordTeller();
    Console.WriteLine($"aantal woorden is: {quantity}");    
}
void SpecialPrint()
{
    40.SpeciaalLijn('¨');
    60.SpeciaalLijn('^');
    ExtensionsINT.SpeciaalLijn(20, 'ù');//this is normal method call, not extension method
}
void PascalCaseFromAnyWord()
{
    string str = "hOlA aMIgOS dEL baRRiO";
    str.FirstLetterToUpper();
}