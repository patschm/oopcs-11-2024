using Yunex;

namespace Philips;

public class Lamp : IObserver
{
    public void Detecting()
    {
        Console.WriteLine("De lamp gaat branden");
    }
}
