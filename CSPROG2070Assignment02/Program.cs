using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PROG2070A02CS
{
    class Program
    {
        static void Main(string[] args)
        {

            bool showMenu = true;

            Console.WriteLine("PROG2070 Assignment 2 - Chris Symons");
            Console.WriteLine($"This is a program that takes three integers as triangle dimensions,\nand returns whether those dimensions create a triangle or not.");
            Console.WriteLine();

            do
            {

                Console.WriteLine("Please select an option from the menu");
                Console.WriteLine("1. Enter triangle dimensions");
                Console.WriteLine("2. Exit");
                string menuChoice = Console.ReadLine();

                switch (menuChoice)
                {
                    case "1":
                        int firstDimension;
                        int secondDimension;
                        int thirdDimension;
                        Console.Clear();
                        Console.Write("Dimension 1: ");
                        int.TryParse(Console.ReadLine(), out firstDimension);
                        Console.WriteLine();
                        Console.Write("Dimension 2: ");
                        int.TryParse(Console.ReadLine(), out secondDimension);
                        Console.WriteLine();
                        Console.Write("Dimension 3: ");
                        int.TryParse(Console.ReadLine(), out thirdDimension);
                        Console.WriteLine();
                        Console.WriteLine(TriangleSolver.Analyze(firstDimension, secondDimension, thirdDimension));
                        Console.WriteLine();
                        Console.WriteLine("Press any key to continue..");
                        Console.ReadKey();
                        Console.Clear();
                        break;
                    case "2":
                        Environment.Exit(0);
                        break;
                    default:
                        Console.Clear();
                        break;
                }

            } while (showMenu);

        }
    }
}
