using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace DropdownMenu
{
     
    internal class Program
    {
        static IWebDriver driver  = new ChromeDriver();
        static IWebElement DropDown;
        static IWebElement DropUp;
        static void Main(string[] args)
        {
            string url = "https://testing.todorvachev.com/drop-down-menu-test/";
            string CSSpath = "#post-6 > div > p:nth-child(6) > select > option:nth-child(3)";
            driver.Navigate().GoToUrl(url);
            DropDown = driver.FindElement(By.Name("DropDownTest"));
            Console.WriteLine(DropDown.GetAttribute("The selected value is: " + DropDown.GetAttribute("value")));
            DropUp = driver.FindElement(By.CssSelector(CSSpath));

            Console.WriteLine("The third is: " + DropUp.GetAttribute("value"));
            DropUp.Click();
            Console.WriteLine("Selected value is " + DropUp.GetAttribute("value"));

            for (int i = 1; i <= 4; i++)
            {
                CSSpath = "#post-6 > div > p:nth-child(6) > select > option:nth-child(" + i +")";
                DropUp = driver.FindElement(By.CssSelector(CSSpath));
                Console.WriteLine("The" + i + "option is " + DropUp.GetAttribute("value")); 
            }

            Thread.Sleep(3000);
            driver.Quit();
        }
    }
}
