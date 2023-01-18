using System;

namespace MyApplication
{
    class Class1                         // parent class
    {
        public void MyMethod1()          // method of a parent class(Class1)
        {
            Console.WriteLine("This is parent class.");
        }

    }

    class Class2 : Class1                // child class
    {
        public void MyMethod2()          // method of a child class(Class2)
        {
            Console.WriteLine("This is child class.");
        }
      
    }

    class Program
    {
        static void Main (string[] args)
        {
            Class1 myClass1 = new Class1();      // create myClass1 object for parent class(Class1)
            Class2 myClass2 = new Class2();      // create myClass2 object for child class(Class2)
            myClass1.MyMethod1();                // call method of parent class by object of parent class
            myClass2.MyMethod2();                // call method of child class by object of child class
            myClass2.MyMethod1();                // call method of parent class by object of child class
        }
    }


}