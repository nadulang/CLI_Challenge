using System;
namespace CLI_Challenge
{
    public class Lowercase
    {
        static void Main(string[] args)
        {
            string result = args[1].ToLower();
            Console.WriteLine(string.Join(" ", result));
        }
    }
}
