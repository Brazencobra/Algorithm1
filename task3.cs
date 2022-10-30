using System;

namespace Task3
{
    class Program
    {
        static void Main(string[] args)
        {
            char Herf;
            Console.WriteLine("Azerbaycan dili ucun-a | Rus dili ucun-r herfini daxil edin:");
            Herf = Convert.ToChar(Console.ReadLine());
            if (true)
            {

                   
                if (Herf == 'a')
                {
                    Console.WriteLine("Azerbaycan dilini secdiniz");
                } 
                if (Herf == 'A')
                {
                    Console.WriteLine("Azerbaycan dilini secdiniz");
                }
                if (Herf == 'R')
                {
                    Console.WriteLine("Rus dilini secdiniz");
                }
                if (Herf == 'r')
                {
                    Console.WriteLine("Rus dilini secdiniz");
                }
                
            }
            else
            {
                Console.WriteLine("Yanlis sorgu");
            }
        }
    }
}
