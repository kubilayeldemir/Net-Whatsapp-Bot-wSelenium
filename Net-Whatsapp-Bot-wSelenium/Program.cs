using OpenQA.Selenium;
using OpenQA.Selenium.Remote;
using System;

namespace Net_Whatsapp_Bot_wSelenium
{
    class Program
    {
        static void Main(string[] args)
        {

            SendMessage sm = new SendMessage();

            sm.MessageTo = "ARŞİV"; //Whatsapp name of group or person you want to send message
            sm.Message = "Hello"; //Your message.
            sm.PhotoPath = "C:\\kilicim.png"; //Photo path. Delete this line if you don't want to send a photo.
            sm.Run();

            
        }
    }
}
