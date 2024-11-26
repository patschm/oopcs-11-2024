
namespace TheFirm;

internal class Engjell : Employee
{
    public void DoetMoeilijk()
    {
        Console.WriteLine("Engjell doet moeilijk");
    }

    public override void Werkt()
    {
        DoetMoeilijk();
    }
}
