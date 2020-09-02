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
    class Footer
    {
        IWebDriver driver;
        public Footer(IWebDriver driver)
        {
            this.driver = driver;
        }

        public void sendMessageToSelectedPerson(string message)
        {
            IWebElement textbox = driver.FindElement(By.XPath("//div[@data-tab ='" + 1 + "']"));
            textbox.SendKeys(message);
            System.Threading.Thread.Sleep(500);
            textbox.SendKeys(Keys.Enter);
        }
    }
}
