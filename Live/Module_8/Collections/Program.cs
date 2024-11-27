using System.Collections;

namespace Collections;

internal class Program
{
    static void Main(string[] args)
    {
        //ArrayList list = new ArrayList();
        List<int> list = new List<int>();
        list.Add(1);
        list.Add(2);
        list.Add(3);
        //list.Add("4");
        list.Add(4);

        foreach (int item in list)
        {
            Console.WriteLine(item);
        }

        Dictionary<string, int> dict = new Dictionary<string, int>();
        dict.Add("een", 1);
        dict.Add("twee", 2);
        dict.Add("drie", 3);


        Console.WriteLine(dict["twee"]);
    }
}
