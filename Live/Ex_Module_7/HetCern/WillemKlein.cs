namespace HetCern;

delegate int MathDel(int x, int y);

internal class WillemKlein
{
    public void Reken(MathDel fun, int u, int v)
    {
        Console.WriteLine("Willem Klein gaat nu rekenen...");
        int result = fun(u,v);

        Console.WriteLine($"Willem Klein kraait: Het antwoord is {result}");
    }
}
