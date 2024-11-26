namespace Overerven;

// TL Erft nu van Lamp
// Je mag maar van 1 class erven.
// Stel je altijd de vraag: Is het een?
// Kun je die vraag niet met droge ogen met JA beantwoorden, moet je niet erven.
// Sealed: Je kunt niet meer erven van deze class
internal sealed class TL : Lamp
{
    public int StartTime { get; set; }

    // Met override activeer ik polymorfisme
    public override void Aan()
    {
        //base.Aan();
        for(int i = 0; i < StartTime; i++)
        {
            Console.ForegroundColor = Kleur;
            Console.WriteLine("Knipper");
            Console.ResetColor();
            Task.Delay(300).Wait();
        }
         
        Console.ForegroundColor = Kleur;
        Console.WriteLine($"De TL brandt met {Intensiteit} lumen");
        Console.ResetColor();
    }
    public override void Uit()
    {
        Console.ForegroundColor = Kleur;
        Console.WriteLine($"De TL gaat nu uit");
        Console.ResetColor();
    }

}
