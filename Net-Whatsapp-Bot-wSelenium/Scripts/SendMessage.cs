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
    class SendMessage:IScript
    {

        DriverFactory driverFactory = new DriverFactory();
        IWebDriver driver; //= driverFactory.createWebDriver();
       
        public void Run()
        {
            //GetCookies getcookies = new GetCookies();
            //IReadOnlyCollection<Cookie> allCookies = getcookies.Run();
            driver = driverFactory.createWebDriver();
            //for(int i = 0; i < allCookies.Count; i++)
            //{
            //    driver.Manage().Cookies.AddCookie(allCookies.ElementAt(i));
            //}
            
            Sidebar sidebar = new Sidebar(driver);

            driver.Navigate().GoToUrl("https://web.whatsapp.com");
            sleep(15000);

            sidebar.clickNewChat();
            sleep(15000);
            sidebar.selectPerson("Caner Abi Travian");
            sleep(15000);
            //sidebar.selectPerson("ARŞİV");
            //sleep(5000);
            //Footer footer = new Footer(driver);
            //footer.sendMessageToSelectedPerson("Merhaba Whatsapp");
            //sleep(5000);
            //Main main = new Main();
            //main.sendImage(driver, "C:\\kilicim.png");
            //sleep(10000);
            driver.Quit();


            

        }

        private void sleep(int ms)
        {
            System.Threading.Thread.Sleep(ms);
        }

    }
}
