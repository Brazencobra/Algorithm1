using System;

namespace Task1
{
    class Program
    {
        static void Main(string[] args)
        {
            int number, result = 0;
            Console.Write("Ededi daxil edin:");
            number = Convert.ToInt32(Console.ReadLine());

            if (number > 0)
            {



                while (number > 0)
                {
                    result += number % 10;
                    number = number / 10;
                }
                Console.WriteLine("Daxil edilen ededin reqemleri cemi:" + result);
                Console.ReadLine();
            }

            else
            {
                Console.WriteLine("Serte uygun eded daxil edin");
            }
        }
    }
}
