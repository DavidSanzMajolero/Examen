﻿using System;
namespace UltimEx
{
    public static class Program
    {
        public static void Main()
        {
            int decition, num;
            const string Menu = "1. Validate\n2. Pow\n3. Random\n4. Count\n5. Exit";
            const string Even = "EVEN";
            const string Odd = "ODD";
            const string Ask = "Enter a number";
            const string Text = "Enter a text";
            const string Exit = "Exit";

            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine(Menu);
            Console.ResetColor();
            decition = Convert.ToInt32(Console.ReadLine());
            switch(decition)
            {
                case 1:
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine(Ask);
                    Console.ResetColor();
                    do
                    {
                        num = Convert.ToInt32(Console.ReadLine());

                    } while (num < 0);
                    Console.ForegroundColor = ConsoleColor.Blue;
                    Console.WriteLine(LibraryFunctions.Functions.Validate(num) == true ? Even : Odd);
                    Console.ResetColor();
                    break;
                case 2:
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine(Ask);
                    Console.ResetColor();
                    do
                    {
                        num = Convert.ToInt32(Console.ReadLine());

                    } while (num < 0);
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine(Ask);
                    Console.ResetColor();
                    int pow;
                    do
                    {
                        pow = Convert.ToInt32(Console.ReadLine());

                    } while (pow < 0); 
                    double result = LibraryFunctions.Functions.Pow(num, pow);
                    Console.ForegroundColor = ConsoleColor.Blue;
                    Console.WriteLine($"The result of the pow is: {result}");
                    Console.ResetColor();
                    break;
                case 3:
                    num = LibraryFunctions.Functions.Random();
                    Console.ForegroundColor = ConsoleColor.Blue;
                    Console.WriteLine($"Your random number is: {num}");
                    Console.ResetColor();        
                    break;
                case 4:
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine(Text);
                    Console.ResetColor();
                    string texto = Console.ReadLine();
                    Console.ForegroundColor = ConsoleColor.Blue;
                    LibraryFunctions.Functions.ContarVocalsConsonants(texto);
                    break;
                default:
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine(Exit);
                    Console.ResetColor();
                    break;
            }
        }
    }
}

