using System.Threading.Channels;

namespace EvolutieTheorie;

internal class Program
{
    static void Main(string[] args)
    {
        // 2002. Framework 1.0/1.1
        MathDel m1 = new MathDel(Add);
        int result = m1(1, 2);

        // 2005. Framework 2.0
        MathDel m2 = Add;
        result = m2(2, 3);

        int c = 100;
        MathDel m3 = delegate (int x, int y)
        {
            return x + y + c;
        };
        result = m3(3, 4);

        // 2008. Framework 3.0/3.5
        MathDel m4 = (int x, int y) =>
        {
            return x + y;
        };

        result = m4(4,5);

        MathDel m5 = (x, y) =>
        {
            return x + y;
        };

        result = m5(4, 5);

        MathDel m6 = (x, y) => x + y;
        result = m6(4, 5);

        // Procedures
        Action a1 = () => Console.WriteLine("Hoi");
        a1();

        Action<string> a2 = (s)=>Console.WriteLine(s);
        a2("Aha!");

        // Functions
        Func<int, int, int> m7 = InlineAdd;
        result = m7(6, 7);

        Console.WriteLine(result);

        // 2017
        int InlineAdd(int x, int y)
        {
            return x + y;
        }
    }


    static int Add(int x, int y)
    {
        return x + y;
    }
}

delegate int MathDel(int a, int b);
