using OpenQA.Selenium;
using OpenQA.Selenium.Remote;
using System;

namespace Net_Whatsapp_Bot_wSelenium
{
    class Program
    {
        static void Main(string[] args)
        {

            //SendMessage sendmessage = new SendMessage();

            //sendmessage.Run();

            
            string USERNAME = "alexanderdepauli1";
            string AUTOMATE_KEY = "qrPzevPH3rnrJWnT7qrD";

            DesiredCapabilities caps = new DesiredCapabilities();

            caps.SetCapability("os", "Windows");
            caps.SetCapability("os_version", "10");
            caps.SetCapability("browser", "Chrome");
            caps.SetCapability("browser_version", "80");
            caps.SetCapability("browserstack.user", USERNAME);
            caps.SetCapability("browserstack.key", AUTOMATE_KEY);
            caps.SetCapability("name", "alexanderdepauli1's First Test");

            IWebDriver driver;
            driver = new RemoteWebDriver(
              new Uri("https://hub-cloud.browserstack.com/wd/hub/"), caps
            );
            driver.Navigate().GoToUrl("https://www.herrenausstatter.de");

            try
            {
                Console.WriteLine(driver.Title);

                IWebElement query = driver.FindElement(By.Name("q"));
                query.SendKeys("Browserstack");
                query.Submit();
                Console.WriteLine(driver.Title);

                driver.Quit();
            }
            catch(Exception e)
            {
                Console.WriteLine(e.Message);
                Console.WriteLine(e.ToString());
                driver.Quit();
                Console.ReadLine();
            }
            



            //List<IScript> scripts = new List<IScript>();

            //scripts.Add(new ExperimentalScript());

            //scripts.Add(new CheckTopBrands());
            //scripts.Add(new LoginAndBuy());
            //scripts.Add(new RegisterAndBuy());
            //scripts.Add(new CheckServices());


            /*
            for (int i = 0; i < scripts.Count; i++)
            {
                try
                {
                    scripts.ElementAt(i).test();
                }
                catch (Exception e)
                {
                    Tools.TakeScreenshot(scripts.ElementAt(i).Driver());
                    Console.WriteLine(scripts.ElementAt(i).Driver().Title);
                    Console.WriteLine(scripts.ElementAt(i).Driver().Url);
                    Console.WriteLine(e.Message);
                    if (scripts.ElementAt(i).isCritical())
                    {
                        Console.WriteLine("Send Message");
                    }

                    scripts.ElementAt(i).Driver().Quit();

                }

            }

            */


        }
    }
}
