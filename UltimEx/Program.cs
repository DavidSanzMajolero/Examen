using System;
namespace UltimEx
{
    public static class Program
    {
        public static void Main()
        {
            int decition;
            const string Menu = "1. Validate\n2. Pow\n3. Random\n4. Count\n5. Exit";
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine(Menu);
            Console.ResetColor();
            decition = Convert.ToInt32(Console.ReadLine());
            switch(decition)
            {
                case 1:
                    Console.WriteLine("Validate");
                    break;
                case 2:
                    Console.WriteLine("Pow");
                    break;
                case 3:
                    Console.WriteLine("Random");
                    break;
                case 4:
                    Console.WriteLine("Count");
                    break;
                case 5:
                    Console.WriteLine("Exit");
                    break;
                default:
                    Console.WriteLine("Invalid option");
                    break;
            }
            

        }
    }
}
