using System;

namespace SwapNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            //Swap numbers without using third variable
            int a = 10;
            int b = 15;
            Console.WriteLine("a is " + a + " and b is " + b);
            a = a + b;
            b = a - b;
            a = a - b;
            Console.WriteLine("After swapping a is " + a + " and b is " + b);
        }

    }
}