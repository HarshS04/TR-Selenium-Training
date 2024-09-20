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
    public class MediBuddyAssignment3
    {
        static void Main(string[] args)
        {
            IWebDriver driver = new ChromeDriver();
            driver.Manage().Window.Maximize();
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(20);

            driver.Url = "https://www.medibuddy.in/";

            driver.FindElement(By.LinkText("Login")).Click();
            driver.FindElement(By.XPath("//div[contains(text(),'Corporate Account')]")).Click();
            driver.FindElement(By.Id("corpphone")).SendKeys("786786");
            String GetErrorMsg = driver.FindElement(By.XPath("//div[contains(text(),'Please enter valid 10')]")).Text;
            Console.WriteLine(GetErrorMsg);

        }
    }
}
