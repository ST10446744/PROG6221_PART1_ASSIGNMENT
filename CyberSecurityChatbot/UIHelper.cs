using System;
using System.Threading;

namespace CyberSecurityChatbot
{
    public static class UIHelper
    {
        public static void DisplayHeader()
        {
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Green;

            Console.WriteLine("=================================================================");
            Console.WriteLine(@" 
   ██████╗██╗   ██╗██████╗ ███████╗██████╗ 
  ██╔════╝╚██╗ ██╔╝██╔══██╗██╔════╝██╔══██╗
  ██║      ╚████╔╝ ██████╔╝█████╗  ██████╔╝
  ██║       ╚██╔╝  ██╔══██╗██╔══╝  ██╔══██╗
  ╚██████╗   ██║   ██████╔╝███████╗██║  ██║
   ╚═════╝   ╚═╝   ╚═════╝ ╚══════╝╚═╝  ╚═╝
            CYBERSECURITY AWARENESS BOT
");
            Console.WriteLine("=================================================================");

            Console.ResetColor();

            Console.ForegroundColor = ConsoleColor.DarkCyan;
            Console.WriteLine("\nProtecting South African Citizens From Cyber Threats...\n");
            Console.ResetColor();

            Thread.Sleep(1200);

        }
    }
}