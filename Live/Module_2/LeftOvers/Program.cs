
namespace LeftOvers;

internal class Program
{
    static void Main(string[] args)
    {
        //int x;
        //int.TryParse("9", out int x);
        DoeIets(c:300);


        int a = 10; int b = 20;
        int result;
        Console.WriteLine($"a={a}, b={b}");
        Swap(ref a, ref b, out result);
        Console.WriteLine($"a={a}, b={b}");
        Console.WriteLine(result);
    }

    static void Swap(ref int aa, ref int bb)
    {
        int tmp = aa;
        aa = bb; 
        bb = tmp;
    }

    private static void Swap(ref int aa, ref int bb, out int result)
    {
        int tmp = aa;
        aa = bb;
        bb = tmp;

        result = aa + bb;
    }

    static void DoeIets(int a = 10, int b = 20, int c = 30)
    {
        Console.WriteLine($"a:{a}, b:{b}, c:{c}");
    }
}
