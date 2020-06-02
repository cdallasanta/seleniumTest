using System;
using System.Collections.Generic;
using System.Threading;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using OpenQA.Selenium.Firefox;

namespace SeleniumApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("What is your eTrade username?");
            string username = Console.ReadLine();
            Console.WriteLine("What is your eTrade password?");
            string password = Console.ReadLine();

            IWebDriver driver = new FirefoxDriver { Url = "https://us.etrade.com/e/t/user/login" };

            driver.FindElement(By.Id("user_orig")).SendKeys(username);
            driver.FindElement(By.Name("PASSWORD")).SendKeys(password);
            driver.FindElement(By.Id("logon_button")).Click();
            
            IWebElement accountElement = driver.FindElement(By.CssSelector("span.accountvalues-data"));
            string accountTotal = accountElement.Text;
            Console.Write(accountTotal);
            driver.Quit();

            //made a change
        }
    }
}
