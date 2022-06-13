using System;
using System.Linq;

namespace LINQ_Deliga
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            Iinitialition iinitialition = new Iinitialition();
            ContactLsitcs[] list = iinitialition.Iinitialize();
            var result0 = list.FirstOrDefault(x => x.Id == 0);
            Console.WriteLine(result0.Name + " " + result0.Surname);
            var result00 = list.Select(x => x.Surname.Length == 10);
            Console.WriteLine(result00);
            var result1 = list.Where(x => x.Name.ToLower() == x.Name);
            foreach (ContactLsitcs result in result1)
            {
                Console.WriteLine(result.Name);
            }

            var result2 = list.GroupBy(x => x.Id).Reverse();
            var result3 = list.Where(x => x.Surname.StartsWith('a'));
            var result4 = result1.Except(result3);
            Console.WriteLine();
            foreach (ContactLsitcs result in result4)
            {
                Console.WriteLine(result.Id);
            }
        }
    }
}
