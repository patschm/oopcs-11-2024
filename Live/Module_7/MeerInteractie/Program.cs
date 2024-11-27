namespace MeerInteractie;

internal class Program
{
    static void Main(string[] args)
    {
        Patrick p = new Patrick();
        Roy roy = new Roy();
        roy.Execute(p.DoeIets);
        roy.Execute(Explode);
        //p.DoeIets();
    }

    static void Explode()
    {
        Console.WriteLine("Kaboom!!");
    }
}
