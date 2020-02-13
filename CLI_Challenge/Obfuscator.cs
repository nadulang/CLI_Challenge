using System;
using System.Collections.Generic;

namespace CLI_Challenge
{
    public class Obfuscator
    {
        static void Main(string[] args)
        {
            String email = "email@example.com";
            char[] Email = email.ToCharArray();
            List<string> Obfused = new List<string>();
            for (int i = 0; i < Email.Length; i++)
            {
                Obfused.Add($"&#{Convert.ToString(Convert.ToInt32(Email[i]))}");
            }
            Console.WriteLine(String.Join(";", Obfused));
        }
    }
}
