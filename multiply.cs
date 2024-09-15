using System;
class multiplication
{
    public static void Main(string[] args)
    {
        Console.Write("Enter the size of the square matrices");
        int row = Convert.ToInt32(Console.ReadLine());
        int[,] arr1 = new int[row, row];
        int[,] arr2 = new int[row, row];
        int[,] res = new int[row, row];
        Console.Write("Enter elements for Matrix A: ");
        for (int i = 0; i < row; i++)
        {
            for (int j = 0; j < row; j++)
            {
                arr1[i, j] = Convert.ToInt32(Console.ReadLine());
            }
        }
        Console.Write("Enter elements for Matrix B: ");
        for (int i = 0; i < row; i++)
        {
            for (int j = 0; j < row; j++)
            {
                arr2[i, j] = Convert.ToInt32(Console.ReadLine());
            }
        }
        for (int i = 0; i < row; i++)
        {
            for (int j = 0; j < row; j++)
            {
                res[i, j] = 0;
                for (int k = 0; k < row; k++)
                {
                    res[i, j] = res[i, j] + arr1[i, k] * arr2[k, j];
                }
            }
        }
        for (int i = 0; i < row; i++)
        {
            for (int j = 0; j < row; j++)
            {
                Console.Write(res[i, j] + " ");
            }
            Console.WriteLine();
        }
    }
}