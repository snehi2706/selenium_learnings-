using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RadioButton
{
    internal class Program
    {
        static IWebDriver driver = new ChromeDriver();
        static IWebElement RadioButton;

        static void Main(string[] args)
        {
            string url = "https://testing.todorvachev.com/radio-button-test/";
            string[] opt = { "1", "3", "5" };
            driver.Navigate().GoToUrl(url);
            for (int i = 0; i < opt.Length; i++)
            {
                RadioButton = driver.FindElement(By.CssSelector("#post-10 > div > form > p:nth-child(6) > input[type=\"radio\"]:nth-child("+ opt[i] +")"));
                if (RadioButton.GetAttribute("checked") == "true")
                {
                    Console.WriteLine("The" + (i + 1) + "radio button is checked");
                }
                else
                {
                    Console.WriteLine("This is one of the unchecked radio buton");
                }

            }
            driver.Quit();
        }
    }

}
