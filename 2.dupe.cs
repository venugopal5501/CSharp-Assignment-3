using System;
class duplicate
{
    public static void Main(string[] args)
    {
        int count = 0;
        Console.Write("Enter length of an array : ");
        int a = Convert.ToInt32(Console.ReadLine());
        int[] arr = new int[a];
        for (int i = 0; i < a; i++)
        {
            arr[i] = Convert.ToInt32(Console.ReadLine());
        }
        for (int i = 0; i < a; i++)
        {
            for (int j = i + 1; j < a; j++)
            {
                if (arr[i] == arr[j])
                {
                    count++;
                    break;
                }
            }
        }

        for(int i=0;i<a;i++){
            Console.Write(arr[i]+" ");
        }
        Console.WriteLine("\n"+"The duplicate elements are : "+count);
    }
}