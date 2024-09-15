using System;
class transpose
{
    public static void Main(String[] args)
    {
        Console.Write("Enter length of array : ");
        int a = Convert.ToInt32(Console.ReadLine());
        int b = Convert.ToInt32(Console.ReadLine());
        int[,] arr = new int[a, a];
        for (int i = 0; i < a; i++)
        {
            for (int j = 0; j < b; j++)
            {
                arr[i, j] = Convert.ToInt32(Console.ReadLine());
            }

        }
        for (int i = 0; i < a; i++)
        {
            for (int j = 0; j < b; j++)
            {
                Console.Write(arr[i,j]+" ");
            }
            Console.WriteLine();

        }
        for (int i = 0; i < a; i++)
        {
            for (int j = 0; j < b; j++)
            {
                Console.Write(arr[j,i]+" ");
            }
            Console.WriteLine();

        }
    }
}