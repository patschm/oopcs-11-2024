namespace Overerven;

internal abstract class Lamp
{
    protected int _intensiteit = 100;
    public int Intensiteit
    {
        get
        {
            return _intensiteit;
        }
        set
        {
            if (value >= 0 && value <= 2000)
            {
                _intensiteit = value;
            }
        }
    }
    public ConsoleColor Kleur { get; set; } = ConsoleColor.Yellow;
    
    // Met virtual geef i aan dat het Aan-gedrag polymorf KAN zijn.
    // Polymorfisme is optioneel.
    public virtual void Aan()
    {
        Console.ForegroundColor = Kleur;
        Console.WriteLine($"De lamp brandt met {Intensiteit} lumen");
        Console.ResetColor();
    }
    // abstract DWINGT afgeleide classen to het implementeren van dit gedrag
    public abstract void Uit();
    //{
    //    Console.ForegroundColor = Kleur;
    //    Console.WriteLine($"De lamp gaat nu uit");
    //    Console.ResetColor();
    //}
}
