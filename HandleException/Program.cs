using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HandleException
{
    class Program
    {
        static void Main(string[] args)
        {
            string url = "https://testing.todorvachev.com/class-name/";

            //wrong css selector path
            string csspath = "#search-2 > form > labelinput";
            IWebDriver driver = new ChromeDriver();
            driver.Navigate().GoToUrl(url);


            IWebElement CsspathElement;
            /* if (CsspathElement.Displayed)
             {
                 GreenMessage("Yes Csspath is visible");
             }
             else
             {
                 RedMessage("No classname is not visible");
             }*/
            try
            {
                CsspathElement = driver.FindElement(By.CssSelector(csspath));
                if (CsspathElement.Displayed)
                {
                    GreenMessage("Yes Csspath element  is visible");
                }

            }
            catch (NoSuchElementException)
            {
                RedMessage("Icant see the css path element");
            }
            driver.Quit();

        }
        private static void RedMessage(string message)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine(message);
            Console.ForegroundColor = ConsoleColor.White;
        }

        private static void GreenMessage(string message)
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine(message);
            Console.ForegroundColor = ConsoleColor.White;
        }
    }
}

