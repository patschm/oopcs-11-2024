namespace TheFirm;


// Bokito _IMPELENTEERT_ de interface IContract
internal class Bokito : IContract, IZoo
{
    public void Show()
    {
        Console.WriteLine("Bokito slaat op zijn borst");
    }

    public void Werken()
    {
        Console.WriteLine("Bokito ramt dames in elkaar");
    }

}
