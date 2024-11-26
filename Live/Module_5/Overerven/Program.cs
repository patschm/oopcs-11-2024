namespace Overerven;

internal class Program
{
    static void Main(string[] args)
    {
        //Lamp l1 = new Lamp { Intensiteit = 200, Kleur = ConsoleColor.DarkMagenta };
        //l1.Aan();

        // Dit noemen we generaliseren.
        Lamp l2 = new TL
        {
            Kleur = ConsoleColor.DarkRed,
            Intensiteit = 300,
            StartTime = 3
        };
        l2.Aan();

        // Vergrootglas op een object.
        (l2 as TL).StartTime = 4;

        OntsteekLamp(l2);
        //OntsteekLamp(l1);

        Lamp l3 = new BouwLamp
        {
            Intensiteit = 2000,
            Kleur = ConsoleColor.Yellow,
            GloeiTijd = 5000
        };
        
        OntsteekLamp(l3);
    }

    static void OntsteekLamp(Lamp t)
    {
        t.Aan();
        t.Uit();
    }
}
