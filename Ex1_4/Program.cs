using System;

namespace MyApplication
{
    class Program
    {
        static void Main (string[] args)
        {
        int n1 = 0, n2 = 1, n3;
        Console.Write("Enter the Number of Elements : ");    
        int totalElement = Convert.ToInt32(Console.ReadLine());
        
        Console.Write(n1 + " " + n2 + " ");
        for(int i = 0; i < totalElement; i++)
        {
          n3 = n1 + n2;
          Console.Write(n3 + " ");
          n1 = n2;
          n2 = n3;
        }
        }

    }
}