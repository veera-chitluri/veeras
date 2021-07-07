using System;

namespace personaldetails
{
    class Program
    {
        static void Main(string[] args)
        {
            string name;
            int salary;
            int Id;
            Console.WriteLine("Enter Your Name");
             name = Console.ReadLine();
            Console.WriteLine("Please mention your Id");
            Id = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Please mention your salary");
            salary = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Name is :"+name);
            Console.WriteLine("Id is :"+Id);
            Console.WriteLine("salary is :"+salary);
            


        }
    }
}
