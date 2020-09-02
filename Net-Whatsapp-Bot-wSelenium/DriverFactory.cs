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
    class DriverFactory
    {
        private int implicitWaitSeconds = 40;


        public IWebDriver createWebDriver()
        {
            IWebDriver driver = new ChromeDriver(fullScreenWithCookies());
            
            setImplicitWait(driver, implicitWaitSeconds);
            return driver;
        }

        public IWebDriver createEAGERDriver()
        {


            ChromeOptions chromeOptions = eagerDriverOptions();
            
            IWebDriver driver = new ChromeDriver(chromeOptions);
            setImplicitWait(driver, implicitWaitSeconds);
            return driver;
        }


        private ChromeOptions eagerDriverOptions()
        {
            ChromeOptions options = new ChromeOptions();
            options.PageLoadStrategy = PageLoadStrategy.Eager;
            options.AddArgument("--start-maximized");
            return options;
        }


        private ChromeOptions fullScreenWithCookies()
        {
            ChromeOptions options = new ChromeOptions();

            

            //parametre.SetValue("--no-sandbox", 0);
            //parametre.SetValue("--start-maximized", 1);            
            options.AddArgument("--start-maximized");
            options.AddArgument("--user-data-dir=chrome-data");
            //options.AddArguments(parametre);
            return options;
        }

        public void setImplicitWait(IWebDriver driver, int seconds)
        {
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(seconds);

        }



        public void quitDriver(IWebDriver driver)
        {
            driver.Quit();
        }
        //driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(40);

        public int ImplicitWaitSeconds { get => implicitWaitSeconds; set => implicitWaitSeconds = value; }





    }
}
