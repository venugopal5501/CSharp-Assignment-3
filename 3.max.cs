using System;
class maximum
{
    public static void Main(string[] args)
    {
        Console.Write("Enter the length");
        int len = Convert.ToInt32(Console.ReadLine());
        int[] arr = new int[len];
        for (int i = 0; i < len; i++)
        {
            arr[i] = Convert.ToInt32(Console.ReadLine());
        }
        for (int i = 0; i < len - 1; i++)
        {
            for (int j = 0; j < len - 1; j++)
            {
                if (arr[j] > arr[j + 1])
                {
                    int temp = arr[j];
                    arr[j] = arr[j + 1];
                    arr[j + 1] = temp;
                }
            }

        }
        for (int i = 0; i < len; i++)
        {
            Console.Write(arr[i] + " ");

        }
        Console.WriteLine("The smallest element is : " + arr[0]);
        Console.WriteLine("The Largest element is : " + arr[arr.Length - 1]);
    }
}