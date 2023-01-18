using System;

namespace MyApplication
{
    class Program
    {
        static void Main (string[] args)
        {
            Laptop myLaptop = new Laptop();
            myLaptop.LaptopDetails(Laptop.Name1, Laptop.Price1, Laptop.Processor1, Laptop.RAM1, Laptop.HDD1);
            Console.WriteLine();
            myLaptop.LaptopDetails(Laptop.Name2, Laptop.Price2, Laptop.Processor2, Laptop.RAM2, Laptop.HDD2);
            Console.WriteLine();
            myLaptop.LaptopDetails(Laptop.Name3, Laptop.Price3, Laptop.Processor3, Laptop.RAM3, Laptop.HDD3);
            Console.WriteLine();
            myLaptop.LaptopDetails(Laptop.Name4, Laptop.Price4, Laptop.Processor4, Laptop.RAM4, Laptop.HDD4);
            Console.WriteLine();
            
        }
    
    }
}