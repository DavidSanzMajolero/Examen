namespace LibraryFunctions
{
    public static class Functions
    {
        public static bool Validate(int num)
        {
            return num % 2 == 0;
        }
        public static double Pow(int num, int pow)
        {
            return Math.Pow(num, pow);
        }
        public static int Random()
        {
            const string Ask = "Enter a number";
            int num, secondNum;
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine(Ask);
            Console.ResetColor();
            num = Convert.ToInt32(Console.ReadLine());
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine(Ask);
            Console.ResetColor();
            secondNum = Convert.ToInt32(Console.ReadLine());
            Random rand = new Random();
            return rand.Next(num, secondNum);
        }
        public static void ContarVocalsConsonants(string texto)
        {
            int numVocals = 0, numConsonants = 0;
            string vocals = "aeiouAEIOU";

            foreach (char i in texto)
            {
                if (vocals.Contains(i))
                    numVocals++;
                else if (char.IsLetter(i))
                    numConsonants++;
            }
            Console.WriteLine($"Number of vowels: {numVocals}");
            Console.WriteLine($"Number of consonants: {numConsonants}");
        }
    }

}
