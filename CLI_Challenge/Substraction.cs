using System;
using System.Linq;

namespace CLI_Challenge
{
    public class Substraction
    {
        static void Main(string[] args)
        {
            var angka = args.ToList().GetRange(1, args.Length - 1).ToList().ConvertAll(j => Convert.ToInt32(j));
            int subs;

            subs = angka[0] - angka.GetRange(1, angka.Count - 1).Sum();
            Console.WriteLine(String.Join("", subs));
            
            
        }
            
    }
}
