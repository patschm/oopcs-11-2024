using System.Xml;

namespace Basics;

internal class Program
{
    static void Main(string[] args)
    {
        // TypeNaam variabeleNaam = literal;
        int age = 10;
        string? name = null;// = "Patrick";
        //string x;
        // Variabele scoop
        {
            var price = 10.5F;
            Console.WriteLine(price);
        }
        //x = "hoi";
        //Console.WriteLine(x);
        var result = 3 + (4 * 5);
        age += 4;

        Console.WriteLine(++age);
        Console.WriteLine(age);

        var res = 2 / 4;
        Console.WriteLine(res);

        bool r2 = false && DoeIets();

        //r2 = true & false;

        Console.WriteLine(r2);

        int? leeftijd = 0;

        Console.WriteLine(leeftijd ?? 42);

        //name = null;
        
         Console.WriteLine(name?.Length);


    }

    static bool DoeIets()
    {
        Console.WriteLine("Doe Iets");
        return false;
    }
}
