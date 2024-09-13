using System;
class reversed
{
    public static void Main(string[] args)
    {
        Console.Write("Enter Number : ");
        int a = Convert.ToInt32(Console.ReadLine());
        int[] array = new int[a];
        for (int i = 0; i < a; i++)
        {
            array[i] = Convert.ToInt32(Console.ReadLine());
        }
        Console.Write("The reversed array is : ");
        for(int i=a-1;i>=0;i--){
            Console.Write(array[i]+" ");
        }
       
        
    }
}
