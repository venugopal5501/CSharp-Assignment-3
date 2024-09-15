using System;
class odd{
    public static void Main(String[] args) {
        Console.Write("Enter length of array");
        int a=Convert.ToInt32(Console.ReadLine());
        int []arr=new int[a];
        for(int i=0;i<a;i++){
            arr[i]=Convert.ToInt32(Console.ReadLine());
        }
        for(int i=0;i<a; i++){
            if(i%2!=0){
                Console.Write(arr[i]);
            }
        }
    }
}