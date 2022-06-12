using System;

namespace LINQ_Deliga
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            Logic logic = new Logic();
            Console.WriteLine(logic.SumResult(logic.Sum, 3, 43, 331, 431));
        }
    }
}
