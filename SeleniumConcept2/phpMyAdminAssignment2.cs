using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;

namespace SeleniumConcept2
{
    public class phpMyAdminAssignment2
    {
        static void Main4(string[] args)
        {
            IWebDriver driver = new ChromeDriver();
            driver.Manage().Window.Maximize();
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(20);

            driver.Url = "https://www.db4free.net/phpMyAdmin/";

            driver.FindElement(By.Id("input_username")).SendKeys("Admin");
            driver.FindElement(By.Id("input_password")).SendKeys("admin123");
            driver.FindElement(By.Id("input_go")).Click();
            string Geterror = driver.FindElement(By.XPath("//div[contains(text(),'Additional error information')]")).Text;
            Console.WriteLine(Geterror);
        }
    }
}
