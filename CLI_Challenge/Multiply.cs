using System;
using System.Linq;

namespace CLI_Challenge
{
    public class Multiply
    {
        static void Main(string[] args)
        {
            var angka = args.ToList().GetRange(1, args.Length - 1).ToList().ConvertAll(j => Convert.ToInt32(j));
            int multi = 1;
            for (int i = 0; i<angka.Count; i++)
            {
                multi *= angka[i];
            }
            Console.WriteLine(String.Join("", multi));
        }
    }
}
