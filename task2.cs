using System;

namespace Task2
{
    class Program
    {
        static void Main(string[] args)
        {
            int number;
            Console.Write("Ededi daxil edin:");
            number = Convert.ToInt32(Console.ReadLine());

            int a = number / 100;
            int b = (number / 10) - a * 10;
            int c = number % 10;
            
            

            if (a == b && a == c && b == c)
            {
                Console.WriteLine("Butun reqemler beraberdir");
            }
            else
            {
                Console.WriteLine("Butun reqemler beraber deyil");
            }
        }
    }
}
