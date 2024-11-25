
namespace FuncProcs;

internal class Program
{
    static void Main(string[] args)
    {
        int result = TelOp( 1, 2, 3, 4, 5, 6, 7, 8 );
        ToonNummer(result, "De optelling is");


        ToonWelkomsScherm();
        string? inputa = VraagGebruikerOmEenGetal();
        double a = 0;
        if (IsValid(inputa))
        {
            a = ConvertToNumber(inputa);
            ToonNummer(a);
        }
        string? inputb = VraagGebruikerOmEenGetal();
        double b = 0;
        if (IsValid(inputb))
        {
            b = ConvertToNumber(inputb);
            ToonNummer(b);
        }
        double resultaat = TelOp(a, b);
        ToonNummer(resultaat, "Het resultaat van de optelling is");
        ToonAfscheidsScherm();
    }

    static int TelOp(params int[] nrs)
    {
        return nrs.Sum();
    }
    static int TelOp(int a, int b)
    {
        return a + b;
    }
    static double TelOp(double a, double b)
    {
        return a + b;
    }

    static void ToonAfscheidsScherm()
    {
        Console.WriteLine("Tot ziens");
    }
    static void ToonNummer(int nr, string label= "Het opgegeven nummer is")
    {
        Console.WriteLine($"{label} {nr}");
    }
    static void ToonNummer(double nr, string label = "Het opgegeven nummer is")
    {
        Console.WriteLine($"{label} {nr}");
    }
    static double ConvertToNumber(string? input)
    {
        return double.Parse(input!);
    }
    static bool IsValid(string inp)
    {
        if (inp != null) return true;
        Console.WriteLine("Ongeldige invoer");
        return false;
    }
    static string? VraagGebruikerOmEenGetal()
    {
        Console.WriteLine("Geef een getal");
        string? input = Console.ReadLine();
        return input;
    }
    static void ToonWelkomsScherm()
    {
        Console.WriteLine("Welkom");
    }
}
