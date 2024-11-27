
using System.Text;

namespace Swapper;

internal class Program
{
    static void Main(string[] args)
    {
        var s = Create<StringBuilder>();
        s.Append("Ha");
        Console.WriteLine(s.ToString());

        Point<double> a = new Point<double> { X = 100, Y = 200 };
        Point<double> b = new Point<double> { X = 1000, Y = 2000 };
        //Console.WriteLine(p1);

        //int a = 10;
        //int b = 20;
        Console.WriteLine($"a={a}, b={b}");
        Swap(ref a, ref b);
        Console.WriteLine($"a={a}, b={b}");
    }

    static T Create<T>() where T : new()
    {
        T tmp = new T();
        return tmp;
    }

    static void Swap<T>(ref T a, ref T b) //where T: IFormattable
    {
        T tmp = a;
        a = b;
        b = tmp;
    }
    //static void Swap(ref float a, ref float b)
    //{
    //    float tmp = a;
    //    a = b;
    //    b = tmp;
    //}
    //static void Swap(ref long a, ref long b)
    //{
    //    long tmp = a;
    //    a = b;
    //    b = tmp;
    //}
    //static void Swap(ref int a, ref int b)
    //{
    //    int tmp = a;
    //    a = b; 
    //    b = tmp;
    //}
}
