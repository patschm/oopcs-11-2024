namespace CustomTypes;

enum WeekDay //: long
{
    Sunday = 1,
    Monday = 2,
    Tuesday = 4,
    Wednesday = 8,
    Thursday = 16,
    Friday = 32,
    Saturday = 64
}

internal class Program
{
    static void Main(string[] args)
    {
        int dayOfWeek = 2;
        WeekDay dow = WeekDay.Monday;
        if (dow >= WeekDay.Monday && dow <= WeekDay.Friday)
        {

        }

        Console.WriteLine((int)dow);
        Console.WriteLine(dow);

        WeekDay dow2 = (WeekDay)7;
        Console.WriteLine(dow2);

    }
}

