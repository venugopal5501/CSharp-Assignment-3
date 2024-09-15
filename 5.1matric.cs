using System;
class matrix
{
    public static void Main(string[] args)
    {
        int row, column;
        Console.Write("Enter row size : ");
        row = Convert.ToInt32(Console.ReadLine());
        Console.Write("Enter column size : ");
        column = Convert.ToInt32(Console.ReadLine());
        int[,] matrixa = new int[row, column];
        int[,] matrixb = new int[row, column];
        int[,] result = new int[row, column];
        Console.Write("Enter elements for Matrix A");
        for (int i = 0; i < row; i++)
        {


            for (int j = 0; j < column; j++)
            {

                matrixa[i, j] = Convert.ToInt32(Console.ReadLine());
            }
        }
        Console.Write("Enter elements for Matrix B");
        for (int i = 0; i < row; i++)
        {

            for (int j = 0; j < column; j++)
            {
                matrixb[i, j] = Convert.ToInt32(Console.ReadLine());
            }
        }
        for (int i = 0; i < row; i++)
        {


            for (int j = 0; j < column; j++)
            {

                Console.Write(matrixa[i, j] + " ");
            }
            Console.WriteLine();
        }
        for (int i = 0; i < row; i++)
        {


            for (int j = 0; j < column; j++)
            {

                Console.Write(matrixb[i, j] + " ");
            }
            Console.WriteLine();
        }

        ,

        for (int i = 0; i < row; i++)
        {
            for (int j = 0; j < column; j++)
            {
                Console.Write(result[i, j] + " ");
            }
            Console.WriteLine();
        }
    }
}