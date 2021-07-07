using System;

namespace logicoperators
{
    class Veera
    {
        static void Main(string[] args)
        {
            string veera, bhadra;
            int myint1, myint2;

            Console.WriteLine("Enter String :");
            veera = Console.ReadLine();

            Console.WriteLine("Enter another string to compare :");
            bhadra = Console.ReadLine();

            Console.WriteLine("Enter a number :");
            myint1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter another number to compare :");
            myint2 = Convert.ToInt32(Console.ReadLine());

            if (veera == bhadra && myint1 == myint2)
                Console.WriteLine("True");
            else
                Console.WriteLine("False");
        }
    }
}
