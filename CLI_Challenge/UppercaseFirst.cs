using System;
namespace CLI_Challenge
{
    public class UppercaseFirst
    {
        static void Main(string[] args)
        {
            char[] array = args[1].ToCharArray();
            
            if (array.Length >= 1)
            {
                if (char.IsLower(array[0]))
                {
                    array[0] = char.ToUpper(array[0]);
                }

                for (int i = 1; i < array.Length; i++)
                {
                    if (array[i - 1] == ' ')
                    {
                        if (char.IsUpper(array[i]))
                        {
                            array[i] = char.ToLower(array[i]);
                        } 

                        else 
                        {
                            array[i] = char.ToUpper(array[i]);
                        }
                    }
                }
                
            }
            Console.WriteLine(string.Join("", array));
        }
    }
}