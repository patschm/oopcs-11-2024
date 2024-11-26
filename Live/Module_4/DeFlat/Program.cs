using System.Linq.Expressions;
using System.Runtime.CompilerServices;

namespace DeFlat;

internal class Program
{
    static void DoeIets()
    {

    }
    static void Main(string[] args)
    {
        Point p1 = new Point { X = 10, Y = 20 };
        p1.Show();
        Point p2 = new Point { X = 100, Y = 200 };
        p2.Show();

        Console.WriteLine(p1 != p2);

        //Point p3 = Point.Add(p1, p2);
        Point p3 = p1 + p2;
        p3.Show();

        //Program.DoeIets();
        Lift lift = new Lift();
        Etage.Elevator = lift;

        Etage[] flat = new Etage[50];
        for (int i = 0; i < flat.Length; i++)
        {
            flat[i] = new Etage { EtageNummer = i };
        }


        flat[33].CallElevator();

        foreach(var etage in flat)
        {
            //etage.ShowElevatorStatus();
            //Etage.ShowElevatorStatus();
        }
    }
}
