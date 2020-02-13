using System;
namespace CLI_Challenge
{
    public class Uppercase
    {
        static void Main(string[] args)
        {
            string result = args[1].ToUpper();
            Console.WriteLine(string.Join(" ", result));
        }
    }
    
}
