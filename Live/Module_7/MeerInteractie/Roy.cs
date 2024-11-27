namespace MeerInteractie;

delegate void Naam();

internal class Roy
{
    public void Execute(Naam functie)
    {
        Console.WriteLine("Roy gaat het volgende doen");
        functie();
    }
}
