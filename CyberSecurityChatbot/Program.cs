using System;

namespace CyberSecurityChatbot
{
    class Program
    {
        static void Main(string[] args)
        {
            UIHelper.DisplayHeader();
            AudioPlayer.PlayGreeting();

            Chatbot bot = new Chatbot();
            bot.StartConversation();
        }
    }
}