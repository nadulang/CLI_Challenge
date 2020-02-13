using System;
using System.Linq;

namespace CLI_Challenge
{
    public class Division
    {
        static void Main(string[] args)
        {
            var angka = args.ToList().GetRange(1, args.Length - 1).ToList().ConvertAll(j => Convert.ToInt32(j));

            double div = angka[0];
            for (int i =1; i<angka.Count; i++)
            {
                div /= angka[i];
                Console.WriteLine(String.Join("", div));
            }

            
        }
    }
}
