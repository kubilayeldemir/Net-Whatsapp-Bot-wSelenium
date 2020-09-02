using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support;




namespace Net_Whatsapp_Bot_wSelenium
{
    class SendMessage
    {
        private string messageTo;
        private string message;
        private string photoPath;
        

        

        DriverFactory driverFactory = new DriverFactory();
        IWebDriver driver; //= driverFactory.createWebDriver();

        public string MessageTo { get => messageTo; set => messageTo = value; }
        public string Message { get => message; set => message = value; }
        public string PhotoPath { get => photoPath; set => photoPath = value; }

        public void Run()
        {        
            driver = driverFactory.createWebDriver();
            
            
            Sidebar sidebar = new Sidebar(driver);

            driver.Navigate().GoToUrl("https://web.whatsapp.com");
            Console.WriteLine("You need to login to your whatsapp acc.");
            Console.WriteLine("Open your whatsapp app at your phone and scan the QR code.");
            Console.WriteLine("If you already logged in, you don't need to scan QR");
            sleep(15000);

            //sidebar.clickNewChat();
            //sleep(5000);
            sidebar.selectPerson(MessageTo);
            sleep(15000);
            
            Footer footer = new Footer(driver);
            footer.sendMessageToSelectedPerson(Message);
            sleep(5000);
            if(photoPath != null)
            {
                Main main = new Main();
                main.sendImage(driver, "C:\\kilicim.png");
            }
            sleep(5000);
            driver.Quit();



            

        }

        private void sleep(int ms)
        {
            System.Threading.Thread.Sleep(ms);
        }

    }
}
