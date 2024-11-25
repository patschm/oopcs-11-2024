namespace Collections;

internal class Program
{
    static void Main(string[] args)
    {
        int[] array;
        array = [ 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 ];
        array[0] = 1;
        //array[10] = 2
        int[] array2 = [.. array, 11];
        Console.WriteLine(array2[^2]);

        int[,] matrix = new int[2, 3] { { 1, 2, 3 }, { 4, 5, 6 } };
        Console.WriteLine(matrix[0,1]);

        DateTime[] data = new DateTime[10];

        for(int i = 0; i < array2.Length; i++)
        {
            int tmp = array2[i];
            Console.WriteLine(tmp);
        }

        foreach(int tmp in array2)
        {
            Console.WriteLine(tmp);
        }
    }
}
