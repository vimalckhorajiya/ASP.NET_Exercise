using System;

namespace MyApplication
{
    class Laptop : LaptopBase                     // derived class (child)
    {
        public void LaptopDetails(string name, string price, string processor, string ram, string hdd)
        {
            Console.WriteLine("Name : " + name);
            Console.WriteLine("Price : " + price);
            Console.WriteLine("Processor : " + processor);
            Console.WriteLine("RAM : " + ram);
            Console.WriteLine("HDD : " + hdd);

        }

    }
}