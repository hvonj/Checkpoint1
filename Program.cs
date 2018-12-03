using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
namespace Checkpoint01
{
    class Program
    {
        static void Main(string[] args)
        {
            Triangle();
        }

        static void Triangle()
        {
            Console.Write("Write command: ");
            Console.ForegroundColor = ConsoleColor.Green;
            string input = Console.ReadLine();
            string[] number = input.Split('-');
            
            //TODO Change to unicode symbol.
            int i, k;

            Console.ForegroundColor = ConsoleColor.White;
            foreach (var item in number)
            {
                int itemNy = int.Parse(item);
                for (i = 1; i <= itemNy; i++)
                {
                    for (k = 1; k <= i; k++)
                    {
                        Console.Write("*");
                    }
                    Console.WriteLine();
                }
            }

        }
        
    }

}