using System;

namespace CyberSecurityChatbot
{
    public class Chatbot
    {
        public string UserName { get; set; }

        public void StartConversation()
        {
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.Write("\nPlease enter your name: ");
            Console.ResetColor();

            UserName = Console.ReadLine();

            if (string.IsNullOrWhiteSpace(UserName))
            {
                Console.WriteLine("Invalid name. Restart the program.");
                return;
            }

            Console.WriteLine($"\nWelcome, {UserName}! How can I assist you today?");
            RunChat();
        }

        private void RunChat()
        {
            while (true)
            {
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.Write("\nYou: ");
                Console.ResetColor();

                string input = Console.ReadLine();

                if (string.IsNullOrWhiteSpace(input))
                {
                    Console.WriteLine("I didn’t quite understand that. Could you rephrase?");
                    continue;
                }

                input = input.ToLower();

                input = input.Replace("?", "")
                             .Replace("!", "")
                             .Replace(".", "")
                             .Replace(",", "");

                if (input.Contains("exit") || input.Contains("bye"))
                {
                    Console.WriteLine($"Goodbye {UserName}! Stay safe online!");
                    break;
                }
                else if (input.Contains("hello") || input.Contains("hi") || input.Contains("hey"))
                {
                    Console.WriteLine($"Hello {UserName}! How can I help you today?");
                }
                else if (input.Contains("how") && input.Contains("you"))
                {
                    Console.WriteLine("I'm doing great and ready to help you stay safe online!");
                }
                else if (input.Contains("thank"))
                {
                    Console.WriteLine("You're welcome! I'm always here to help.");
                }
                else if (input.Contains("who") && input.Contains("you"))
                {
                    Console.WriteLine("I am your Cybersecurity Awareness Assistant, designed to help South Africans stay safe online.");
                }
                else if (input.Contains("ask") || input.Contains("help"))
                {
                    Console.WriteLine("You can ask me about passwords, phishing, malware, safe browsing, social engineering, or what to do if you get hacked.");
                }
                else if (input.Contains("password"))
                {
                    Console.WriteLine("Strong passwords should be at least 12 characters long and include uppercase letters, lowercase letters, numbers, and symbols.");
                }
                else if (input.Contains("phishing") || input.Contains("scam") || input.Contains("email"))
                {
                    Console.WriteLine("Phishing scams trick you into giving personal information through fake emails or messages.");
                }
                else if (input.Contains("malware") || input.Contains("virus"))
                {
                    Console.WriteLine("Malware is harmful software that can steal your data or damage your device.");
                }
                else if (input.Contains("social") || input.Contains("engineering"))
                {
                    Console.WriteLine("Social engineering is when attackers manipulate people into revealing confidential information.");
                }
                else if (input.Contains("browse") || input.Contains("website") || input.Contains("link"))
                {
                    Console.WriteLine("Always check for HTTPS in website URLs and avoid clicking unknown links.");
                }
                else if (input.Contains("hacked") || input.Contains("hack"))
                {
                    Console.WriteLine("If you believe you've been hacked, immediately change your passwords and enable two-factor authentication.");
                }
                else if (input.Contains("2fa") || input.Contains("two factor"))
                {
                    Console.WriteLine("Two-factor authentication adds an extra layer of protection.");
                }
                else
                {
                    Console.WriteLine("I'm not sure about that yet, but I can help with cybersecurity topics like phishing, passwords, malware, and safe browsing.");
                }
            }
        }
    }
}