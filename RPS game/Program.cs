using System;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Security.Cryptography;

namespace ConsoleApp1
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine($"Rock (1), Paper (2), or Scissors (3)?");
            int Selection;
            if (!int.TryParse(Console.ReadLine(), out Selection))
            {
                Console.WriteLine("Make sure what you wrote is a number!");
                Main();
            }
            Random randomnumber = new Random();
            int genRand = randomnumber.Next(1, 4);
            string SelectionVariable = "tbd";
            switch (Selection)
            {
                case 1:
                    SelectionVariable = "Rock";
                    break;
                case 2:
                    SelectionVariable = "Paper";
                    break;
                case 3:
                    SelectionVariable = "Scissors";
                    break;
                default:
                    Console.WriteLine($"That was not a valid answer!");
                    Main();
                    break;
            }
            switch (genRand)
            {
                case 1:
                    if (genRand == Selection)
                    {
                        Console.WriteLine($"The CPU chose Rock! You chose {SelectionVariable}, it's a tie!");
                    }
                    if (Selection == 2)
                    {
                        Console.WriteLine($"The CPU chose Rock! You chose {SelectionVariable}, you won!");
                    }
                    if (Selection == 3)
                    {
                        Console.WriteLine($"The CPU chose Rock! You chose {SelectionVariable}, you lost!");
                    }
                    Main();
                    break;
                case 2:
                    if (genRand == Selection)
                    {
                        Console.WriteLine($"The CPU chose Paper! You chose {SelectionVariable}, it's a tie!");
                    }
                    if (Selection == 3)
                    {
                        Console.WriteLine($"The CPU chose Paper! You chose {SelectionVariable}, you won!");
                    }
                    if (Selection == 1)
                    {
                        Console.WriteLine($"The CPU chose Paper! You chose {SelectionVariable}, you lost!");
                    }
                    Console.WriteLine($" ");
                    Main();
                    break;
                case 3:
                    if (genRand == Selection)
                    {
                        Console.WriteLine($"The CPU chose Scissors! You chose {SelectionVariable}, it's a tie!");
                    }
                    if (Selection == 1)
                    {
                        Console.WriteLine($"The CPU chose Scissors! You chose {SelectionVariable}, you won!");
                    }
                    if (Selection == 2)
                    {
                        Console.WriteLine($"The CPU chose Scissors! You chose {SelectionVariable}, you lost!");
                    }
                    Console.WriteLine($" ");
                    Main();
                    break;
                case 4:
                    Console.WriteLine($"Y u break my gaem?");
                    Main();
                    break;

            }



        }
    }
}