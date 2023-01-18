using System;

namespace MyApplication
{
    class Member
    {
        public string name = "";
        public int age;
        public long phone;
        public string address = "";
        public double salary;
        public void printSalary()
        {
            Console.WriteLine(salary);
        }

    }
    class Employee : Member
    {
        public string specialization = "";
        public void MyMethod2()
        {
            Console.WriteLine("This is child class.");
        }

    }

    class Manager : Member
    {
        public string department = "";
        class Program
        {
            static void Main(string[] args)
            {
                Employee emp = new();
                emp.name = "Sanjay";
                emp.age = 30;
                emp.phone = 9876543210;
                emp.address = "America";
                emp.salary = 80000;
                emp.specialization = "Excuses";
                Console.WriteLine(emp.name);
                Console.WriteLine(emp.age);
                Console.WriteLine(emp.phone);
                Console.WriteLine(emp.address);
                emp.printSalary();
                Console.WriteLine("=================================");
                Manager mng = new();
                mng.name = "Vimal";
                mng.age = 22;
                mng.phone = 8887776665;
                mng.address = "India";
                mng.salary = 20000;
                mng.department = "Food & Beverages";
                Console.WriteLine(mng.name);
                Console.WriteLine(mng.age);
                Console.WriteLine(mng.phone);
                Console.WriteLine(mng.address);
                Console.WriteLine(mng.salary);
                Console.ReadLine();
            }
        }
    }
}