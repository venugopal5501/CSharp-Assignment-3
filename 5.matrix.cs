using System;
class matrix
{
    public static void Main(string[] args)
    {
        int c = 0;
        Console.Write("Enter the length 1 ");
        int a = Convert.ToInt32(Console.ReadLine());
        int[] arr = new int[a];

        Console.Write("Enter the length 2 ");

        int b = Convert.ToInt32(Console.ReadLine());
        int[] ar = new int[b];
        for (int i = 0; i < a; i++)
        {
            arr[i] = Convert.ToInt32(Console.ReadLine());

        }
        for (int i = 0; i < a; i++)
        {
            ar[i] = Convert.ToInt32(Console.ReadLine());
        }
        for (int i = 0; i < a; i++)
        {
            Console.Write(arr[i] + " ");
        }
        for (int i = 0; i < a; i++)
        {
            Console.Write(ar[i] + " ");
        }
        Console.WriteLine();

        for (int i = 0; i < a; i++)
        {
            for (int j = 0; j < a; j++)
            {
                if (i == j)
                {
                    c = arr[i] + ar[j];
                    Console.Write(c + " ");
                }
            }
        }


    }
}