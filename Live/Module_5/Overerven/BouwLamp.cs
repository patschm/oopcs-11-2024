namespace Overerven;

internal class BouwLamp : Lamp
{
    public int GloeiTijd { get; set; }

    public override void Aan()
    {
        Console.WriteLine($"De bouwlamp gloeit {GloeiTijd} seconden");
        Console.ForegroundColor = Kleur;
        Console.WriteLine($"De bouwlamp brandt met {Intensiteit} lumen");
    }
    public override void Uit()
    {
        Console.WriteLine("De bouwlamp gaat uit.");
    }
}
