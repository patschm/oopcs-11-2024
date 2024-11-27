namespace Radio;

delegate void Ontvang(string text);

internal class RadioStation
{

    public event Ontvang subscribers;

    public void Broadcast()
    {
        Console.WriteLine("Zend uit");
        if (subscribers != null)
        {
            subscribers("Hallo luisteraars");
        }
    }
}
