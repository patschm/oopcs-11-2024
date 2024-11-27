namespace Radio;

internal class Program
{
    static void Main(string[] args)
    {
        RadioStation r538 = new RadioStation();
        r538.subscribers += ViaSMS;
        r538.subscribers += ViaKabel;
        r538.subscribers += ViaRooksignalen;
        r538.subscribers += ViaEther;
        r538.subscribers += ViaSMS;
        r538.subscribers += ViaKabel;
        r538.subscribers += ViaRooksignalen;
        r538.subscribers += ViaEther;
        r538.subscribers += ViaSMS;
        r538.subscribers += ViaKabel;
        r538.subscribers += ViaRooksignalen;
        r538.subscribers += ViaEther;

        r538.Broadcast();
    }

    static void ViaSMS(string text)
    {
        Console.WriteLine($"Via SMS ontvangen: {text}");
    }
    static void ViaKabel(string text)
    {
        Console.WriteLine($"Via Kabel ontvangen: {text}");
    }
    static void ViaEther(string text)
    {
        Console.WriteLine($"Via Eather ontvangen: {text}");
    }
    static void ViaRooksignalen(string text)
    {
        Console.WriteLine($"Via Rooksignalen ontvangen: {text}");
    }
}
