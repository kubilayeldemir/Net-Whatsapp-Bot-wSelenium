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
    class Tools
    {
        /// <summary>
        /// Focuses to element,hovers mouse over element.Usefull for dropdown menus.
        /// </summary>
        /// <param name="driver"></param>
        /// <param name="element"></param>
        public static void FocusToElement(IWebDriver driver, IWebElement element) //Focuses to element

        {
            Actions actions = new Actions(driver); //Focus to element.
            actions.MoveToElement(element);
            actions.Perform();


        }


    }
}
