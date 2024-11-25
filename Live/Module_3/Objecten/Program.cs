namespace Objecten;

internal class Program
{
    static void Main(string[] args)
    {
        // Big bang
        //Lamp l1 = new Lamp(300, ConsoleColor.DarkBlue);
        Lamp l1 = new Lamp { Intensiteit = 400, Kleur = ConsoleColor.DarkCyan };
        //l1._intensiteit = 2_000_000_000;
        //l1.SetIntensiteit(-500);
        l1.Intensiteit = 500;
        //l1._kleur = ConsoleColor.Yellow;

        Lamp l2 = new Lamp(-2000, ConsoleColor.Green);
        //l2._intensiteit = 400;
        //l2._kleur = ConsoleColor.Green;

        //l1._kleur = ConsoleColor.Red;
        l1.Aan();

        //l2._intensiteit = 1000;
        //l2.SetIntensiteit(200);
        //l2.Intensiteit = 200;
        l2.Aan();


        // Big Crunch
    }
}



