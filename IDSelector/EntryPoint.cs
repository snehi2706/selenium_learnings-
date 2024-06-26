using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IDSelector
{
    class EntryPoint
    {
        static void Main(string[] args)
        {
            string url = "https://testing.todorvachev.com/id/";
            string ID = "testImage";
            IWebDriver Driver = new ChromeDriver();
            Driver.Navigate().GoToUrl(url);
            IWebElement element = Driver.FindElement(By.Id(ID));
            if (element.Displayed)
            {
                GreenMessage("Yes ID is visible");
            }
            else
            {
                RedMessage("No ID is not visible");
            }
            Driver.Quit();
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
