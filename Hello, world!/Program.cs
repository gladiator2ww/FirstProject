using System;

namespace Hello__world_
{
    class Program
    {
        public static int GetSquare(int number)
        {
            int result = (int)Math.Pow(number, 2);
            return result;
        }
        public static void Print(int result)
        {
            Console.WriteLine(result);
        }
        public static void Main()
        {
            Print(GetSquare(42));
        }
    }
}
