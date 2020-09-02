using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support;
using OpenQA.Selenium.Interactions;

namespace Net_Whatsapp_Bot_wSelenium
{
    class Main
    {
        
        
        public void sendImage(IWebDriver driver,string imageAddress)
        {
            driver.FindElement(By.XPath("//span[@data-testid ='clip']")).Click();
            System.Threading.Thread.Sleep(2000);
            IWebElement inputElement = driver.FindElement(By.XPath("//input[@accept ='image/*,video/mp4,video/3gpp,video/quicktime']"));            
            inputElement.SendKeys(imageAddress);
            System.Threading.Thread.Sleep(2000);
            driver.FindElement(By.XPath("//span[@data-testid ='send']")).Click();
        }

        //Actions.dragAndDrop(Sourcelocator, Destinationlocator)
    }
}
