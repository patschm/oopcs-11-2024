
namespace Punten;

internal class Program
{
    static void Main(string[] args)
    {
        DateTime d1 = DateTime.Now; 
        Complex c1 = new Complex { Real = 10, Imaginary = 20 };
        Console.WriteLine(c1);
        DoeIets(c1);
        Console.WriteLine(c1);
    }

    private static void DoeIets(Complex ccc)
    {
        ccc.Imaginary = 2000;
        ccc.Real = 1000;
    }
}
