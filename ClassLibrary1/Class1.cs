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
    }

}
