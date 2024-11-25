namespace Flows;

internal class Program
{
    static void Main(string[] args)
    {
        bool ok = false;
        if (ok)
        {
            Console.WriteLine("Indien true");
        }
        else
        {
            Console.WriteLine("Indien false");
        }

        int age = 16;

        switch (age)
        {
            case 1:
                Console.WriteLine("Leeftijd is een");
                break;
            case 2:
                Console.WriteLine("Leefijd is twee");
                break;
            case 16:
                Console.WriteLine("Leeftijd is 16");
                break;
            case int nr when nr > 20 && nr < 25:
                Console.WriteLine();
                    break;
            case > 25:
                Console.WriteLine("Oud");
                break;
            default:
                Console.WriteLine("Anders");
                break;
        }

        int x = 0;
       // for(int x = 0; x < 10; x++)
        for (Console.WriteLine("Init"); ; Console.WriteLine("Iter") )
        {
            if (++x == 5) continue;
            if (x == 10) break;
            Console.WriteLine(x);
        }

        while(x < 20)
        {
            Console.WriteLine(++x);
        }

        do
        {

        }
        while (x < 30);
    }
}
