using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassNameSelector
{
    class EntryPoint
    {
        static void Main(string[] args)
        {
            string url = "https://testing.todorvachev.com/class-name/";
            //correct senario of using css path, if we give any wrong path then it throws exception 
            string csspath = "#search-2 > form > label > input";
            string xpath = "//*[@id=\"search-2\"]/form/label/input";
            string className = "testClass";

            IWebDriver driver = new ChromeDriver();
            driver.Navigate().GoToUrl(url);

            IWebElement element = driver.FindElement(By.ClassName(className));
            IWebElement CsspathElement = driver.FindElement(By.CssSelector(csspath));
            IWebElement XpathElement = driver.FindElement(By.XPath(xpath));

            if (CsspathElement.Displayed)
            {
                GreenMessage("Yes Csspath is visible");
            }
            else
            {
                RedMessage("No classname is not visible");
            }
            if (XpathElement.Displayed)
            {
                GreenMessage("Yes Xpath is visible");
            }
            else
            {
                RedMessage("No classname is not visible");
            }
            if (element.Displayed)
            {
                GreenMessage("Yes classname is visible");
            }
            else
            {
                RedMessage("No classname is not visible");
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
