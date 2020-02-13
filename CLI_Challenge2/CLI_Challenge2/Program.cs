using System;
using McMaster.Extensions.CommandLineUtils;
using System.Net.NetworkInformation;
using System.Linq;
using System.Net;
using System.Net.Sockets;

namespace CLI_Challenge
{
    [HelpOption("--hlp")]
    [Subcommand(
             typeof(Add),
             typeof(Palindrome),
             typeof(IPAddressPrivate),
             typeof(IPAddressExternal)
         )]
    class Program
    {
        public static int Main(string[] args)
        {
            return CommandLineApplication.Execute<Program>(args);
        }
    }

    //yang dicomment dari slack Pak Maulana, yang saya ga pake mcmaster untuk no. 1-2 dan 4

    //[Command(Description = "Command to uppercase string", Name = "uppercase")]

    //class UpperCase
    //{
    //    [Argument(0)]
    //    public string text { get; set; }
    //    public void OnExecute(CommandLineApplication app)
    //    {
    //        Console.WriteLine($"{text.ToUpper()}");
    //    }
    //}
    //[Command(Description = "Command to lowercase string", Name = "lowercase")]
    //class LowerCase
    //{
    //    [Argument(0)]
    //    public string text { get; set; }
    //    public void OnExecute(CommandLineApplication app)
    //    {
    //        Console.WriteLine($"{text.ToLower()}");
    //    }
    //}

    [Command(Description = "Command to palindrome", Name = "palindrome")]
    class Palindrome
    {
        [Argument(0)]
        public string str { get; set; }
        public void OnExecute(CommandLineApplication app)
        {
            char[] word2 = str.ToCharArray();
            Array.Reverse(word2);
            string word3 = new string(word2);
            if (str == word3)
            {
                Console.WriteLine("Is palindrome? Yes");
            }
            else
            {
                Console.WriteLine("Is palindrome? No");
            }
        }
    }


    [Command(Description = "Command to add number", Name = "add")]
    class Add
    {
        [Argument(0)]
        public string num { get; set; }
        public void OnExecute(CommandLineApplication app)
        {
            long sum = 0;
            String[] Num = num.Split('_');
            for (int i = 0; i < Num.Length; i++)
            {
                int number = Convert.ToInt32(Num[i]);
                sum += number;
            }
            Console.WriteLine(sum);
        }
    }

    [Command(Description = "Command to show private IP Address", Name = "ip")]
    class IPAddressPrivate
    {
        public void OnExecute(CommandLineApplication app)
        {
            string hostName = Dns.GetHostName();
            Console.WriteLine(hostName);

            string myIP = Dns.GetHostByName(hostName).AddressList[3].ToString();
            Console.WriteLine("My IP Address is :" + myIP);
            Console.ReadKey();
        }
    }

    [Command(Description = "Command to show external IP Address", Name = "ip-external")]
    class IPAddressExternal
    {
        public void OnExecute(CommandLineApplication app)
        {
            IPHostEntry myIPHostEntry = Dns.GetHostEntry(Dns.GetHostName());

            foreach (IPAddress myIPAddress in myIPHostEntry.AddressList)
            {
                byte[] ipBytes = myIPAddress.GetAddressBytes();

                if (myIPAddress.AddressFamily == System.Net.Sockets.AddressFamily.InterNetwork)
                {

                    Console.WriteLine(myIPAddress);

                }
            }

        }
    }
}
