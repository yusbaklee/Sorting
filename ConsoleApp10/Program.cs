using System;
using System.Linq;

class program
{
    public static void Main()
    {
        int[] arr = new int[] { 1, 9, 4, 8, 3, 7 };
        arr = arr.OrderByDescending(a => a).ToArray();
        foreach (int value in arr)
        {
            Console.WriteLine(value + " ");
        }

    }
}

        