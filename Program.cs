using Common_;
using System;
using System.Collections.Generic;
using System.Linq;

namespace ConsoleApplication
{
    class Program
    {
        static void Main(string[] args)
        {
            ShowNumbers(new ZeroGenerator(5));
        }

        public static void ShowNumbers(INumberSequenceGenerator n)
        {
            List<int> list = n.GenerateNumbers().ToList();
            
            for (int i = 0; i < list.Count(); i++)
            {
                Console.WriteLine($"{i}. elem értéke: {list[i]}");
            }
        }
    }
}
