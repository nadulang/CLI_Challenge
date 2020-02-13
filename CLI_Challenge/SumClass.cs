using System;
using System.Linq;

namespace CLI_Challenge
{
    public class SumClass
    {
        static void Main(string[] args)
        {
            var angka = args.ToList().GetRange(1, args.Length - 1).ToList().ConvertAll(j => Convert.ToInt32(j));
            int sum = angka.Sum();

            
            
            Console.WriteLine(string.Join(" ", sum));
        }
    }
}
