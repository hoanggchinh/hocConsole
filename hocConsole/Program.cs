using System;

class Program
{
    static void Main(string[] args)
    {
        int[] arr = new int[10];
        for (int i = 0; i < arr.Length; i++)
        {
            Console.Write("a[" + i + "]: ");
            arr[i] = int.Parse(Console.ReadLine());
            Console.Write("\n");
        }

        int b = 0;
        foreach (int x in arr)
        {
            Console.Write(x);
            if (x > 0 && x % 5 == 0)
            {
                b += x;
            }
        }
        Console.Write("b:"+b);
        
       
        int c = int.Parse(Console.ReadLine());

       
        
        
        
    }
}