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
    class GetCookies : IScript
    {
        DriverFactory driverFactory = new DriverFactory();
        IWebDriver driver; //= driverFactory.createWebDriver();
        public IReadOnlyCollection<Cookie> Run()
        {
            driver = driverFactory.createWebDriver();
            Sidebar sidebar = new Sidebar(driver);
            driver.Navigate().GoToUrl("https://web.whatsapp.com");
            sleep(15000);
            IReadOnlyCollection<Cookie> allCookies = driver.Manage().Cookies.AllCookies;
            driver.Quit();
            return allCookies;
        }

        void IScript.Run()
        {
            throw new NotImplementedException();
        }

        private void sleep(int ms)
        {
            System.Threading.Thread.Sleep(ms);
        }


    }
}
