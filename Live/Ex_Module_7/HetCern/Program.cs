namespace HetCern;

internal class Program
{
    static void Main(string[] args)
    {
        WillemKlein wk = new WillemKlein();
        SimonVanDeMeer simon = new SimonVanDeMeer();

        //wk.Reken(simon.Add, 1, 2);
        //wk.Reken(simon.Subtract, 3, 4);

        int x = 10;
        MathDel m1 = simon.Add;
        m1 += simon.Add;
        m1 += simon.Subtract;
        m1 += simon.Subtract;

        foreach(var mi in m1.GetInvocationList())
        {
            Console.WriteLine(mi.Method.Name);
        }

        var result = m1(1, 2);

        Console.WriteLine(result);

    }
}
