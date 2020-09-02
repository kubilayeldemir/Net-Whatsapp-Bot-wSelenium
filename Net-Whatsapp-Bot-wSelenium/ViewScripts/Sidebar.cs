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
    class Sidebar
    {
        IWebDriver driver;
        IWebElement sidebar,paneSide;

        public Sidebar(IWebDriver driver)
        {
            this.driver = driver;
        }

        public IWebElement findSidebar()
        {
            sidebar = driver.FindElement(By.Id("side"));
            return sidebar;
        }

        public void findPaneSide()
        {
            paneSide = driver.FindElement(By.Id("pane-side"));
        }

        public void selectPerson(string name)
        {            
            findSidebar().FindElement(By.XPath("//span[@title ='"+name+"']")).Click();
        }

        public void clickNewChat()
        {
            findSidebar().FindElement(By.XPath("//span[@data-testid = 'chat']")).Click();
        }
        
        public IWebElement newChatSideBar()
        {
            return driver.FindElement(By.XPath("//div[@data-tab ='" + 4 + "']"));
        }
              
    }
}
