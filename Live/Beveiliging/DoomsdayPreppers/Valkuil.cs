using Yunex;

namespace DoomsdayPreppers;

public class Valkuil: IObserver
{
    public void Detecting()
    {
        Open();
    }

    public void Open()
    {
        Console.WriteLine("De valkuil gaat open en scherpe spiezen worden zichtbaar");
    }
}
