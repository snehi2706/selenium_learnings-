using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace TextInputField
{
    class EntryPoint
    {
        static IWebDriver driver = new ChromeDriver();
        static IWebElement TextBoxelement;
        static void Main(string[] args)
        {
            string url = "https://testing.todorvachev.com/text-input-field/";
            string txt;
            
            driver.Navigate().GoToUrl(url);
            TextBoxelement = driver.FindElement(By.Name("username"));
            txt = Console.ReadLine();
            TextBoxelement.SendKeys(txt);
            Thread.Sleep(3000);
            //To Get output of text that we write 
            Console.WriteLine(TextBoxelement.GetAttribute("value"));
            //To clear the text that we are inserting, TextBoxelement.Clear();
            Thread.Sleep(5000);
            driver.Quit();
        }
    }
}
