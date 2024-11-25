namespace Objecten;

// De blauwdruk van een lamp
class Lamp
{
    // Alles wat tussen deze {} staat, zijn members

    // Eigenschappen van de lamp, leg ik vast in fields
    // (Veredelde variabelen)
    // Hierin sla ik de eigenschappen op.
    private int _intensiteit = 100;
    //private ConsoleColor _kleur = ConsoleColor.Yellow;

    //public void SetIntensiteit(int waarde)
    //{
    //    if (waarde >= 0 && waarde <= 2000)
    //    {
    //        _intensiteit = waarde;
    //    }
    //}
    //public int GetIntensiteit()
    //{
    //    return _intensiteit;
    //}

    // Properties. Met properties controleer ik de waardes die aan de fields worden
    // toegekend (Encapsulation)
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

    // Auto generating property. Genereert zijn eigen private field
    public ConsoleColor Kleur  { get; set; } = ConsoleColor.Yellow;

    // Gedrag van de lamp leg ik vast in Methods
    // (Veredelde functies/procedures)
    public void Aan()
    {
        Console.ForegroundColor = Kleur;
        Console.WriteLine($"De lamp brandt met {Intensiteit}lumen");
        Console.ResetColor();
    }
    public void Uit()
    {
        Console.ForegroundColor = Kleur;
        Console.WriteLine($"De lamp gaat nu uit");
        Console.ResetColor();
    }

    // Constructors
    // Zijn bedoeld om FIELDS van een initiele waarde te voorzien.
    public Lamp()
    {
        //_intensiteit = 100;
        //_kleur = ConsoleColor.Yellow;
    }
    public Lamp(int intensiteit, ConsoleColor kleur)
    {
        Intensiteit = intensiteit;
        Kleur = kleur;
    }
}