using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace LINQFundamentals
{
    class Program
    {
        static void Main(string[] args)
        {
            ShowEvenNumbers();
        }

        private static void ShowEvenNumbers()
        {
            var numbers = Enumerable.Range(1, 30);
            var evenNumbers = from number in numbers
                where number%2 == 0
                select number;

            foreach (var number in evenNumbers)
            {
                Console.WriteLine("Even number: {0}", number);
            }
            Console.WriteLine("Press any key to continue...");
            Console.ReadKey(true);
        }
    }
}
