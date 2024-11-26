namespace TheFirm;

internal class Ruben : Employee
{
    public void SchroeftSneller()
    {
        Console.WriteLine("Ruben schroeft super snel ik elkaar");
    }

    public override void Werkt()
    {
        SchroeftSneller();
    }
}
