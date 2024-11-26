using System.Runtime.CompilerServices;

namespace DeFlat;

internal class Etage
{
    public int EtageNummer { get; set; } = 0;
    public static Lift Elevator { get; set; }// = new Lift();

    public void CallElevator()
    {
        Etage.Elevator.Call(this.EtageNummer);
    }
    public static void ShowElevatorStatus()
    {
        //this.Eta
        Console.WriteLine($"De lift staat op de {Elevator.CurrentFloor}e verdieping");
    }

    //static Etage()
    //{
    //    Console.WriteLine("Instance Constructor");
    //    Elevator = new Lift();
    //}

}
