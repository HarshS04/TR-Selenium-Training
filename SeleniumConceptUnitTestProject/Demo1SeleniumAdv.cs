using OpenQA.Selenium.Chrome;
using OpenQA.Selenium;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using OpenQA.Selenium.Support.UI;

namespace SeleniumConceptUnitTestProject
{
    public class Demo1SeleniumAdv
    {
        [Test]
        public void Demo1MultipleTabsTest()
        {
            IWebDriver driver = new ChromeDriver();
            driver.Manage().Window.Maximize();
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(20);

            driver.Url = "https://www.db4free.net/";

            //click on phpMyAdmin »
            driver.FindElement(By.XPath("//b[contains(text(),'phpMyAdmin')]")).Click();

            //Swtich to 2nd tab
            driver.SwitchTo().Window(driver.WindowHandles[1]);

            //Write all inputs
            driver.FindElement(By.Id("input_username")).SendKeys("Admin");
            driver.FindElement(By.Id("input_password")).SendKeys("admin123");
            driver.FindElement(By.Id("input_go")).Click();

            //Close current tab
            driver.Close();

            //Switch to 1st tab and Print title
            driver.SwitchTo().Window(driver.WindowHandles[0]);
            Console.WriteLine(driver.Title);

            //Close chrome browser
            driver.Quit();
        }

        [Test]
        public void Demo2MultipleTabTest2()
        {
            IWebDriver driver = new ChromeDriver();
            driver.Manage().Window.Maximize();
            driver.Manage().Timeouts().ImplicitWait = TimeSpan.FromSeconds(20);

            driver.Url = "https://www.online.citibank.co.in/";

            //close all popup
            driver.FindElement(By.XPath("//a[@class='newclose']")).Click();
            driver.FindElement(By.XPath("//a[@class='newclose2']")).Click();

            //click on Banking
            driver.FindElement(By.Id("topMnubanking")).Click();

            //click on Citi Commercial Bank
            driver.FindElement(By.LinkText("Citi Commercial Bank")).Click();

            //click on Branch/ATM
            driver.SwitchTo().Window(driver.WindowHandles[1]);
            driver.FindElement(By.XPath("//a[contains(text(),'Branch/ATM')]")).Click();

            //Select Citibank ATM as Bengaluru -  dropdown without select tag
            driver.FindElement(By.XPath("//a[text()='Choose One']")).Click();
            driver.FindElement(By.LinkText("Bengaluru")).Click();

        }
    }
}
