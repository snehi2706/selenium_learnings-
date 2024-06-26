using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace CheckBox
{
    class Program
    {
        static IWebDriver driver = new ChromeDriver(); 
        static IWebElement CheckBoxelement;
        static void Main(string[] args)
        {
            //string url = "https://testing.todorvachev.com/check-button-test-3/";
            string url;
            url = Console.ReadLine();

            string option = "1";
            driver.Navigate().GoToUrl(url);
            CheckBoxelement = driver.FindElement(By.CssSelector("#post-33 > div > p:nth-child(8) > input[type=\"checkbox\"]:nth-child(" + option + ")"));
            CheckBoxelement.Click();
            //option = "3";
            //CheckBoxelement = driver.FindElement(By.CssSelector("#post-33 > div > p:nth-child(8) > input[type=\"checkbox\"]:nth-child(" + option + ")"));
            //Console.WriteLine(CheckBoxelement.GetAttribute("value"));
            if (CheckBoxelement.GetAttribute("checked") == "true") {
                Console.WriteLine("Check Box is checked");
            }
            else
            {
                Console.WriteLine("Not Checked");
            }
            Thread.Sleep(4000);
            driver.Quit();
        }
    }
}
