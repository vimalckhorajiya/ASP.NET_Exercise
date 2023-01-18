using System;

namespace MyApplication
{
    class Rectangle
    {
        public int l, b;

        public Rectangle(int l, int b)
        {
            this.l = l;
            this.b = b;
        }
        public void printAreaR()
        {
            Console.WriteLine("Area of a rectangle : " + (l * b));
        }

        public void printPerimeterR()
        {
            Console.WriteLine("Perimeter of a rectangle : " + 2 * (l + b));
        }

    }

    class Square : Rectangle
    {
        int s;
        public Square(int l, int b) : base(l, b)
        {
            this.s = l;
            printArea();
            printPerimeter();

        }

        public void printArea()
        {
            Console.WriteLine("Area of a Square : " + Math.Pow(s,2));
        }

        public void printPerimeter()
        {
            Console.WriteLine("Perimeter of a Square : " + 2 * l);
        }
    }
    class Manager
    {
        class Program
        {
            static void Main(string[] args)
            {
                Square sq = new(12,20);
                sq.printAreaR();
                sq.printPerimeterR();
            }
        }
    }
}