using OpenQA.Selenium;
using OpenQA.Selenium.Chrome;
using OpenQA.Selenium.Support.UI;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SeleniumConcept2
{
    public class Demo2FBSignUp
    {
        static void Main(string[] args)
        {
            IWebDriver driver = new ChromeDriver();
            driver.Manage().Window.Maximize();
            driver.Manage().Timeouts().ImplicitWait=TimeSpan.FromSeconds(20);


            driver.Url = "https://www.facebook.com/"; //Wait for page load to complete

            //FindElemet -  checks for presence of locator in 0.5s
            driver.FindElement(By.LinkText("Sign up for Facebook")).Click();  

            //FindElemet -  checks for presence of locator in 0.5s
            driver.FindElement(By.Name("firstname")).SendKeys("Lisa");
            driver.FindElement(By.Name("lastname")).SendKeys("Anderson");
            driver.FindElement(By.Name("reg_passwd__")).SendKeys("John123");
            driver.FindElement(By.XPath("//input[@value=\'-1\']")).Click();

            //Dropdown - select date
            SelectElement selectday = new SelectElement(driver.FindElement(By.Id("day")));
            selectday.SelectByText("17");

            //Dropdown - select Month
            SelectElement selectmonth = new SelectElement(driver.FindElement(By.Id("month")));
            selectmonth.SelectByText("Jun");

            //Dropdown - select Year
            SelectElement selectyear = new SelectElement(driver.FindElement(By.Id("year")));
            selectyear.SelectByText("1992");

            //Click on sign up
            driver.FindElement(By.Name("websubmit")).Click();


        }
    }
}